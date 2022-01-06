// <copyright file="AboutTab.cs" company="Mike Rudnikov">
// Copyright (c) Mike Rudnikov. All rights reserved.
// </copyright>

namespace WatermarkedTextBox
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms.Design;

    /// <summary>
    /// Provide a property tab that can display information about the project.
    /// </summary>
    internal class AboutTab : PropertyTab
    {
        /// <summary>
        /// Gets the name for the about tab.
        /// </summary>
        /// <returns>The name for the about tab.</returns>
        public override string TabName => StringResources.tabAbout;

        /// <summary>
        /// Gets the bitmap that is displayed for the <see cref="AboutTab"/>.
        /// </summary>
        /// <returns>The <see cref="System.Drawing.Bitmap"/> to display for the <see cref="AboutTab"/>.</returns>
        public override Bitmap Bitmap => new Bitmap(typeof(WatermarkedTextBox), "Resources.AboutTab.png");

        /// <summary>
        /// Gets a value indicating whether this <see cref="AboutTab"/> can display properties for the specified component.
        /// </summary>
        /// <param name="extendee">The object to test.</param>
        /// <returns><see langword="true"/> if the object can be extended; otherwise, <see langword="false"/>.</returns>
        public override bool CanExtend(object extendee)
        {
            return extendee is WatermarkedTextBox;
        }

        /// <summary>
        /// Gets the properties of the specified component that match the specified attributes.
        /// </summary>
        /// <param name="component">The component to retrieve properties from.</param>
        /// <param name="attributes">An array of type <see cref="Attribute"/> that indicates the attributes of the properties to retrieve.</param>
        /// <returns> A <see cref="PropertyDescriptorCollection"/> that contains the properties.</returns>
        public override PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes)
        {
            return TypeDescriptor.GetProperties(component, new Attribute[] { new AboutTabDisplayAttribute(true) });
        }
    }
}
