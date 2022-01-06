// <copyright file="ClonedAttributeTargets.cs" company="Mike Rudnikov">
// Copyright (c) Mike Rudnikov. All rights reserved.
// </copyright>

namespace WatermarkedTextBox
{
    /// <summary>
    /// Specifies the elements on which it is valid to apply a cloning attribute.
    /// </summary>
    internal enum ClonedAttributeTargets
    {
        /// <summary>
        /// Attribute can be applied to an event.
        /// </summary>
        Event,

        /// <summary>
        /// Attribute can be applied to a property.
        /// </summary>
        Property,
    }
}
