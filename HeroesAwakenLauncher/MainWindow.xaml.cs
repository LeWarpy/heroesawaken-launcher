﻿using System;
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
    }
}
