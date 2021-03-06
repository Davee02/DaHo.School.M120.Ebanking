﻿using System.Windows;
using DaHo.School.M120.Ebanking.Services;

namespace DaHo.School.M120.Ebanking.Views
{
    /// <summary>
    /// Interaction logic for CurrencyView.xaml
    /// </summary>
    public partial class ReceiveMoneyView : Window
    {
        public ReceiveMoneyView()
        {
            InitializeComponent();

            var tracker = TrackerService.JotTracker;
            tracker.Track(this);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
