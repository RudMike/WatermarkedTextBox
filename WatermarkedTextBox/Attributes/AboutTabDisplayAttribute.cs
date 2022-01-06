// <copyright file="AboutTabDisplayAttribute.cs" company="Mike Rudnikov">
// Copyright (c) Mike Rudnikov. All rights reserved.
// </copyright>

namespace WatermarkedTextBox
{
    using System;

    /// <summary>
    /// Indicates the need to show a property in <see cref="AboutTab"/>.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    internal sealed class AboutTabDisplayAttribute : Attribute
    {
        private readonly bool value;

        /// <summary>
        /// Initializes a new instance of the <see cref="AboutTabDisplayAttribute"/> class.
        /// </summary>
        /// <param name="value"><see langword="true"/> if the property must be shown in <see cref="AboutTab"/>; otherwise, <see langword="false"/>.</param>
        internal AboutTabDisplayAttribute(bool value)
        {
            this.value = value;
        }
    }
}