using System;
using System.Collections.Generic;
using System.Text;

namespace XModules.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
    public class ModuleDependencyAttribute : Attribute
    {
        /// <summary>
        /// Define dependencies of this module. They'll be loaded earlier.
        /// </summary>
        /// <param name="xmodule">XModule ID</param>
        /// <param name="version">Version of module. You can pass * for latest. Example: "1.*.*" will gets latest version but major must be '1'. Single * is means latest.</param>
        public ModuleDependencyAttribute(string xmodule, string version)
        {
            ModuleID = xmodule;
            Version = version;
        }
        public string ModuleID { get; }
        public string Version { get; }
    }
}
