// <copyright file="WatermarkedTextBox.Methods.cs" company="Mike Rudnikov">
// Copyright (c) Mike Rudnikov. All rights reserved.
// </copyright>

namespace WatermarkedTextBox
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    /// <content>
    /// Contains all public methods of the <see cref="WatermarkedTextBox"/> class.
    /// </content>
    public partial class WatermarkedTextBox
    {
        /// <summary>
        /// Appends text to the current text of a text box.
        /// </summary>
        /// <param name="text">The text to append to the current contents of the text box.</param>
        public void AppendText(string text) => this.textBox.AppendText(text);

        /// <summary>
        /// Executes the specified delegate asynchronously on the thread that the control's underlying handle was created on.
        /// </summary>
        /// <param name="method">A delegate to a method that takes no parameters.</param>
        /// <returns>An <see cref="IAsyncResult"/> that represents the result of the <see cref="Control.BeginInvoke(Delegate)"/> operation.</returns>
        /// <exception cref="InvalidOperationException">No appropriate window handle can be found.</exception>
        public new IAsyncResult BeginInvoke(Delegate method)
        {
            return base.BeginInvoke(method);
        }

        /// <summary>
        /// Executes the specified delegate asynchronously with the specified arguments, on the thread that the control's underlying handle was created on.
        /// </summary>
        /// <param name="method">A delegate to a method that takes parameters of the same number and type that are contained in the args parameter.</param>
        /// <param name="args">An array of objects to pass as arguments to the given method. This can be null if no arguments are needed.</param>
        /// <returns>An <see cref="IAsyncResult"/> that represents the result of the <see cref="Control.BeginInvoke(Delegate)"/> operation.</returns>
        /// <exception cref="InvalidOperationException">No appropriate window handle can be found.</exception>
        public new IAsyncResult BeginInvoke(Delegate method, params object[] args) => base.BeginInvoke(method, args);

        /// <summary>
        /// Clears all text from the text box control.
        /// </summary>
        public void Clear() => this.textBox.Clear();

        /// <summary>
        /// Clears information about the most recent operation from the undo buffer of the text box.
        /// </summary>
        public void ClearUndo() => this.textBox.ClearUndo();

        /// <summary>
        /// Copies the current selection in the text box to the Clipboard.
        /// </summary>
        public void Copy() => this.textBox.Copy();

        /// <summary>
        /// Moves the current selection in the text box to the Clipboard.
        /// </summary>
        public void Cut() => this.textBox.Cut();

        /// <summary>
        /// Specifies that the value of the <see cref="SelectionLength"/> property is zero so that no characters are selected in the control.
        /// </summary>
        public void DeselectAll() => this.textBox.DeselectAll();

        /// <summary>
        ///  Retrieves the character that is closest to the specified location within the control.
        /// </summary>
        /// <param name="pt">The location from which to seek the nearest character.</param>
        /// <returns>The character at the specified location.</returns>
        public char GetCharFromPosition(Point pt) => this.textBox.GetCharFromPosition(pt);

        /// <summary>
        /// Retrieves the index of the character nearest to the specified location.
        /// </summary>
        /// <param name="pt">The location to search.</param>
        /// <returns>The zero-based character index at the specified location.</returns>
        public int GetCharIndexFromPosition(Point pt) => this.textBox.GetCharIndexFromPosition(pt);

        /// <summary>
        /// Retrieves the index of the first character of a given line.
        /// </summary>
        /// <param name="lineNumber">The line for which to get the index of its first character.</param>
        /// <returns>The zero-based index of the first character in the specified line.</returns>
        /// <exception cref="ArgumentOutOfRangeException">The value of the lineNumber parameter is less than zero.</exception>
        public int GetFirstCharIndexFromLine(int lineNumber) => this.textBox.GetFirstCharIndexFromLine(lineNumber);

        /// <summary>
        /// Retrieves the index of the first character of the current line.
        /// </summary>
        /// <returns>The zero-based character index in the current line.</returns>
        public int GetFirstCharIndexOfCurrentLine() => this.textBox.GetFirstCharIndexOfCurrentLine();

        /// <summary>
        /// Retrieves the line number from the specified character position within the text of the control.
        /// </summary>
        /// <param name="index">The character index position to search.</param>
        /// <returns>The zero-based line number in which the character index is located.</returns>
        public int GetLineFromCharIndex(int index) => this.textBox.GetLineFromCharIndex(index);

        /// <summary>
        /// Retrieves the location within the control at the specified character index.
        /// </summary>
        /// <param name="index">The index of the character for which to retrieve the location.</param>
        /// <returns>The location of the specified character within the client rectangle of the control.</returns>
        public Point GetPositionFromCharIndex(int index) => this.textBox.GetPositionFromCharIndex(index);

        /// <summary>
        /// Replaces the current selection in the text box with the contents of the Clipboard.
        /// </summary>
        public void Paste() => this.textBox.Paste();

        /// <summary>
        /// Sets the selected text to the specified text without clearing the undo buffer.
        /// </summary>
        /// <param name="text">The text to replace.</param>
        public void Paste(string text) => this.textBox.Paste(text);

        /// <summary>
        /// Scrolls the contents of the control to the current caret position.
        /// </summary>
        public void ScrollToCaret() => this.textBox.ScrollToCaret();

        /// <summary>
        /// Selects a range of text in the text box.
        /// </summary>
        /// <param name="start">The position of the first character in the current text selection within the text box.</param>
        /// <param name="length">The number of characters to select.</param>
        /// <exception cref="ArgumentOutOfRangeException">The value of the start parameter is less than zero.</exception>
        public void Select(int start, int length) => this.textBox.Select(start, length);

        /// <summary>
        /// Selects all text in the text box.
        /// </summary>
        public void SelectAll() => this.textBox.SelectAll();

        /// <summary>
        /// Undoes the last edit operation in the text box.
        /// </summary>
        public void Undo() => this.textBox.Undo();
    }
}
