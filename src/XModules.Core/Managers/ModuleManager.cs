using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XModules.Core.Abstraction;
using XModules.Core.Exceptions;
using XModules.Core.Extensions;

namespace XModules.Core.Managers
{
    public class ModuleManager : IModuleManager
    {
        public Task<bool> Download(Uri uri, CancellationToken token)
        {
            throw new NotImplementedException("Downloading not implemented yet!");
        }

        public Task<bool> Download(string id, CancellationToken token)
        {
            throw new NotImplementedException("Downloading not supported yet!");
        }

        public bool IsValid(Assembly assembly)
        {
            return assembly.GetEntryObjectAttribute() != null && assembly.GetCustomAttributes<AssemblyMetadataAttribute>().Any(a => a.Key == Constants.MetaDataKey.ID);
        }

        public Task<Assembly> Load(string id, string version)
        {
            throw new NotImplementedException();
        }

        public Task<Assembly> LoadAssemblyAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Assembly> LoadAssemblyAsync(byte[] rawAssembly)
        {
            var assembly = Assembly.Load(rawAssembly);
            if (IsValid(assembly))
            {
                //foreach (var dependency in assembly.GetDependencyAttributes())
                //{
                //    Load(dependency.ModuleID, dependency.Version);
                //}

                //var xf = assembly.GetReferencedAssemblies().FirstOrDefault(x => x.Name == "Xamarin.Forms.Core");
                //var currentXF = Assembly.GetExecutingAssembly().GetReferencedAssemblies().FirstOrDefault(x => x.Name == "Xamarin.Forms.Core");
                //if (xf.Version > currentXF.Version)
                //    throw new DependencyException($"This project compiled with Xamarin Forms version {currentXF.Version} but {assembly.FullName} requires version {xf.Version}");

                return Task.FromResult(assembly);
            }
            throw new ModuleNotValidException();
        }
    }
}
