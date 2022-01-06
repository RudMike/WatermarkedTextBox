// <copyright file="WatermarkedTextBoxActionList.cs" company="Mike Rudnikov">
// Copyright (c) Mike Rudnikov. All rights reserved.
// </copyright>

namespace WatermarkedTextBox
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.Design;

    /// <summary>
    /// Defines a list of items used to create a smart tag panel for <see cref="WatermarkedTextBox"/> class.
    /// </summary>
    internal class WatermarkedTextBoxActionList : DesignerActionList
    {
        private readonly WatermarkedTextBox watermarkedTextBox;
        private readonly string multilineName = "Multiline";

        /// <summary>
        /// Initializes a new instance of the <see cref="WatermarkedTextBoxActionList"/> class. that define a list of items used to create a smart tag panel.
        /// </summary>
        /// <param name="component">A component related to the <see cref="WatermarkedTextBoxActionList"/>.</param>
        internal WatermarkedTextBoxActionList(IComponent component)
            : base(component)
        {
            this.watermarkedTextBox = component as WatermarkedTextBox;
        }

        /// <summary>
        /// Gets or sets a value indicating whether this is a multiline <see cref="WatermarkedTextBox"/> control.
        /// </summary>
        /// <returns><see langword="true"/> if the control is a multiline <see cref="WatermarkedTextBox"/> control;
        /// otherwise, <see langword="false"/>. The default is <see langword="false"/>.</returns>
        public bool Multiline
        {
            get => this.watermarkedTextBox.Multiline;
            set
            {
                this.GetPropertyByName(this.multilineName).SetValue(this.watermarkedTextBox, value);
            }
        }

        /// <summary>
        ///  Returns the collection of <see cref="DesignerActionItem"/> objects contained in the list.
        /// </summary>
        /// <returns>A <see cref="DesignerActionItem"/> array that contains the items in this list.</returns>
        public override DesignerActionItemCollection GetSortedActionItems()
        {
            var items = new DesignerActionItemCollection();
            _ = items.Add(new DesignerActionPropertyItem(
                this.multilineName,
                this.multilineName,
                null,
                DefaultResourceManager.ResourceManager.GetString("descMultilineActionList")));
            return items;
        }

        /// <summary>
        /// Get the descriptor of a property by the property name.
        /// </summary>
        /// <param name="propertyName">Search property.</param>
        /// <returns>Returns property descriptor.</returns>
        /// <exception cref="ArgumentNullException">A property with this name is not exist.</exception>
        private PropertyDescriptor GetPropertyByName(string propertyName)
        {
            PropertyDescriptor propertyDescriptor = TypeDescriptor.GetProperties(this.watermarkedTextBox)[propertyName];

            return propertyName != null
                ? propertyDescriptor
                : throw new ArgumentNullException(StringResources.propertyNullExceptionMessage, propertyName);
        }
    }
}
