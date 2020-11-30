using BeesApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BeesApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HiveView : ContentView
    {
        public HiveView()
        {
            InitializeComponent();
            this.BindingContext = new HiveViewModel();
        }
    }
}