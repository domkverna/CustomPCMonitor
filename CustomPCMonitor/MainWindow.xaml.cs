﻿using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CustomPCMonitor
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Allow dragging the window only when clicking the title bar
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
            MessageBox.Show("New File action triggered");
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

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}