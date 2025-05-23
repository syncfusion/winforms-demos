#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using Syncfusion.WinForms.Core;

namespace Syncfusion.WinForms.DataGrid
{
    /// <summary>
    /// Represents a class which contains resource manager that provides convenient access to culture-specific resources at run time.
    /// </summary>
    public class SR
    {
        #region Fields

        /// <summary>
        /// Gets or sets the default assembly for resource manager.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Reviewed. Suppression is OK here.")]
        protected static Assembly assembly = null;

        /// <summary>
        /// The loader.
        /// </summary>
        private static SR loader = null;

        /// <summary>
        /// The resource manager.
        /// </summary>
        private ResourceManager resources;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="SR"/> class.
        /// </summary>
        public SR()
        {
            string nameSpace = "Syncfusion.WinForms.DataGrid";
            ResourceManager localizedResourceManager = GetLocalizedResourceManager(assembly != null ? assembly : GetType().Assembly, nameSpace);
            if (localizedResourceManager != null)
            {
                resources = localizedResourceManager;
                return;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Sets the resource manager based on the assembly and namespace.
        /// It can be used to get the values from the application resource files 
        /// when the assembly name and the namespace of the control or application is different.
        /// </summary>
        /// <param name="controlAssembly">The control assembly.</param>
        /// <param name="nameSpace">The namespace of the control.</param>
        public static void SetResources(Assembly controlAssembly, string nameSpace)
        {
            assembly = controlAssembly;
            ResourceManager resourceManager = GetLocalizedResourceManager(controlAssembly, nameSpace);

            // Gets the ResourceManager from the given fully qualified namespace. 
            if (resourceManager == null)
            {
                resourceManager = new ResourceManager(nameSpace, controlAssembly);
            }

            try
            {
                if (resourceManager.GetResourceSet(CultureInfo.CurrentUICulture, true, true) != null)
                {
                    loader = GetLoader();
                    loader.resources = resourceManager;
                }
            }
            catch
            {
                return;
            }
        }

        /// <summary>
        /// Gets the localized string for the current culture.
        /// </summary>
        /// <param name="name">The string that need to be localized.</param>
        /// <returns>Returns the localized string.</returns>
        public static string GetString(string name)
        {
            SR sr = GetLoader();
            try
            {
                return sr.resources.GetString(name, null);
            }
            catch
            {
                return name;
            }
        }

        /// <summary>
        /// Gets the static <see cref="SR"/> object.
        /// </summary>
        /// <returns>Returns the <see cref="SR"/> value.</returns>
        private static SR GetLoader()
        {
            if (SR.loader == null)
                SR.loader = new SR();
            return SR.loader;
        }

        /// <summary>
        /// Gets the localized ResourceManager.
        /// </summary>
        /// <param name="controlAssembly">The assembly of the control.</param>
        /// <param name="nameSpace">The namespace of the control.</param>
        /// <returns>Returns the resource manager.</returns>
        private static ResourceManager GetLocalizedResourceManager(Assembly controlAssembly, string nameSpace = "")
        {
            Assembly entryAssembly = Assembly.GetEntryAssembly();
            if (entryAssembly == null)
                entryAssembly = Assembly.GetExecutingAssembly();
            try
            {
                ResourceManager resourceManager;

                if (string.IsNullOrEmpty(nameSpace))
                    nameSpace = controlAssembly.GetName().Name;

                string value = string.Format("{0}.Resources.{1}.resources", entryAssembly.FullName.Split(new char[] { ',' })[0],
                      controlAssembly.FullName.Split(new char[] { ',' })[0]);
                if (entryAssembly.GetManifestResourceNames().Contains(value))
                {
                    string baseName = string.Format("{0}.Resources.{1}", entryAssembly.FullName.Split(new char[] { ',' })[0],
                        controlAssembly.FullName.Split(new char[] { ',' })[0]);
                    resourceManager = new ResourceManager(baseName, entryAssembly);
                }
                else
                {
                    string assemblyName = controlAssembly.FullName.Split(new char[] { ',' })[0];
                    string baseName = string.Format("{0}.Resources.{1}", nameSpace, assemblyName);
                    resourceManager = new ResourceManager(baseName, controlAssembly);
                }

                if (resourceManager != null)
                {
                    CultureInfo currentUICulture = CultureInfo.CurrentUICulture;
                    if (resourceManager.GetResourceSet(currentUICulture, true, true) != null)
                    {
                        return resourceManager;
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }

            return null;
        }

        #endregion
    }
}
