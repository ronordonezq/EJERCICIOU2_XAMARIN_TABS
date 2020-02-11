using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using EJERCICIOU2_XAMARIN_TABS.TabbedPages;
namespace EJERCICIOU2_XAMARIN_TABS
{
    public class MyTabbedPage: TabbedPage
    {
        public MyTabbedPage()
        {
            this.Children.Add(new TabPage1());
            this.Children.Add(new TabPage2());
            this.Children.Add(new TabPage3());
        }
    }
}
