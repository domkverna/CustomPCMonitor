using Microsoft.Win32;
using System;
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

namespace CustomPCMonitor
{
    /// <summary>
    /// Interaction logic for DesignWindow.xaml
    /// </summary>
    public partial class DesignWindow : Window
    {
        public DesignWindow()
        {
            InitializeComponent();
        }

        private void Option1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Option 1 clicked!");
        }

        private void Option2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Option 2 clicked!");
        }

        private void ExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        // Logic for resizing the window
        private bool _isFullScreen = false;
        private double _previousWidth;
        private double _previousHeight;
        private double _previousLeft;
        private double _previousTop;

        private void ResizeWindow_Click(object sender, RoutedEventArgs e)
        {
            if (_isFullScreen)
            {
                // Logic for restoring the window to normal size and position
                this.WindowState = WindowState.Normal;
                this.Width = _previousWidth;
                this.Height = _previousHeight;
                this.Left = _previousLeft;
                this.Top = _previousTop;
                _isFullScreen = false;
            }
            else
            {
                // This saves the size and position
                _previousWidth = this.Width;
                _previousHeight = this.Height;
                _previousLeft = this.Left;
                _previousTop = this.Top;

                // Logic for fullscreen
                this.WindowState = WindowState.Normal; // Ensure the window is in a normal state before resizing
                this.Left = 0;
                this.Top = 0;
                this.Width = SystemParameters.PrimaryScreenWidth;
                this.Height = SystemParameters.PrimaryScreenHeight;
                _isFullScreen = true;
            }
        }

        // Logic for minimizing the window
        private void minimizeWindow_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        // Logic for moving the window when grabbing the menu
        private void Menu_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // Check if the left mouse button is pressed
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                // Initiate window drag
                this.DragMove();
            }
        }

        // Import Button Click Event Handler
        private void ImportButton_Click(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select a File to Import";
            openFileDialog.Filter = "CPCM Files (*.cpcm)|*.cpcm";
            openFileDialog.DefaultExt = ".cpcm";

            // Show the dialog and check if a file was selected
            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;

                // Perform any logic with the file (for now, display a message)
                MessageBox.Show($"File Imported: {filePath}", "Import Successful", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
