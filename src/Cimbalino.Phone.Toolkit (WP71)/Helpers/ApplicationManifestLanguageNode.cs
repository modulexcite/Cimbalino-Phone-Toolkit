﻿// ****************************************************************************
// <copyright file="ApplicationManifestLanguageNode.cs" company="Pedro Lamas">
// Copyright © Pedro Lamas 2012
// </copyright>
// ****************************************************************************
// <author>Pedro Lamas</author>
// <email>pedrolamas@gmail.com</email>
// <date>26-12-2012</date>
// <project>Cimbalino.Phone.Toolkit</project>
// <web>http://www.pedrolamas.com</web>
// <license>
// See license.txt in this solution or http://www.pedrolamas.com/license_MIT.txt
// </license>
// ****************************************************************************

using System.Xml.Serialization;

namespace Cimbalino.Phone.Toolkit.Helpers
{
    /// <summary>
    /// Represents a language in the application manifest.
    /// </summary>
    public class ApplicationManifestLanguageNode
    {
        /// <summary>
        /// Gets or sets the language code.
        /// </summary>
        /// <value>The language code.</value>
        [XmlAttribute]
        public string Code { get; set; }
    }
}