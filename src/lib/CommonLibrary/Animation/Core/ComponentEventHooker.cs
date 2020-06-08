/// <summary>
/// Andrea Tino - 2020
/// </summary>

using System;

using UnityEngine;

namespace TheSecondTrial.Animation
{
    /// <summary>
    /// Acts as a binder between the object an animation is applied on
    /// and the orchestrator. When an event is set, the object the
    /// animation clip is applied on must have a script with a method
    /// to call when the event occurs, this class injects that method.
    /// </summary>
    internal class ComponentEventHooker : MonoBehaviour
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ComponentEventEventHooker"/> class.
        /// </summary>
        public ComponentEventHooker() : base()
        {
        }

        /// <summary>
        /// Function to call when the event is trigered.
        /// </summary>
        /// <param name="id">The identifier of the handler.</param>
        public void HandleEvent(string id)
        {
            // Retrieve the handler from the broker
            Action handler = AnimationEventBroker.Instance[id];
            if (handler == null)
            {
                throw new InvalidOperationException($"Cannot retrieve handler for id '{id}'");
            }

            handler.Invoke(); // Invoke the handler
        }
    }
}
