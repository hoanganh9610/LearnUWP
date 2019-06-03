using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DemoStyles
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            SetTitleBar();

        }

        private void SetTitleBar()
        {
            //var titleBar = Windows.ApplicationModel.Core.CoreApplication.GetCurrentView().TitleBar;
            var titleBar = CoreApplication.MainView.TitleBar;
            titleBar.ExtendViewIntoTitleBar = true;

        }

        private void SetThemes()
        {
            int a = comboBox.SelectedIndex;
            switch (a)
            {
                case 0:
                    RequestedTheme = ElementTheme.Default;
                    break;
                case 1:
                    RequestedTheme = ElementTheme.Dark;
                    break;
                case 2:
                    RequestedTheme = ElementTheme.Light;
                    break;

            }
        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListView view = (ListView)sender;
            //Get Index of Selected Item
            var index = view.SelectedIndex;
            //Get Selected Item
            var selectedItem = view.SelectedItem;

            switch (index)
            {
                case 0:
                    txtTitle.Text = "Color";
                    ucColor ucc = new ucColor();
                    ucContent.Children.Clear();
                    ucContent.Children.Add(ucc);
                    break;
                case 1:
                    txtTitle.Text = "Typography";
                    ucTypo uct = new ucTypo();
                    ucContent.Children.Clear();
                    ucContent.Children.Add(uct);
                    break;
                case 2: txtTitle.Text = "Icons"; break;
                case 3: txtTitle.Text = "Acrylic"; break;
                case 4: txtTitle.Text = "Reveal hightlight"; break;
                case 5: txtTitle.Text = "Reavel focus"; break;
                case 6: txtTitle.Text = "Sound"; break;
                case 7: txtTitle.Text = "Spacing"; break;
                case 8: txtTitle.Text = "Writing style"; break;
                case 9: txtTitle.Text = "XAML brushes"; break;
                case 10: txtTitle.Text = "XAML styles"; break;

            }
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SetThemes();
        }
    }
}
