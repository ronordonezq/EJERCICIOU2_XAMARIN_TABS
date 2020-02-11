using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EJERCICIOU2_XAMARIN_TABS.TabbedPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabPage1 : ContentPage
    {
        public TabPage1()
        {
            InitializeComponent();
            this.Title = "Tab Page 1";
        }
    }
}