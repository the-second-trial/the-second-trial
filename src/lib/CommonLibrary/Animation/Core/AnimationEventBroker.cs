/// <summary>
/// Andrea Tino - 2020
/// </summary>

using System;
using System.Collections.Generic;

namespace TheSecondTrial.Animation
{
    /// <summary>
    /// Central hub for correctly associating animation events and their
    /// handlers.
    /// </summary>
    internal class AnimationEventBroker
    {
        private static AnimationEventBroker instance;

        private Dictionary<string, Action> registry;

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AnimationEventBroker"/> class.
        /// </summary>
        private AnimationEventBroker()
        {
            this.registry = new Dictionary<string, Action>();
        }

        /// <summary>
        /// Gets the singleton instance of the
        /// <see cref="AnimationEventBroker"/> class.
        /// </summary>
        public static AnimationEventBroker Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AnimationEventBroker();
                }

                return instance;
            }
        }

        /// <inheritdoc path="RetrieveHandler"/>.
        public Action this[string id]
        {
            get { return this.RetrieveHandler(id); }
        }

        /// <summary>
        /// Retrieves a handler given its identifier.
        /// </summary>
        /// <param name="id">The id to search for.</param>
        /// <returns>
        /// The <see cref="Action"/> or <code>null</code> if not found.
        /// </returns>
        public Action RetrieveHandler(string id)
        {
            if (this.registry.ContainsKey(id))
            {
                return this.registry[id];
            }

            return null;
        }

        /// <summary>
        /// Registers a handler.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="handler"></param>
        public void RegisterHandler(string id, Action handler)
        {
            if (this.registry.ContainsKey(id))
            {
                throw new ArgumentException(
                    $"A handler is already registered under id '{id}'",
                    nameof(id));
            }

            this.registry.Add(id, handler);
        }

        /// <summary>
        /// Unregistrs a handler.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// A value indicating whether a handler was found and unregistered.
        /// </returns>
        public bool UnregisterHandler(string id)
        {
            if (this.registry.ContainsKey(id))
            {
                this.registry.Remove(id);
            }

            return false;
        }
    }
}
