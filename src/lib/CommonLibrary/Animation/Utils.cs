/// <summary>
/// Andrea Tino - 2020
/// </summary>

using System;

namespace TheSecondTrial.Animation
{
    /// <summary>
    /// Utilities.
    /// </summary>
    internal static class Utils
    {
        /// <summary>
        /// Computes a random identifier.
        /// </summary>
        /// <returns></returns>
        public static string GetId()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
