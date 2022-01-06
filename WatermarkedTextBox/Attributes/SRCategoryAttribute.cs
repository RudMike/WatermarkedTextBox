// <copyright file="SRCategoryAttribute.cs" company="Mike Rudnikov">
// Copyright (c) Mike Rudnikov. All rights reserved.
// </copyright>

namespace WatermarkedTextBox
{
    using System;
    using System.ComponentModel;

    /// <summary>
    /// Specifies the name of the category in which to group the property or event when displayed in a <see cref="System.Windows.Forms.PropertyGrid"/> control set to Categorized mode.
    /// Category names represents from <see cref="DefaultResourceManager"/> by a key name.
    /// </summary>
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    internal sealed class SRCategoryAttribute : CategoryAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SRCategoryAttribute"/> class using a key name of the <see cref="DefaultResourceManager"/>.
        /// </summary>
        /// <param name="keyName">The name of a key to look up the category name.</param>
        internal SRCategoryAttribute(string keyName)
            : base(keyName)
        {
        }

        /// <summary>
        /// Looks up the name of the category by a key name in <see cref="DefaultResourceManager"/>.
        /// </summary>
        /// <param name="keyName">A name of a key to look up the category name.</param>
        /// <returns>The category name from resource, or <see langword="null"/> if a key name does not exist.</returns>
        protected override string GetLocalizedString(string keyName)
        {
            return DefaultResourceManager.ResourceManager.GetString(keyName);
        }
    }
}
