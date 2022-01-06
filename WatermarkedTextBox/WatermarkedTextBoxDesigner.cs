// <copyright file="WatermarkedTextBoxDesigner.cs" company="Mike Rudnikov">
// Copyright (c) Mike Rudnikov. All rights reserved.
// </copyright>

namespace WatermarkedTextBox
{
    using System.Collections;
    using System.ComponentModel;
    using System.ComponentModel.Design;
    using System.Windows.Forms.Design;

    /// <summary>
    /// Extends the design mode behavior of a <see cref="WatermarkedTextBox"/>.
    /// </summary>
    internal class WatermarkedTextBoxDesigner : ControlDesigner
    {
        private DesignerActionListCollection actionLists;
        private WatermarkedTextBox watermarkedTextBox;

        /// <summary>
        /// Gets the design-time action lists supported by the component associated with the designer.
        /// </summary>
        /// <returns>The design-time action lists supported by the component associated with the designer.</returns>
        public override DesignerActionListCollection ActionLists
        {
            get
            {
                if (this.actionLists == null)
                {
                    this.actionLists = new DesignerActionListCollection
                    {
                        new WatermarkedTextBoxActionList(this.Component),
                    };
                }

                return this.actionLists;
            }
        }

        /// <summary>
        /// Gets the selection rules that indicate the movement capabilities of a component.
        /// </summary>
        /// <returns>A bitwise combination of <see cref="System.Windows.Forms.Design.SelectionRules"/> values.</returns>
        public override SelectionRules SelectionRules
        {
            get
            {
                SelectionRules rules;
                if (this.watermarkedTextBox.Multiline == false)
                {
                    rules = SelectionRules.LeftSizeable | SelectionRules.RightSizeable;
                }
                else
                {
                    rules = SelectionRules.AllSizeable;
                }

                return rules | SelectionRules.Moveable;
            }
        }

        /// <summary>
        /// Initializes the designer with the specified component.
        /// </summary>
        /// <param name="component">The <see cref="IComponent"/> to associate the designer with.
        /// This component must always be an instance of, or derive from, <see cref="System.Windows.Forms.Control"/>.</param>
        public override void Initialize(IComponent component)
        {
            base.Initialize(component);
            this.watermarkedTextBox = (WatermarkedTextBox)component;
        }

        /// <summary>
        /// Initializes a newly created component.
        /// </summary>
        /// <param name="defaultValues">A name/value dictionary of default values to apply to properties.
        /// May be <see langword="null"/> if no default values are specified.</param>
        public override void InitializeNewComponent(IDictionary defaultValues)
        {
            base.InitializeNewComponent(defaultValues);
            this.watermarkedTextBox.Text = string.Empty;
        }
    }
}