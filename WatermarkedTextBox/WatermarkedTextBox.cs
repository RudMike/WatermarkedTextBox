// <copyright file="WatermarkedTextBox.cs" company="Mike Rudnikov">
// Copyright (c) Mike Rudnikov. All rights reserved.
// </copyright>

namespace WatermarkedTextBox
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Drawing.Design;
    using System.Windows.Forms;

    /// <summary>
    /// Represented a text box control with a watermark.
    /// </summary>
    [Designer(typeof(WatermarkedTextBoxDesigner))]
    [PropertyTab(typeof(AboutTab), PropertyTabScope.Component)]
    [ToolboxBitmap(typeof(WatermarkedTextBox), "Resources.Logo.ico")]
    public sealed partial class WatermarkedTextBox : UserControl
    {
        private const string WatermarkForeColorDefault = "#FF808080";
        private Font textFont = DefaultFont;
        private Font watermarkFont = WatermarkDefaultFont;
        private bool usePrimaryFont = true;

        /// <summary>
        /// Initializes a new instance of the <see cref="WatermarkedTextBox"/> class.
        /// </summary>
        public WatermarkedTextBox()
        {
            this.InitializeComponent();
            EventsSubscribe();
            SetControlTransparent();
            this.watermark.Parent = this.textBox;

            void EventsSubscribe()
            {
                this.UsePrimaryFontChanged += new EventHandler(this.WatermarkedTextBox_UsePrimaryFontChanged);
            }

            void SetControlTransparent()
            {
                this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
                base.BackColor = Color.Transparent;
            }
        }

        /// <summary>
        /// Gets the default font of the watermark.
        /// </summary>
        /// <returns>The default <see cref="Control.Font"/> of the watermark. </returns>
        public static Font WatermarkDefaultFont { get; } = new Font(DefaultFont, FontStyle.Italic);

        /// <summary>
        /// Gets or sets a value indicating whether pressing ENTER in a multiline <see cref="WatermarkedTextBox"/> control
        /// creates a new line of text in the control or activates the default button for the form.
        /// </summary>
        /// <returns><see langword="true"/> if the ENTER key creates a new line of text in a multiline version of the control;
        /// <see langword="false"/> if the ENTER key activates the default button for the form. The default is <see langword="false"/>.</returns>
        [ClonedCategory(typeof(TextBox), "AcceptsReturn", ClonedAttributeTargets.Property)]
        [ClonedDescription(typeof(TextBox), "AcceptsReturn", ClonedAttributeTargets.Property)]
        [DefaultValue(false)]
        public bool AcceptsReturn
        {
            get => this.textBox.AcceptsReturn;
            set => this.textBox.AcceptsReturn = value;
        }

        /// <summary>
        /// Gets or sets a value indicating whether pressing the TAB key in a multiline text box control types a TAB character in the control
        /// instead of moving the focus to the next control in the tab order.
        /// </summary>
        /// <returns><see langword="true"/> if the ENTER key creates a new line of text in a multiline version of the control;
        /// <see langword="false"/> if the ENTER key activates the default button for the form. The default is <see langword="false"/>.</returns>
        [ClonedCategory(typeof(TextBox), "AcceptsTab", ClonedAttributeTargets.Property)]
        [ClonedDescription(typeof(TextBox), "AcceptsTab", ClonedAttributeTargets.Property)]
        [DefaultValue(false)]
        public bool AcceptsTab
        {
            get => this.textBox.AcceptsTab;
            set
            {
                this.textBox.AcceptsTab = value;
                this.AcceptsTabChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Gets or sets the description of the control used by accessibility client applications.
        /// </summary>
        /// <returns>The description of the control used by accessibility client applications. The default is <see langword="null"/>.</returns>
        public new string AccessibleDescription
        {
            get => this.textBox.AccessibleDescription;
            set => this.textBox.AccessibleDescription = value;
        }

        /// <summary>
        /// Gets or sets the name of the control used by accessibility client applications.
        /// </summary>
        /// <returns>The name of the control used by accessibility client applications. The default is <see langword="null"/>.</returns>
        public new string AccessibleName
        {
            get => this.textBox.AccessibleName;
            set => this.textBox.AccessibleName = value;
        }

        /// <summary>
        /// Gets or sets the accessible role of the control.
        /// </summary>
        /// <returns>One of the values of <see cref="System.Windows.Forms.AccessibleRole"/>. The default is <see langword="Default"/>.</returns>
        /// <exception cref="InvalidEnumArgumentException">The value assigned is not one of the <see cref="System.Windows.Forms.AccessibleRole"/> values.</exception>
        public new AccessibleRole AccessibleRole
        {
            get => this.textBox.AccessibleRole;
            set => this.textBox.AccessibleRole = value;
        }

        /// <summary>
        /// Gets or sets a custom <see cref="System.Collections.Specialized.StringCollection"/>
        /// to use when the <see cref="AutoCompleteSource"/> property is set to <see langword="CustomSource"/>.
        /// </summary>
        /// <returns> A <see cref="System.Collections.Specialized.StringCollection"/> to use with <see cref="AutoCompleteSource"/>.</returns>
        [Browsable(true)]
        [ClonedCategory(typeof(TextBox), "AutoCompleteCustomSource", ClonedAttributeTargets.Property)]
        [ClonedDescription(typeof(TextBox), "AutoCompleteCustomSource", ClonedAttributeTargets.Property)]
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Localizable(true)]
        public AutoCompleteStringCollection AutoCompleteCustomSource
        {
            get => this.textBox.AutoCompleteCustomSource;
            set => this.textBox.AutoCompleteCustomSource = value;
        }

        /// <summary>
        /// Gets or sets an option that controls how automatic completion works for the <see cref="WatermarkedTextBox"/>.
        /// </summary>
        /// <returns>One of the values of <see cref="System.Windows.Forms.AutoCompleteMode"/>. The following are the values.
        /// <see cref="AutoCompleteMode.Append"/> appends the remainder of the most likely candidate string to the existing characters, highlighting the appended characters.
        /// <see cref="AutoCompleteMode.Suggest"/> displays the auxiliary drop-down list associated with the edit control. This drop-down is populated with one or more suggested completion strings.
        /// <see cref="AutoCompleteMode.SuggestAppend"/> appends both <see langword="Suggest"/> and <see langword="Append"/> options.
        /// <see cref="AutoCompleteMode.None"/> disables automatic completion. This is the default.</returns>
        /// <exception cref="InvalidEnumArgumentException">The specified value is not one of the values of <see cref="System.Windows.Forms.AutoCompleteMode"/>.</exception>
        [Browsable(true)]
        [ClonedCategory(typeof(TextBox), "AutoCompleteMode", ClonedAttributeTargets.Property)]
        [ClonedDescription(typeof(TextBox), "AutoCompleteMode", ClonedAttributeTargets.Property)]
        [DefaultValue(AutoCompleteMode.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteMode AutoCompleteMode
        {
            get => this.textBox.AutoCompleteMode;
            set => this.textBox.AutoCompleteMode = value;
        }

        /// <summary>
        /// Gets or sets a value specifying the source of complete strings used for automatic completion.
        /// </summary>
        /// <returns>One of the values of <see cref="System.Windows.Forms.AutoCompleteSource"/>.
        /// The options are <see langword="AllSystemSources"/>, <see langword="AllUrl"/>, <see langword="FileSystem"/>, <see langword="HistoryList"/>,
        /// <see langword="RecentlyUsedList"/>, <see langword="CustomSource"/>, and <see langword="None"/>. The default is <see langword="None"/>.</returns>
        /// <exception cref="InvalidEnumArgumentException">The specified value is not one of the values of <see cref="System.Windows.Forms.AutoCompleteSource"/>.</exception>
        [Browsable(true)]
        [ClonedCategory(typeof(TextBox), "AutoCompleteSource", ClonedAttributeTargets.Property)]
        [ClonedDescription(typeof(TextBox), "AutoCompleteSource", ClonedAttributeTargets.Property)]
        [DefaultValue(AutoCompleteSource.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteSource AutoCompleteSource
        {
            get => this.textBox.AutoCompleteSource;
            set => this.textBox.AutoCompleteSource = value;
        }

        /// <summary>
        /// Gets or sets the background color for the control.
        /// </summary>
        /// <returns> A <see cref="Color"/> that represents the background color of the control.</returns>
        [DefaultValue(typeof(Color), "Window")]
        public new Color BackColor
        {
            get => this.textBox.BackColor;
            set
            {
                this.textBox.BackColor = this.watermark.BackColor = value;
            }
        }

        /// <summary>
        /// Gets or sets the border type of the text box control.
        /// </summary>
        /// <returns>A <see cref="System.Windows.Forms.BorderStyle"/> that represents the border type of the textbox control. The default is <see langword="Fixed3D"/>.</returns>
        /// <exception cref="InvalidEnumArgumentException">A value that is not within the range of valid values for the enumeration was assigned to the property.</exception>
        [DefaultValue(typeof(BorderStyle), "Fixed3D")]
        public new BorderStyle BorderStyle
        {
            get => this.textBox.BorderStyle;
            set
            {
                this.textBox.BorderStyle = value;
                this.BorderStyleChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Gets or sets whether the <see cref="WatermarkedTextBox"/> control modifies the case of characters as they are typed.
        /// </summary>
        /// <returns>One of the <see cref="System.Windows.Forms.CharacterCasing"/> enumeration values that specifies whether the <see cref="WatermarkedTextBox"/> control modifies
        /// the case of characters. The default is <see langword="CharacterCasing.Normal"/>.</returns>
        /// <exception cref="InvalidEnumArgumentException">A value that is not within the range of valid values for the enumeration was assigned to the property.</exception>
        [ClonedCategory(typeof(TextBox), "CharacterCasing", ClonedAttributeTargets.Property)]
        [ClonedDescription(typeof(TextBox), "CharacterCasing", ClonedAttributeTargets.Property)]
        [DefaultValue(CharacterCasing.Normal)]
        public CharacterCasing CharacterCasing
        {
            get => this.textBox.CharacterCasing;
            set => this.textBox.CharacterCasing = value;
        }

        /// <summary>
        /// Gets or sets the cursor that is displayed when the mouse pointer is over the control.
        /// </summary>
        /// <returns>A <see cref="System.Windows.Forms.Cursor"/> that represents the cursor to display when the mouse pointer is over the control.</returns>
        [DefaultValue(typeof(Cursor), "IBeam")]
        public override Cursor Cursor
        {
            get => this.textBox.Cursor;
            set => this.textBox.Cursor = this.watermark.Cursor = value;
        }

        /// <summary>
        /// Gets or sets the font of the text displayed by the control.
        /// </summary>
        /// <returns>The <see cref="System.Drawing.Font"/> to apply to the text displayed by the control. The default is the value of the <see cref="Control.DefaultFont"/> property.</returns>
        public override Font Font
        {
            get => this.textFont ?? DefaultFont;
            set
            {
                this.textFont = this.textBox.Font = value;
                this.FontChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Gets or sets the foreground color of the control.
        /// </summary>
        /// <returns>A <see cref="Color"/> that represents the control's foreground color.</returns>
        [DefaultValue(typeof(Color), "WindowText")]
        public override Color ForeColor
        {
            get => this.textBox.ForeColor;
            set => this.textBox.ForeColor = value;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the selected text in the text box control remains highlighted when the control loses focus.
        /// </summary>
        /// <returns><see langword="true"/> if the selected text does not appear highlighted when the text box control loses focus; <see langword="false"/>,
        /// if the selected text remains highlighted when the text box control loses focus. The default is <see langword="true"/>.</returns>
        [ClonedCategory(typeof(TextBox), "HideSelection", ClonedAttributeTargets.Property)]
        [ClonedDescription(typeof(TextBox), "HideSelection", ClonedAttributeTargets.Property)]
        [DefaultValue(true)]
        public bool HideSelection
        {
            get => this.textBox.HideSelection;
            set
            {
                this.textBox.HideSelection = value;
                this.HideSelectionChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Gets or sets the lines of text in a text box control.
        /// </summary>
        /// <returns>An array of strings that contains the text in a text box control.</returns>
        [ClonedCategory(typeof(TextBox), "Lines", ClonedAttributeTargets.Property)]
        [ClonedDescription(typeof(TextBox), "Lines", ClonedAttributeTargets.Property)]
        [Localizable(true)]
        [MergableProperty(false)]
        public string[] Lines
        {
            get => this.textBox.Lines;
            set => this.textBox.Lines = value;
        }

        /// <summary>
        /// Gets or sets the maximum number of characters the user can type or paste into the text box control.
        /// </summary>
        /// <returns>The number of characters that can be entered into the control. The default is 32767.</returns>
        /// <exception cref="ArgumentOutOfRangeException">The value assigned to the property is less than 0.</exception>
        [ClonedCategory(typeof(TextBox), "MaxLength", ClonedAttributeTargets.Property)]
        [ClonedDescription(typeof(TextBox), "MaxLength", ClonedAttributeTargets.Property)]
        [DefaultValue(32767)]
        [Localizable(true)]
        public int MaxLength
        {
            get => this.textBox.MaxLength;
            set => this.textBox.MaxLength = value;
        }

        /// <summary>
        /// Gets or sets a value indicating whether this is a multiline <see cref="WatermarkedTextBox"/> control.
        /// </summary>
        /// <returns><see langword="true"/> if the control is a multiline <see cref="WatermarkedTextBox"/> control;
        /// otherwise, <see langword="false"/>. The default is <see langword="false"/>.</returns>
        [ClonedCategory(typeof(TextBox), "Multiline", ClonedAttributeTargets.Property)]
        [ClonedDescription(typeof(TextBox), "Multiline", ClonedAttributeTargets.Property)]
        [DefaultValue(false)]
        [Localizable(true)]
        [RefreshProperties(RefreshProperties.All)]
        public bool Multiline
        {
            get => this.textBox.Multiline;
            set
            {
                this.textBox.Multiline = value;
                this.MultilineChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Gets or sets the character used to mask characters of a password in a single-line <see cref="WatermarkedTextBox"/> control.
        /// </summary>
        /// <returns>The character used to mask characters entered in a single-line <see cref="WatermarkedTextBox"/>
        /// control. Set the value of this property to 0 (character value) if you do not
        /// want the control to mask characters as they are typed. Equals 0 (character value) by default.</returns>
        [ClonedCategory(typeof(TextBox), "PasswordChar", ClonedAttributeTargets.Property)]
        [ClonedDescription(typeof(TextBox), "PasswordChar", ClonedAttributeTargets.Property)]
        [DefaultValue('\0')]
        [Localizable(true)]
        [RefreshProperties(RefreshProperties.Repaint)]
        public char PasswordChar
        {
            get => this.textBox.PasswordChar;
            set => this.textBox.PasswordChar = value;
        }

        /// <summary>
        /// Gets or sets a value indicating whether text in the text box is read-only.
        /// </summary>
        /// <returns><see langword="true"/> if the text box is read-only; otherwise, <see langword="false"/>. The default is <see langword="false"/>.</returns>
        [ClonedCategory(typeof(TextBox), "ReadOnly", ClonedAttributeTargets.Property)]
        [ClonedDescription(typeof(TextBox), "ReadOnly", ClonedAttributeTargets.Property)]
        [DefaultValue(false)]
        [RefreshProperties(RefreshProperties.Repaint)]
        public bool ReadOnly
        {
            get => this.textBox.ReadOnly;
            set
            {
                this.textBox.ReadOnly = value;
                this.ReadOnlyChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Gets or sets which scroll bars should appear in a multiline <see cref="WatermarkedTextBox"/> control.
        /// </summary>
        /// <returns>One of the <see cref="System.Windows.Forms.ScrollBars"/> enumeration values
        /// that indicates whether a multiline <see cref="WatermarkedTextBox"/> control appears
        /// with no scroll bars, a horizontal scroll bar, a vertical scroll bar, or both. The default is <see langword="ScrollBars.None"/>.</returns>
        /// <exception cref="InvalidEnumArgumentException">A value that is not within the range of valid values for the enumeration was assigned to the property.</exception>
        [ClonedCategory(typeof(TextBox), "ScrollBars", ClonedAttributeTargets.Property)]
        [ClonedDescription(typeof(TextBox), "ScrollBars", ClonedAttributeTargets.Property)]
        [DefaultValue(ScrollBars.None)]
        [Localizable(true)]
        public ScrollBars ScrollBars
        {
            get => this.textBox.ScrollBars;
            set => this.textBox.ScrollBars = value;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the defined shortcuts are enabled.
        /// </summary>
        /// <returns><see langword="true"/> to enable the shortcuts; otherwise, <see langword="false"/>.</returns>
        [ClonedCategory(typeof(TextBox), "ShortcutsEnabled", ClonedAttributeTargets.Property)]
        [ClonedDescription(typeof(TextBox), "ShortcutsEnabled", ClonedAttributeTargets.Property)]
        [DefaultValue(true)]
        public bool ShortcutsEnabled
        {
            get => this.textBox.ShortcutsEnabled;
            set => this.textBox.ShortcutsEnabled = value;
        }

        /// <summary>
        /// Gets or sets the height and width of the control.
        /// </summary>
        /// <returns>The <see cref="System.Drawing.Size"/> that represents the height and width of the control in pixels.</returns>
        [DefaultValue(typeof(Size), "100,20")]
        public new Size Size
        {
            get => base.Size;
            set
            {
                base.Size = GetNewSize();
                SetWatermarkSize();

                Size GetNewSize()
                {
                    Size newSize = new Size
                    {
                        Height = this.Multiline ? this.textBox.Height = value.Height : this.textBox.Height,
                        Width = this.textBox.Width = value.Width,
                    };
                    return newSize;
                }

                void SetWatermarkSize()
                {
                    this.watermark.Width = this.textBox.ClientSize.Width - (this.watermark.Location.X * 2);
                    this.watermark.Height = this.textBox.ClientSize.Height - (this.watermark.Location.Y * 2);
                }
            }
        }

        /// <summary>
        /// Gets or sets the text associated with this control.
        /// </summary>
        /// <returns>The text associated with this control.</returns>
        [Bindable(true)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Localizable(true)]
        public override string Text
        {
            get => this.textBox.Text;
            set
            {
                this.textBox.Text = value;
                this.TextChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Gets or sets how text is aligned in a <see cref="WatermarkedTextBox"/> control.
        /// </summary>
        /// <returns>One of the <see cref="HorizontalAlignment"/> enumeration values that specifies how text is aligned in the control.
        /// The default is <see langword="HorizontalAlignment.Left"/>.</returns>
        /// <exception cref="InvalidEnumArgumentException">A value that is not within the range of valid values for the enumeration was assigned to the property.</exception>
        [ClonedCategory(typeof(TextBox), "TextAlign", ClonedAttributeTargets.Property)]
        [ClonedDescription(typeof(TextBox), "TextAlign", ClonedAttributeTargets.Property)]
        [DefaultValue(HorizontalAlignment.Left)]
        [Localizable(true)]
        public HorizontalAlignment TextAlign
        {
            get => this.textBox.TextAlign;
            set
            {
                this.textBox.TextAlign = value;
                this.TextAlignChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether to use <see cref="FontFamily"/> and <see cref="System.Drawing.Size"/> properties of the primary font.
        /// </summary>
        /// <returns><see langword="true"/> to use <see cref="System.Drawing.FontFamily"/> and <see cref="System.Drawing.Size"/>
        /// properties of the <see cref="Font"/>; otherwise, <see langword="false"/>. The default is <see langword="true"/>.</returns>
        [SRCategory("catWatermark")]
        [SRDescription("descUsePrimaryFont")]
        [DefaultValue(true)]
        public bool UsePrimaryFont
        {
            get => this.usePrimaryFont;
            set
            {
                this.usePrimaryFont = value;
                this.UsePrimaryFontChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the text in the <see cref="WatermarkedTextBox"/> control should appear as the default password character.
        /// </summary>
        /// <returns><see langword="true"/> if the text in the <see cref="WatermarkedTextBox"/> control should appear as the default password character; otherwise, <see langword="false"/>.</returns>
        [ClonedCategory(typeof(TextBox), "UseSystemPasswordChar", ClonedAttributeTargets.Property)]
        [ClonedDescription(typeof(TextBox), "UseSystemPasswordChar", ClonedAttributeTargets.Property)]
        [DefaultValue(false)]
        [RefreshProperties(RefreshProperties.Repaint)]
        public bool UseSystemPasswordChar
        {
            get => this.textBox.UseSystemPasswordChar;
            set => this.textBox.UseSystemPasswordChar = value;
        }

        /// <summary>
        /// Gets or sets the font of the watermark.
        /// </summary>
        /// <returns>The <see cref="System.Drawing.Font"/> to apply to the watermark. The default is the value of the <see cref="WatermarkDefaultFont"/> property.</returns>
        [SRCategory("catWatermark")]
        [SRDescription("descWatermarkFont")]
        public Font WatermarkFont
        {
            get => this.watermarkFont ?? WatermarkDefaultFont;
            set
            {
                if (this.UsePrimaryFont)
                {
                    this.watermark.Font = this.watermarkFont = new Font(this.Font.FontFamily, this.Font.Size, value.Style);
                }
                else
                {
                    if (value.Size > this.Font.Size)
                    {
                        this.watermark.Font = this.watermarkFont = new Font(value.FontFamily, this.Font.Size, value.Style);
                    }
                    else
                    {
                        this.watermark.Font = this.watermarkFont = value;
                    }
                }

                this.WatermarkFontChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Gets or sets the foreground color of the watermark.
        /// </summary>
        /// <returns>A <see cref="Color"/> that represents the watermark's foreground color.</returns>
        [SRCategory("catWatermark")]
        [SRDescription("descWatermarkForeColor")]
        [DefaultValue(typeof(Color), WatermarkForeColorDefault)]
        public Color WatermarkForeColor
        {
            get => this.watermark.ForeColor;
            set
            {
                this.watermark.ForeColor = value;
                this.WatermarkForeColorChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Gets or sets the text of the watermark. The value is ignore if this control has own text.
        /// </summary>
        /// <returns>The text associated with this control.</returns>
        [SRCategory("catWatermark")]
        [SRDescription("descWatermarkText")]
        [SRDefaultValue("watermarkDefaultText")]
        [Localizable(true)]
        public string WatermarkText
        {
            get => this.watermark.Text;
            set
            {
                this.watermark.Text = value;
                this.WatermarkTextChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Gets or sets the alignment of the watermark.
        /// </summary>
        /// <returns>One of the <see cref="ContentAlignment"/> values. The default is <see cref="ContentAlignment.TopLeft"/>.</returns>
        /// <exception cref="InvalidEnumArgumentException">The value assigned is not one of the <see cref="ContentAlignment"/> values.</exception>
        [SRCategory("catWatermark")]
        [SRDescription("descWatermarkTextAlign")]
        [DefaultValue(ContentAlignment.TopLeft)]
        public ContentAlignment WatermarkTextAlign
        {
            get => this.watermark.TextAlign;
            set
            {
                this.watermark.TextAlign = value;
                this.WatermarkTextAlignChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether a multiline text box control automatically wraps words to the beginning of the next line when necessary.
        /// </summary>
        /// <returns> <see langword="true"/> if the multiline text box control wraps words; <see langword="false"/>
        /// if the text box control automatically scrolls horizontally when the user types past the right edge of the control. The default is <see langword="true"/>.</returns>
        [ClonedCategory(typeof(TextBox), "WordWrap", ClonedAttributeTargets.Property)]
        [ClonedDescription(typeof(TextBox), "WordWrap", ClonedAttributeTargets.Property)]
        [DefaultValue(true)]
        [Localizable(true)]
        public bool WordWrap
        {
            get => this.textBox.WordWrap;
            set => this.textBox.WordWrap = value;
        }

        /// <summary>
        /// Gets a value indicating whether the user can undo the previous operation in a text box control.
        /// </summary>
        /// <returns><see langword="true"/> if the user can undo the previous operation performed in a text box control; otherwise, <see langword="false"/>.</returns>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool CanUndo => this.textBox.CanUndo;

        /// <summary>
        /// Gets or sets the <see cref="System.Windows.Forms.ContextMenuStrip"/> associated with this control.
        /// </summary>
        /// <returns>The <see cref="System.Windows.Forms.ContextMenuStrip"/> for this control, or <see langword="null"/>
        /// if there is no <see cref="System.Windows.Forms.ContextMenuStrip"/>. The default is <see langword="null"/>.</returns>
        [DefaultValue(null)]
        public override ContextMenuStrip ContextMenuStrip
        {
            get => base.ContextMenuStrip;
            set => base.ContextMenuStrip = this.textBox.ContextMenuStrip = value;
        }

        /// <summary>
        /// Gets or sets a value indicating whether that the text box control has been modified by the user since the control was created or its contents were last set.
        /// </summary>
        /// <returns><see langword="true"/> if the control's contents have been modified; otherwise, <see langword="false"/>. The default is <see langword="false"/>.</returns>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool Modified
        {
            get => this.textBox.Modified;
            set
            {
                this.textBox.Modified = value;
                this.ModifiedChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Gets the preferred height for a text box.
        /// </summary>
        /// <returns>The preferred height of a text box.</returns>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public int PreferredHeight => this.textBox.PreferredHeight;

        /// <summary>
        /// Gets or sets a value indicating the currently selected text in the control.
        /// </summary>
        /// <returns>A string that represents the currently selected text in the text box.</returns>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string SelectedText
        {
            get => this.textBox.SelectedText;
            set => this.textBox.SelectedText = value;
        }

        /// <summary>
        /// Gets or sets the number of characters selected in the text box.
        /// </summary>
        /// <returns>The number of characters selected in the text box.</returns>
        /// <exception cref="ArgumentOutOfRangeException">The assigned value is less than zero.</exception>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectionLength
        {
            get => this.textBox.SelectionLength;
            set => this.textBox.SelectionLength = value;
        }

        /// <summary>
        /// Gets or sets the starting point of text selected in the text box.
        /// </summary>
        /// <returns>The starting position of text selected in the text box.</returns>
        /// <exception cref="ArgumentOutOfRangeException">The assigned value is less than zero.</exception>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectionStart
        {
            get => this.textBox.SelectionStart;
            set => this.textBox.SelectionStart = value;
        }

        /// <summary>
        /// Gets the length of text in the control.
        /// </summary>
        /// <returns>The number of characters contained in the text of the control.</returns>
        [Browsable(false)]
        public int TextLength => this.textBox.TextLength;

        /// <summary>
        /// Raises the <see cref="Control.BackColorChanged"/> event when the <see cref="Control.BackColor"/> property value of the control's container changes.
        /// </summary>
        /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        protected override void OnParentBackColorChanged(EventArgs e)
        {
            base.OnParentBackColorChanged(e);
            this.Refresh();
        }

        /// <summary>
        /// Raises <see cref="Control.BackgroundImageChanged"/> event when the <see cref="Control.BackgroundImage"/> property value of the control's container changes.
        /// </summary>
        /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
        protected override void OnParentBackgroundImageChanged(EventArgs e)
        {
            base.OnParentBackgroundImageChanged(e);
            this.Refresh();
        }

        /// <summary>
        /// Raises the <see cref="Control.SizeChanged"/> event.
        /// </summary>
        /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.Size = base.Size;
        }

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable SA1300 // Element should begin with upper-case letter
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            TryWatermarkVisible();

            void TryWatermarkVisible()
            {
                this.watermark.Visible = this.textBox.Text == string.Empty;
            }
        }

        private void watermark_Click(object sender, EventArgs e)
        {
            this.textBox.Focus();
        }

        private void textBox_SizeChanged(object sender, EventArgs e)
        {
            this.Size = this.textBox.Size;
        }
#pragma warning restore SA1300 // Element should begin with upper-case letter
#pragma warning restore IDE1006 // Naming Styles

        private void WatermarkedTextBox_FontChanged(object sender, EventArgs e)
        {
            this.TryApplyPrimaryFontToWatermark();
        }

        private void WatermarkedTextBox_UsePrimaryFontChanged(object sender, EventArgs e)
        {
            this.TryApplyPrimaryFontToWatermark();
        }

        private void TryApplyPrimaryFontToWatermark()
        {
            if (this.UsePrimaryFont)
            {
                this.WatermarkFont = new Font(this.Font.FontFamily, this.Font.Size, this.WatermarkFont.Style);
            }
        }

        private bool ShouldSerializeFont()
        {
            return !this.Font.Equals(DefaultFont);
        }

        private bool ShouldSerializeWatermarkFont()
        {
            return !this.WatermarkFont.Equals(WatermarkDefaultFont);
        }

        private void ResetWatermarkFont()
        {
            this.WatermarkFont = WatermarkDefaultFont;
        }
    }
}
