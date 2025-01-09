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
        }
        private void NewFile_Click(object sender, RoutedEventArgs e)
        {
            bool isOpen = false;
            CreateDesignWindow newWindow = new CreateDesignWindow();
            newWindow.Show();
            isOpen = true;
            if (isOpen) //This will disable the buttons
            {
                FileButton.IsEnabled = false;
                MinimizeButton.IsEnabled = false;
                MaximizeButton.IsEnabled = false;
                ExitButton.IsEnabled = false;
            }

        }
        private void OpenFile_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Open File action triggered");
        }
        private void SaveFile_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Save File action triggered");
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Undo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Undo action triggered");
        }
        private void Redo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Redo action triggered");
        }
        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This is a custom PC monitor application.");
        }
        public void UpdateCanvasSize(double width, double height)
        {
            designCanvas.Width = width;
            designCanvas.Height = height;
        }
    }
}
