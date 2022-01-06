// <copyright file="WatermarkedTextBox.AboutTab.cs" company="Mike Rudnikov">
// Copyright (c) Mike Rudnikov. All rights reserved.
// </copyright>

namespace WatermarkedTextBox
{
    using System.ComponentModel;

    /// <content>
    /// Contains displayed properties on the <see cref="AboutTab"/>.
    /// </content>
    public partial class WatermarkedTextBox
    {
        private const string AUTHOR = "Mike Rudnikov";
        private const string GIT = "github.com/RudMike/WatermarkedTextBox";

        /// <summary>
        /// Gets the information about the author.
        /// </summary>
        /// <returns>The information about the author.</returns>
        [AboutTabDisplay(true)]
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [SRCategory("catAbout")]
        [SRDescription("descAuthor")]
        public string Author => AUTHOR;

        /// <summary>
        /// Gets the link to the git account of the author.
        /// </summary>
        /// <returns>The link to the git account of the author.</returns>
        [AboutTabDisplay(true)]
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [SRCategory("catAbout")]
        [SRDescription("descGit")]
        public string Git => GIT;
    }
}
