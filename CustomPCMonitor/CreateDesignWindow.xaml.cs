using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CustomPCMonitor
{
    public partial class CreateDesignWindow : Window
    {
        public CreateDesignWindow()
        {
            InitializeComponent();
        }
        private void CustomTitleBar_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.ChangedButton == System.Windows.Input.MouseButton.Left)
            {
                this.DragMove();
            }
        }
        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        private void Maximize_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
            }
            else
            {
                this.WindowState = WindowState.Maximized;
            }
        }
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

            var mainWindow = Application.Current.MainWindow as MainWindow;
            if (mainWindow != null)
            {
                mainWindow.FileButton.IsEnabled = true;
                mainWindow.MinimizeButton.IsEnabled = true;
                mainWindow.MaximizeButton.IsEnabled = true;
                mainWindow.ExitButton.IsEnabled = true;
                mainWindow.StartBorder.IsEnabled = true;
            }
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ClearTextboxOnClick(object sender, MouseButtonEventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox.Text == "Width (px)" || textBox.Text == "Height (px)")
            {
                textBox.Text = string.Empty;
            }
        }
    }
}
