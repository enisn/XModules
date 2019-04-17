using System.Reflection;
using Xamarin.Forms.Xaml;
using XModules.Core.Attributes;
using XModules.Core.Constants;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

[assembly: ModuleEntryObject(typeof(MyModule1.MainPage))]

[assembly: ModuleDependency("Sample", "1.0.0")]

[assembly: AssemblyMetadata(MetaDataKey.ID, "Sample.MyModule1")]
[assembly: AssemblyMetadata(MetaDataKey.TITLE, "MyModule1")]


