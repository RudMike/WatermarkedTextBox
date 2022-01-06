// <copyright file="DefaultResourceManager.cs" company="Mike Rudnikov">
// Copyright (c) Mike Rudnikov. All rights reserved.
// </copyright>

namespace WatermarkedTextBox
{
    using System.Reflection;
    using System.Resources;

    /// <summary>
    /// Represents a resource manager that provides convenient access to <see cref="StringResources"/> class resources.
    /// Implements the singleton pattern.
    /// </summary>
    internal sealed class DefaultResourceManager
    {
        private const string ResourcesRootName = "WatermarkedTextBox.StringResources";

        private DefaultResourceManager()
        {
        }

        /// <summary>
        /// Gets the default <see cref="System.Resources.ResourceManager"/> for the project.
        /// </summary>
        internal static ResourceManager ResourceManager => Nested.ResourceManager;

        private class Nested
        {
            internal static readonly ResourceManager ResourceManager = new ResourceManager(ResourcesRootName, Assembly.GetExecutingAssembly());

            static Nested()
            {
            }
        }
    }
}
