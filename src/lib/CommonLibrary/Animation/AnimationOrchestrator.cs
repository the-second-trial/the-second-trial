/// <summary>
/// Andrea Tino - 2020
/// </summary>

using System;

using UnityEngine;
using UnityEditor;
using UnityEditor.Animations;

namespace TheSecondTrial.Animation
{
    /// <summary>
    /// Orchestrates and manages animations.
    /// </summary>
    public class AnimationOrcherstrator
    {
        private AnimationClip clip;
        private UnityEngine.Object gameObject;

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
        public AnimationOrcherstrator(AnimationClip clip, UnityEngine.Object gameObject = null)
        {
            if (clip == null)
            {
                throw new ArgumentNullException(nameof(clip));
            }

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
            AnimationUtility.SetAnimationEvents(this.clip, new[]
            {
                new AnimationEvent()
                {
                    time = time,
                    functionName = nameof(ComponentEventEventHooker.HandleEvent)
                }
            });

            // Make sure the object the animation clip is applied to has a
            // script exposing a function with the specified name
        }

        /// <summary>
        /// Disposes the object.
        /// </summary>
        public void Dispose()
        {
            this.clip = null;
        }

        private static UnityEngine.Object RetrieveGameObjectFromClip(UnityEngine.Object clip)
        {
            return null;
        }

        #region Types

        /// <summary>
        /// Represents a callback to run when the event occurs.
        /// </summary>
        public delegate void EventCallback();

        /// <summary>
        /// Acts as a binder between the object an animation is applied on
        /// and the orchestrator. When an event is set, the object the
        /// animation clip is applied on must have a script with a method
        /// to call when the event occurs, this class injects that method.
        /// </summary>
        private class ComponentEventEventHooker
        {
            private Action action;

            /// <summary>
            /// Initializes a new instance of the
            /// <see cref="ComponentEventEventHooker"/> class.
            /// </summary>
            /// <param name="action">
            /// The action to run when the event is triggered.
            /// </param>
            public ComponentEventEventHooker(EventCallback action)
            {
            }

            /// <summary>
            /// Function to call when the event is trigered.
            /// </summary>
            /// <param name="id">The ID event.</param>
            public void HandleEvent(string id)
            {
                this.action();
            }
        }

        #endregion
    }
}
