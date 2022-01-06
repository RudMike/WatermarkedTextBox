// <copyright file="WatermarkedTextBox.Events.cs" company="Mike Rudnikov">
// Copyright (c) Mike Rudnikov. All rights reserved.
// </copyright>

namespace WatermarkedTextBox
{
    using System;
    using System.ComponentModel;
    using System.Windows.Forms;

    /// <content>
    /// Contains events of the <see cref="WatermarkedTextBox"/> class.
    /// </content>
    public partial class WatermarkedTextBox
    {
        /// <summary>
        /// Occurs when the value of the <see cref="AcceptsTab"/> property has changed.
        /// </summary>
        [ClonedDescription(typeof(TextBox), "AcceptsTabChanged", ClonedAttributeTargets.Event)]
        [ClonedCategory(typeof(TextBox), "AcceptsTabChanged", ClonedAttributeTargets.Event)]
        public event EventHandler AcceptsTabChanged;

        /// <summary>
        /// Occurs when the value of the <see cref="BorderStyle"/> property has changed.
        /// </summary>
        [ClonedDescription(typeof(TextBox), "BorderStyleChanged", ClonedAttributeTargets.Event)]
        [ClonedCategory(typeof(TextBox), "BorderStyleChanged", ClonedAttributeTargets.Event)]
        public event EventHandler BorderStyleChanged;

        /// <summary>
        /// Occurs when the <see cref="Font"/> property value changes.
        /// </summary>
        public new event EventHandler FontChanged;

        /// <summary>
        /// Occurs when the value of the <see cref="HideSelection"/> property has changed.
        /// </summary>
        [ClonedDescription(typeof(TextBox), "HideSelectionChanged", ClonedAttributeTargets.Event)]
        [ClonedCategory(typeof(TextBox), "HideSelectionChanged", ClonedAttributeTargets.Event)]
        public event EventHandler HideSelectionChanged;

        /// <summary>
        /// Occurs when the value of the <see cref="Modified"/> property has changed.
        /// </summary>
        [ClonedDescription(typeof(TextBox), "ModifiedChanged", ClonedAttributeTargets.Event)]
        [ClonedCategory(typeof(TextBox), "ModifiedChanged", ClonedAttributeTargets.Event)]
        public event EventHandler ModifiedChanged;

        /// <summary>
        /// Occurs when the value of the <see cref="Multiline"/> property has changed.
        /// </summary>
        [ClonedDescription(typeof(TextBox), "MultilineChanged", ClonedAttributeTargets.Event)]
        [ClonedCategory(typeof(TextBox), "MultilineChanged", ClonedAttributeTargets.Event)]
        public event EventHandler MultilineChanged;

        /// <summary>
        /// Occurs when the value of the <see cref="ReadOnly"/> property has changed.
        /// </summary>
        [ClonedDescription(typeof(TextBox), "ReadOnlyChanged", ClonedAttributeTargets.Event)]
        [ClonedCategory(typeof(TextBox), "ReadOnlyChanged", ClonedAttributeTargets.Event)]
        public event EventHandler ReadOnlyChanged;

        /// <summary>
        /// Occurs when the value of the <see cref="TextAlign"/> property has changed.
        /// </summary>
        [ClonedDescription(typeof(TextBox), "TextAlignChanged", ClonedAttributeTargets.Event)]
        [ClonedCategory(typeof(TextBox), "TextAlignChanged", ClonedAttributeTargets.Event)]
        public event EventHandler TextAlignChanged;

        /// <summary>
        /// Occurs when the <see cref="Text"/> property value changes.
        /// </summary>
        [Browsable(true)]
        public new event EventHandler TextChanged;

        /// <summary>
        /// Occurs when the <see cref="UsePrimaryFont"/> property has changed.
        /// </summary>
        [SRCategory("catWatermark")]
        [SRDescription("descUsePrimaryFontChanged")]
        public event EventHandler UsePrimaryFontChanged;

        /// <summary>
        /// Occurs when the <see cref="WatermarkFont"/> property value changes.
        /// </summary>
        [SRCategory("catWatermark")]
        [SRDescription("descWatermarkFontChanged")]
        public event EventHandler WatermarkFontChanged;

        /// <summary>
        /// Occurs when the <see cref="WatermarkForeColor"/> property value changes.
        /// </summary>
        [SRCategory("catWatermark")]
        [SRDescription("descWatermarkForeColorChanged")]
        public event EventHandler WatermarkForeColorChanged;

        /// <summary>
        /// Occurs when the <see cref="WatermarkText"/> property value changes.
        /// </summary>
        [SRCategory("catWatermark")]
        [SRDescription("descWatermarkTextChanged")]
        public event EventHandler WatermarkTextChanged;

        /// <summary>
        /// Occurs when the value of the <see cref="WatermarkTextAlign"/> property has changed.
        /// </summary>
        [SRCategory("catWatermark")]
        [SRDescription("descWatermarkTextAlignChanged")]
        public event EventHandler WatermarkTextAlignChanged;
    }
}
