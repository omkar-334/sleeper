using System;
using System.Windows;
using System.Windows.Threading;

namespace BreakReminderApp
{
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer;

        public MainWindow()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMinutes(1); // Set timer interval to 20 minutes
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ShowBreakReminder();
        }

        private void ShowBreakReminder()
        {
            // Show a message box with a reminder to look outside for a break
            MessageBox.Show("It's time to take a break and look outside!", "Take a Break", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
            StartButton.Visibility = Visibility.Collapsed;
            StopButton.Visibility = Visibility.Visible;
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            StartButton.Visibility = Visibility.Visible;
            StopButton.Visibility = Visibility.Collapsed;
        }
    }
}
