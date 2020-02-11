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
    public partial class TabPage2 : ContentPage
    {
        public TabPage2()
        {
            InitializeComponent();
            this.Title = "Tab Page 2";
        }
    }
}