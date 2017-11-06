using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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

namespace Hamburger_Challenge
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            MyFrame.Navigate(typeof(Home1));
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (HomeLBI.IsSelected)
            {
                MyFrame.Navigate(typeof(Home1));
                TitleTextBlock.Text = "Newspapers - Home";
                BackButton.Visibility = Visibility.Collapsed;
            }
            else if (DownloadLBI.IsSelected)
            {
                MyFrame.Navigate(typeof(Downloads));
                TitleTextBlock.Text = "Downloads";
                BackButton.Visibility = Visibility.Visible;
            }
            else if (FavouriteLBI.IsSelected)
            {
                MyFrame.Navigate(typeof(Favourites));
                TitleTextBlock.Text = "Favourites";
                BackButton.Visibility = Visibility.Visible;
            }
            else if (CatogariesLBI.IsSelected)
            {
                MyFrame.Navigate(typeof(Catogaries));
                TitleTextBlock.Text = "Catogaries";
                BackButton.Visibility = Visibility.Visible;
            }
            else if (LogInLBI.IsSelected)
            {
                MyFrame.Navigate(typeof(Login));
                TitleTextBlock.Text = "Login";
                BackButton.Visibility = Visibility.Visible;
            }
            else if (SettingsLBI.IsSelected)
            {
                MyFrame.Navigate(typeof(Settings));
                TitleTextBlock.Text = "Settings";
                BackButton.Visibility = Visibility.Visible;
            }
        }

        private void HaburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (MyFrame.CanGoBack)
            {
                MyFrame.GoBack();
                TitleTextBlock.Text = "";
            }
        }
    }
}
