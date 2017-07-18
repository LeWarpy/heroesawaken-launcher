using System;
using System.Windows;

using GameLauncherLibrary;
namespace GameLauncherTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void websiteButton_Click(object sender, RoutedEventArgs e)
        {
            Launcher.LaunchWebsite("https://heroesawaken.com/");
        }
        private void registerButton_Click(object sender, RoutedEventArgs e)
        {
            Launcher.LaunchWebsite("https://heroesawaken.com/register");
        }
        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            Launcher.LaunchWebsite("https://heroesawaken.com/login");
        }

        private void launchButton_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayGame();
            Environment.Exit(0);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ProgressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
        private void MapChangeButton_Click(object sender, RoutedEventArgs e)
        {
            Launcher.MapChange();
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {

        }
        private void DiscordButton_Click(object sender, RoutedEventArgs e)
        {
            Launcher.LaunchWebsite("https://discord.gg/7DSFmvv");
        }
    }
}
