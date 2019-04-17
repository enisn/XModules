using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using XModules.Core.Attributes;
using XModules.Core.Exceptions;

namespace XModules.Core.Extensions
{
    public static class EntryObjectExtensions
    {
        public static ModuleEntryObjectAttribute GetEntryObjectAttribute(this Assembly assembly)
        {
            try
            {
                return assembly.GetCustomAttribute<ModuleEntryObjectAttribute>();
            }
            catch (ArgumentNullException)
            {
                throw ModuleNotValidException.NoEntryObject();
            }
        }
        public static object GetEntryObject(this Assembly assembly)
        {            
            return assembly.GetEntryObjectAttribute().GetEntryObjectInstance();
        }
        public static T GetEntryObject<T>(this Assembly assembly)
        {            
            return assembly.GetEntryObjectAttribute().GetEntryObjectInstance<T>();
        }
    }
}
