﻿using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;

namespace Clock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public string format = "hh:mm:ss tt";
        public MainWindow()
        {
            InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer(new TimeSpan(0, 0, 1),
                DispatcherPriority.Normal, delegate
                {
                    clockLabel.Content = DateTime.Now.ToString(format); 
                }, this.Dispatcher);

        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Set12HrClock(object sender, EventArgs e)
        {
            format = "hh:mm:ss tt";
        }

        private void Set24HrClock(object sender, EventArgs e)
        {
            format = "HH:mm:ss";
        }

        // change clock text size
        private void SetSizeToSmall(object sender, EventArgs e)
        {
            clockLabel.FontSize = 60;
        }
        private void SetSizeToMedium(object sender, EventArgs e)
        {
            clockLabel.FontSize = 80;
        }
        private void SetSizeToLarge(object sender, EventArgs e)
        {
            clockLabel.FontSize = 100;
        }

        ///Change the color of the clock
        private void SetToRed(object sender, EventArgs e)
        {
            clockLabel.Foreground = Brushes.Red;
        }

        private void SetToGreen(object sender, EventArgs e)
        {
            clockLabel.Foreground = Brushes.GreenYellow;
        }

        private void SetToBlue(object sender, EventArgs e)
        {
            clockLabel.Foreground = Brushes.DeepSkyBlue;
        }

        private void SetToPink(object sender, EventArgs e)
        {
            clockLabel.Foreground = Brushes.Pink;
        }

        private void SetToBlack(object sender, EventArgs e)
        {
            clockLabel.Foreground = Brushes.Black;
        }

        private void SetToWhite(object sender, EventArgs e)
        {
            clockLabel.Foreground = Brushes.White;
        }
    }
}
