// <copyright file="SRDefaultValueAttribute.cs" company="Mike Rudnikov">
// Copyright (c) Mike Rudnikov. All rights reserved.
// </copyright>

namespace WatermarkedTextBox
{
    using System;
    using System.ComponentModel;

    /// <summary>
    /// Specifies the default value for a property from <see cref="DefaultResourceManager"/>.
    /// </summary>
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    internal sealed class SRDefaultValueAttribute : DefaultValueAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SRDefaultValueAttribute"/> class using a key name of the <see cref="DefaultResourceManager"/>.
        /// </summary>
        /// <param name="resKey">The name of the key to look up the defaul value.</param>
        internal SRDefaultValueAttribute(string resKey)
            : base(resKey)
        {
        }

        /// <summary>
        /// Gets the default value of the property this attribute is bound to.
        /// </summary>
        /// <returns>An <see cref="object"/> that represents the default value of the property this attribute is bound to.</returns>
        public override object Value => DefaultResourceManager.ResourceManager.GetObject(base.Value.ToString());
    }
}
