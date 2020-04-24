﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FootbagPix
{
    /// <summary>
    /// Interaction logic for NewGameWindow.xaml
    /// </summary>
    public partial class NewGameWindow : Window
    {
        public string PlayerName { get; set; }

        public NewGameWindow()
        {
            InitializeComponent();
            PlayerName = "";
        }

        private void Button_Back_Click(object sender, RoutedEventArgs e)
        {
            MainMenuWindow mainmenuWindow = new MainMenuWindow
            {
                WindowStartupLocation = WindowStartupLocation.Manual,
                Left = this.Left,
                Top = this.Top - 150 
            };
            mainmenuWindow.Show();
            this.Close();
        }

        private void Button_Play_Click(object sender, RoutedEventArgs e)
        {
            if (PlayerName.Length > 2)
            {
                MainWindow mainWindow = new MainWindow(PlayerName)
                {
                    Left = this.Left,
                    Top = this.Top - 150
                };
                mainWindow.Show();
                this.Close();
            }   
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            NewGameTextBox.Text = string.Concat(NewGameTextBox.Text.Where(char.IsLetterOrDigit));
            NewGameTextBox.SelectionStart = NewGameTextBox.Text.Length + 1;
            PlayerName = NewGameTextBox.Text.ToUpper();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (PlayerName.Length > 2)
                {
                    MainWindow mainWindow = new MainWindow(PlayerName)
                    {
                        Left = this.Left,
                        Top = this.Top - 150
                    };
                    mainWindow.Show();
                    this.Close();
                }
            }
        }
    }
}
