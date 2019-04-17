using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using XModules.Core.Attributes;

namespace XModules.Core.Extensions
{
    public static class AssemblyExtensions 
    {
        public static IEnumerable<ModuleDependencyAttribute> GetDependencyAttributes(this Assembly assembly)
        {
            foreach (var meta in assembly.GetCustomAttributes<ModuleDependencyAttribute>())
            {
                yield return meta;
            }
        }
    }
}
