using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XModules.Core.Abstraction;
using XModules.Core.Extensions;
using XModules.Core.Managers;

namespace ModularApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        private readonly IModuleManager moduleManager = DependencyService.Get<IModuleManager>();
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("ModularApp.Resources.MyModule1.dll"))
            using (var ms = new MemoryStream())
            {
                await stream.CopyToAsync(ms);

                var m1 = await moduleManager.LoadAssemblyAsync(ms.ToArray());

                await Navigation.PushModalAsync(m1.GetEntryObject<Page>());
            }
        }
    }
}
