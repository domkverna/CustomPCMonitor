using Microsoft.Win32;
using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CustomPCMonitor
{
    public partial class CreateDesignWindow : Window
    {
        private DesignWindow designWindow;

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
        // Allow only numeric input
        private void NumericTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsTextNumeric(e.Text); // Reject non-numeric input
        }

        // Prevent non-numeric pasting
        private void NumericTextBox_Pasting(object sender, DataObjectPastingEventArgs e)
        {
            if (e.DataObject.GetDataPresent(DataFormats.Text))
            {
                string pastedText = (string)e.DataObject.GetData(DataFormats.Text);
                if (!IsTextNumeric(pastedText))
                {
                    e.CancelCommand(); // Reject the paste operation
                }
            }
            else
            {
                e.CancelCommand(); // Reject the paste operation
            }
        }

        // Utility to check if the input is numeric
        private static bool IsTextNumeric(string text)
        {
            return Regex.IsMatch(text, @"^\d+$"); // Matches only digits (0-9)
        }
        private void ApplyCanvasSize_Click(object sender, RoutedEventArgs e)
        {
            // Parse the width and height from the textboxes
            if (double.TryParse(widthTextBox.Text, out double width) &&
                double.TryParse(heightTextBox.Text, out double height))
            {
                // Ensure the window is open
                if (designWindow == null || !designWindow.IsVisible)
                {
                    designWindow = new DesignWindow();
                    designWindow.Show();
                }

                // Update the canvas size
                designWindow.UpdateCanvasSize(width, height);
            }
        }
    }
}
