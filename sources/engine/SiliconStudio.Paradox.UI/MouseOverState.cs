﻿// Copyright (c) 2014 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under GPL v3. See LICENSE.md for details.
namespace SiliconStudio.Paradox.UI
{
    /// <summary>
    /// Describe the possible states of the mouse over an UI element.
    /// </summary>
    public enum MouseOverState
    {
        /// <summary>
        /// The mouse is neither over the element nor one of its children.
        /// </summary>
        MouseOverNone,

        /// <summary>
        /// The mouse is over one of children of the element.
        /// </summary>
        MouseOverChild,

        /// <summary>
        /// The mouse is directly over the element.
        /// </summary>
        MouseOverElement,
    }
}