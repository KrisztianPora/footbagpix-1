﻿namespace FootbagPix
{
    using System.Windows;
    using System.Windows.Input;
    using FootbagPix.Models;
    using FootbagPix.Repository;

    /// <summary>
    /// Interaction logic for LoadWindow.xaml
    /// </summary>
    public partial class LoadWindow : Window
    {
        public LoadWindow()
        {
            InitializeComponent();
            GameModelRepository repository = new GameModelRepository("savedgames.xml");
            LoadList.ItemsSource = repository.GetAll();
        }

        private void Button_Load_Click(object sender, RoutedEventArgs e)
        {
            if (LoadList.SelectedItem != null)
            {
                GameModel gameToLoad = LoadList.SelectedItem as GameModel;
                MainWindow mainWindow = new MainWindow(gameToLoad)
                {
                    Left = this.Left,
                    Top = this.Top - 150
                };
                mainWindow.Show();
                this.Close();
            }
        }

        private void Button_Back_Click(object sender, RoutedEventArgs e)
        {
            MainMenuWindow mainmenuWindow = new MainMenuWindow
            {
                WindowStartupLocation = WindowStartupLocation.Manual,
                Left = this.Left,
                Top = this.Top
            };
            mainmenuWindow.Show();
            this.Close();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
    }
}
