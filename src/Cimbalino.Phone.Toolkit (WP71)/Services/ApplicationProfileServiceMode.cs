﻿// ****************************************************************************
// <copyright file="ApplicationProfileServiceMode.cs" company="Pedro Lamas">
// Copyright © Pedro Lamas 2013
// </copyright>
// ****************************************************************************
// <author>Pedro Lamas</author>
// <email>pedrolamas@gmail.com</email>
// <date>17-03-2013</date>
// <project>Cimbalino.Phone.Toolkit.Camera</project>
// <web>http://www.pedrolamas.com</web>
// <license>
// See license.txt in this solution or http://www.pedrolamas.com/license_MIT.txt
// </license>
// ****************************************************************************

namespace Cimbalino.Phone.Toolkit.Services
{
    /// <summary>
    /// Describes the application profile mode.
    /// </summary>
    public enum ApplicationProfileServiceMode
    {
        /// <summary>
        /// The application is running in an unknown mode.
        /// </summary>
        Unknown,

        /// <summary>
        /// The application is running in default mode.
        /// </summary>
        Default,

        /// <summary>
        /// The application is running under kids corner.
        /// </summary>
        KidsCorner
    }
}