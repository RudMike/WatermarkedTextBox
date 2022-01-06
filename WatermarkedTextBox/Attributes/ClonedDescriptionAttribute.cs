// <copyright file="ClonedDescriptionAttribute.cs" company="Mike Rudnikov">
// Copyright (c) Mike Rudnikov. All rights reserved.
// </copyright>

namespace WatermarkedTextBox
{
    using System;
    using System.ComponentModel;

    /// <summary>
    /// Clone the <see cref="DescriptionAttribute"/> from one property or event to another.
    /// </summary>
    [AttributeUsage(AttributeTargets.Event | AttributeTargets.Property, AllowMultiple = false)]
    internal sealed class ClonedDescriptionAttribute : DescriptionAttribute
    {
        private string description;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClonedDescriptionAttribute"/> class.
        /// </summary>
        /// <param name="componentType">The <see cref="Type"/> that you want to clone from.</param>
        /// <param name="targetName">The name of the property or event from <see langword="componentType"/> that you want to clone.</param>
        /// <param name="targetType">One of the <see cref="ClonedAttributeTargets"/> values.</param>
        internal ClonedDescriptionAttribute(Type componentType, string targetName, ClonedAttributeTargets targetType)
        {
            switch (targetType)
            {
                case ClonedAttributeTargets.Property:
                    SetPropertyDescription();
                    break;
                case ClonedAttributeTargets.Event:
                    SetEventDescription();
                    break;
            }

            void SetEventDescription()
            {
                try
                {
                    this.description = TypeDescriptor.GetEvents(componentType)[targetName].Description;
                }
                catch (NullReferenceException)
                {
                }
            }

            void SetPropertyDescription()
            {
                try
                {
                    this.description = TypeDescriptor.GetProperties(componentType)[targetName].Description;
                }
                catch (NullReferenceException)
                {
                }
            }
        }

        /// <summary>
        /// Gets the description stored in this attribute.
        /// </summary>
        /// <return>The description stored in this attribute.</return>
        public override string Description
        {
            get => this.description;
        }
    }
}
