// <copyright file="NoPaddingLabel.cs" company="Mike Rudnikov">
// Copyright (c) Mike Rudnikov. All rights reserved.
// </copyright>

namespace WatermarkedTextBox
{
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// Represents a Windows label without any padding.
    /// </summary>
    internal class NoPaddingLabel : Label
    {
        private readonly TextFormatFlags noPaddingflag = TextFormatFlags.NoPadding;
        private TextFormatFlags flags;
        private ContentAlignment textAlign = ContentAlignment.TopLeft;

        /// <summary>
        /// Initializes a new instance of the <see cref="NoPaddingLabel"/> class.
        /// </summary>
        internal NoPaddingLabel()
            : base()
        {
        }

        /// <summary>
        /// Gets or sets the alignment of text in the label.
        /// </summary>
        /// <returns>One of the <see cref="ContentAlignment"/> values. The default is <see cref="ContentAlignment.TopLeft"/>.</returns>
        public override ContentAlignment TextAlign
        {
            get => this.textAlign;
            set
            {
                switch (value)
                {
                    case ContentAlignment.TopLeft:
                        this.flags = TextFormatFlags.Top | TextFormatFlags.Left;
                        break;
                    case ContentAlignment.TopCenter:
                        this.flags = TextFormatFlags.Top | TextFormatFlags.HorizontalCenter;
                        break;
                    case ContentAlignment.TopRight:
                        this.flags = TextFormatFlags.Top | TextFormatFlags.Right;
                        break;
                    case ContentAlignment.MiddleLeft:
                        this.flags = TextFormatFlags.VerticalCenter | TextFormatFlags.Left;
                        break;
                    case ContentAlignment.MiddleCenter:
                        this.flags = TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter;
                        break;
                    case ContentAlignment.MiddleRight:
                        this.flags = TextFormatFlags.VerticalCenter | TextFormatFlags.Right;
                        break;
                    case ContentAlignment.BottomLeft:
                        this.flags = TextFormatFlags.Bottom | TextFormatFlags.Left;
                        break;
                    case ContentAlignment.BottomCenter:
                        this.flags = TextFormatFlags.Bottom | TextFormatFlags.HorizontalCenter;
                        break;
                    case ContentAlignment.BottomRight:
                        this.flags = TextFormatFlags.Bottom | TextFormatFlags.Right;
                        break;
                    default:
                        this.flags = TextFormatFlags.Default;
                        break;
                }

                this.textAlign = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// Raises the <see cref="Control.Paint"/> event.
        /// </summary>
        /// <param name="e">A <see cref="PaintEventArgs"/> that contains the event data.</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            TextRenderer.DrawText(e.Graphics, this.Text, this.Font, this.ClientRectangle, this.ForeColor, Color.Transparent, this.flags | this.noPaddingflag);
        }
    }
}
