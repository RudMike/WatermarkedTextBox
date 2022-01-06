// <copyright file="ClonedCategoryAttribute.cs" company="Mike Rudnikov">
// Copyright (c) Mike Rudnikov. All rights reserved.
// </copyright>

namespace WatermarkedTextBox
{
    using System;
    using System.ComponentModel;

    /// <summary>
    /// Clone the <see cref="CategoryAttribute"/> from one property or event to another.
    /// </summary>
    [AttributeUsage(AttributeTargets.Event | AttributeTargets.Property, AllowMultiple = false)]
    internal sealed class ClonedCategoryAttribute : CategoryAttribute
    {
        private string category;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClonedCategoryAttribute"/> class.
        /// </summary>
        /// <param name="componentType">The <see cref="Type"/> that you want to clone from.</param>
        /// <param name="targetName">The name of the property or event from <see langword="componentType"/> that you want to clone.</param>
        /// <param name="targetType">One of the <see cref="ClonedAttributeTargets"/> values.</param>
        internal ClonedCategoryAttribute(Type componentType, string targetName, ClonedAttributeTargets targetType)
        {
            switch (targetType)
            {
                case ClonedAttributeTargets.Property:
                    SetPropertyCategory();
                    break;

                case ClonedAttributeTargets.Event:
                    SetEventCategory();
                    break;
            }

            void SetEventCategory()
            {
                try
                {
                    this.category = TypeDescriptor.GetEvents(componentType)[targetName].Category;
                }
                catch (NullReferenceException)
                {
                }
            }

            void SetPropertyCategory()
            {
                try
                {
                    this.category = TypeDescriptor.GetProperties(componentType)[targetName].Category;
                }
                catch (NullReferenceException)
                {
                }
            }
        }

        /// <summary>
        /// Looks up the category name.
        /// </summary>
        /// <param name="value">The identifer for the category to look up.</param>
        /// <returns>The cloned name of the category, or null if a name does not exist.</returns>
        protected override string GetLocalizedString(string value)
        {
            return this.category;
        }
    }
}
