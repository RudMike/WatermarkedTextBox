// <copyright file="SRDescriptionAttribute.cs" company="Mike Rudnikov">
// Copyright (c) Mike Rudnikov. All rights reserved.
// </copyright>

namespace WatermarkedTextBox
{
    using System;
    using System.ComponentModel;

    /// <summary>
    /// Specifies a description for a property or event from <see cref="DefaultResourceManager"/>.
    /// </summary>
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    internal sealed class SRDescriptionAttribute : DescriptionAttribute
    {
        private readonly string description;

        /// <summary>
        /// Initializes a new instance of the <see cref="SRDescriptionAttribute"/> class using a key name of the <see cref="DefaultResourceManager"/>.
        /// </summary>
        /// <param name="resKey">The name of the key to look up the description.</param>
        internal SRDescriptionAttribute(string resKey)
        {
            this.description = DefaultResourceManager.ResourceManager.GetString(resKey);
        }

        /// <summary>
        /// Gets the description stored in this attribute.
        /// </summary>
        /// <returns>The description stored in this attribute.</returns>
        public override string Description => this.description;
    }
}
