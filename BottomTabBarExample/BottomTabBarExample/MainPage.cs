using BottomBar.XamarinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BottomTabBarExample
{
    public class MainPage : BottomBarPage
    {
        public MainPage()
        {
            Children.Add(new ContentPage()
            {
                Content =
                    new Label
                    {
                        Text = "Page 1",
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    },
                Title = "Page 1"
            });

            Children.Add(new ContentPage()
            {
                Content =
                    new Label
                    {
                        Text = "Page 2",
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    },
                Title = "Page 2"
            });

            Children.Add(new ContentPage()
            {
                Content =
                    new Label
                    {
                        Text = "Page 3",
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    },
                Title = "Page 3"
            });
            NavigationPage.SetHasNavigationBar(this, true);
            ToolbarItems.Add(new ToolbarItem()
            {
                Text = "Something"
            });
        }
    }
}
