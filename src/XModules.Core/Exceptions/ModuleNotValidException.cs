using System;
using System.Collections.Generic;
using System.Text;
using XModules.Core.Attributes;

namespace XModules.Core.Exceptions
{

    [Serializable]
    public class ModuleNotValidException : Exception
    {
        public ModuleNotValidException() { }
        public ModuleNotValidException(string message) : base(message) { }
        public ModuleNotValidException(string message, Exception inner) : base(message, inner) { }
        protected ModuleNotValidException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

        public static ModuleNotValidException NoEntryObject() => new ModuleNotValidException($"{typeof(ModuleEntryObjectAttribute).Name} couldn't be found as assembly attribute. You must add that attribute to your assembly!");
    }
}
