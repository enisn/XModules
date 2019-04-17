using System;
using System.Collections.Generic;
using System.Text;

namespace XModules.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
    public class ModuleEntryObjectAttribute : Attribute
    {
        public Type EntryType { get; }
        public ModuleEntryObjectAttribute(Type type)
        {
            EntryType = type;
        }
        /// <summary>
        /// Must be overriden to get instance from dependency service for constructor values if it has.
        /// </summary>
        /// <typeparam name="T">Type of object</typeparam>
        public virtual T GetEntryObjectInstance<T>()
        {
            return (T)GetEntryObjectInstance();
        }

        public virtual object GetEntryObjectInstance()
        {
            return Activator.CreateInstance(EntryType);
        }
    }
}
