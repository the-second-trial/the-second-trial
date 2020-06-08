/// <summary>
/// Andrea Tino - 2020
/// </summary>

using System;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace TheSecondTrial.Animation
{
    /// <summary>
    /// Orchestrates and manages animations.
    /// </summary>
    public class AnimationOrcherstrator
    {
        private readonly AnimationClip clip;
        private readonly GameObject gameObject;

        private Component eventHookerComponent;
        private List<string> registeredHandlerIds;

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AnimationOrcherstrator"/> class.
        /// </summary>
        /// <param name="clip">The animation clip.</param>
        /// <param name="gameObject">
        /// The game object the animation is applied to.
        /// If left unspecified, an attempt is made at finding it by searching inside
        /// <paramref name="clip"/> to go up to its animator controller and from there up
        /// to the object it is assigned to. If not found an exception is thrown.
        /// </param>
        public AnimationOrcherstrator(AnimationClip clip, GameObject gameObject = null)
        {
            if (clip == null)
            {
                throw new ArgumentNullException(nameof(clip));
            }

            this.registeredHandlerIds = new List<string>();
            this.clip = clip;

            this.gameObject = gameObject;
            if (this.gameObject == null)
            {
                // Try to get to the object the animation is applied to
                this.gameObject = RetrieveGameObjectFromClip(clip);
            }

            if (this.gameObject == null)
            {
                throw new InvalidOperationException("Could not retrieve the animation object");
            }
        }

        /// <summary>
        /// Adds an event.
        /// </summary>
        /// <param name="time">The time.</param>
        /// <param name="callback">The callback.</param>
        public void AddEvent(float time, Action callback)
        {
            // Create the ID for this event
            string id = Utils.GetId();
            this.registeredHandlerIds.Add(id);

            AnimationUtility.SetAnimationEvents(this.clip, new[]
            {
                new AnimationEvent()
                {
                    time = time,
                    functionName = nameof(ComponentEventHooker.HandleEvent),
                    stringParameter = id
                }
            });

            // Make sure the object the animation clip is applied to has a
            // script exposing a function with the specified name
            // Only do this once
            var eventHookerScript = this.gameObject.GetComponent<ComponentEventHooker>();
            if (eventHookerScript == null)
            {
                // First time, then add
                this.eventHookerComponent = this.gameObject.AddComponent<ComponentEventHooker>();
            }

            // Register the handler
            AnimationEventBroker.Instance.RegisterHandler(id, callback);
        }

        /// <summary>
        /// Disposes the object.
        /// </summary>
        public void Dispose()
        {
            // Unregister handler
            foreach (var id in this.registeredHandlerIds)
            {
                AnimationEventBroker.Instance.UnregisterHandler(id);
                // TODO: Log in case one unresgistration did not succeed
            }
            this.registeredHandlerIds = null;

            // Remove the hooker script component
            if (this.eventHookerComponent != null)
            {
                UnityEngine.Object.Destroy(this.eventHookerComponent);
                this.eventHookerComponent = null;
            }
        }

        private static GameObject RetrieveGameObjectFromClip(AnimationClip clip)
        {
            // Path is: GameObject -> Animator component -> Controller -> State (animation clip)

            return null; // TODO
        }
    }
}
