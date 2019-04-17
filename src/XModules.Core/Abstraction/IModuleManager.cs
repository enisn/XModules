using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace XModules.Core.Abstraction
{
    public interface IModuleManager
    {
        Task<Assembly> Load(string id, string version);
        Task<bool> Download(Uri uri, CancellationToken token);
        Task<bool> Download(string id, CancellationToken token);

        Task<Assembly> LoadAssemblyAsync(string id);
        Task<Assembly> LoadAssemblyAsync(byte[] rawAssembly);

        bool IsValid(Assembly assembly);
    }
}
