// <copyright file="WatermarkedTextBox.BaseHiddenMembers.cs" company="Mike Rudnikov">
// Copyright (c) Mike Rudnikov. All rights reserved.
// </copyright>

namespace WatermarkedTextBox
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    /// <content>
    /// Contains all hidden members of the <see cref="WatermarkedTextBox"/> class.
    /// </content>
    public partial class WatermarkedTextBox
    {
#pragma warning disable CS0067 // The event  is never used
        /// <summary>
        /// This event is not relevant for this class.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new event EventHandler AutoSizeChanged;

        /// <summary>
        /// This event is not relevant for this class.
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new event EventHandler AutoValidateChanged;

        /// <summary>
        /// This event is not relevant for this class.
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new event EventHandler BackgroundImageChanged;

        /// <summary>
        /// This event is not relevant for this class.
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new event EventHandler BackgroundImageLayoutChanged;

        /// <summary>
        /// This event is not relevant for this class.
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new event EventHandler Load;

        /// <summary>
        /// This event is not relevant for this class.
        /// </summary>
        [Bindable(BindableSupport.No)]
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new event EventHandler PaddingChanged;

        /// <summary>
        /// This event is not relevant for this class.
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new event PaintEventHandler Paint;

        /// <summary>
        /// This event is not relevant for this class.
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new event ScrollEventHandler Scroll;
#pragma warning restore CS0067 // The event  is never used

#pragma warning disable SA1623 // Property summary documentation should match accessors
        /// <summary>
        /// This property is not relevant for this class.
        /// </summary>
        [Bindable(false)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new Control ActiveControl
        {
            get => base.ActiveControl;
            set => base.ActiveControl = value;
        }

        /// <summary>
        /// This property is not relevant for this class.
        /// </summary>
        [Bindable(false)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new SizeF AutoScaleDimensions
        {
            get => base.AutoScaleDimensions;
            set => base.AutoScaleDimensions = value;
        }

        /// <summary>
        /// This property is not relevant for this class.
        /// </summary>
        [Bindable(false)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new AutoScaleMode AutoScaleMode
        {
            get => base.AutoScaleMode;
            set => base.AutoScaleMode = value;
        }

        /// <summary>
        /// This property is not relevant for this class.
        /// </summary>
        [Bindable(false)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool AutoScroll
        {
            get => base.AutoScroll;
            set => base.AutoScroll = value;
        }

        /// <summary>
        /// This property is not relevant for this class.
        /// </summary>
        [Bindable(false)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new Size AutoScrollMargin
        {
            get => base.AutoScrollMargin;
            set => base.AutoScrollMargin = value;
        }

        /// <summary>
        /// This property is not relevant for this class.
        /// </summary>
        [Bindable(false)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new Size AutoScrollMinSize
        {
            get => base.AutoScrollMinSize;
            set => base.AutoScrollMinSize = value;
        }

        /// <summary>
        /// This property is not relevant for this class.
        /// </summary>
        [Bindable(false)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new Point AutoScrollPosition
        {
            get => base.AutoScrollPosition;
            set => base.AutoScrollPosition = value;
        }

        /// <summary>
        /// This property is not relevant for this class.
        /// </summary>
        [Bindable(false)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool AutoSize
        {
            get => base.AutoSize;
            set => base.AutoSize = value;
        }

        /// <summary>
        /// This property is not relevant for this class.
        /// </summary>
        [Bindable(false)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new AutoSizeMode AutoSizeMode
        {
            get => base.AutoSizeMode;
            set => base.AutoSizeMode = value;
        }

        /// <summary>
        /// This property is not relevant for this class.
        /// </summary>
        [Bindable(false)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override AutoValidate AutoValidate
        {
            get => base.AutoValidate;
            set => base.AutoValidate = value;
        }

        /// <summary>
        /// This property is not relevant for this class.
        /// </summary>
        [Bindable(false)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override Image BackgroundImage
        {
            get => base.BackgroundImage;
            set => base.BackgroundImage = value;
        }

        /// <summary>
        /// This property is not relevant for this class.
        /// </summary>
        [Bindable(false)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override ImageLayout BackgroundImageLayout
        {
            get => base.BackgroundImageLayout;
            set => base.BackgroundImageLayout = value;
        }

        /// <summary>
        /// This property is not relevant for this class.
        /// </summary>
        [Bindable(false)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new SizeF CurrentAutoScaleDimensions => base.CurrentAutoScaleDimensions;

        /// <summary>
        /// This property is not relevant for this class.
        /// </summary>
        [Bindable(false)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new HScrollProperties HorizontalScroll => base.HorizontalScroll;

        /// <summary>
        /// This property is not relevant for this class.
        /// </summary>
        [Bindable(false)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new Padding Padding
        {
            get => base.Padding;
            set => base.Padding = value;
        }

        /// <summary>
        /// This property is not relevant for this class.
        /// </summary>
        [Bindable(false)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new Form ParentForm => base.ParentForm;

        /// <summary>
        /// This property is not relevant for this class.
        /// </summary>
        [Bindable(false)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new VScrollProperties VerticalScroll => base.VerticalScroll;
#pragma warning restore SA1623 // Property summary documentation should match accessors

        /// <summary>
        /// This method is not relevant for this class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new void PerformAutoScale()
        {
        }

        /// <summary>
        /// This method is not relevant for this class.
        /// </summary>
        /// <param name="activeControl">The child control to scroll into view.</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new void ScrollControlIntoView(Control activeControl)
        {
        }

        /// <summary>
        /// This method is not relevant for this class.
        /// </summary>
        /// <param name="x">The <see cref="Size.Width"/> value.</param>
        /// <param name="y">The <see cref="Size.Height"/> value.</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new void SetAutoScrollMargin(int x, int y)
        {
        }

        /// <summary>
        /// This method is not relevant for this class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new void Validate()
        {
        }

        /// <summary>
        /// This method is not relevant for this class.
        /// </summary>
        /// <param name="checkAutoValidate">If true, the value of the <see cref="ContainerControl.AutoValidate"/> property is used
        /// to determine if validation should be performed; if false, validation is unconditionally performed.</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new void Validate(bool checkAutoValidate)
        {
        }

        /// <summary>
        /// This method is not relevant for this class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new void ValidateChildren()
        {
        }

        /// <summary>
        /// This method is not relevant for this class.
        /// </summary>
        /// <param name="validationConstraints">Places restrictions on which controls have their <see cref="Control.Validating"/> event raised.</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new void ValidateChildren(ValidationConstraints validationConstraints)
        {
        }
    }
}
