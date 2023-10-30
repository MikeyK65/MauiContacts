﻿namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count+=10;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //DisplayAlert("Hello", "Hello World", "OK");
            await Shell.Current.GoToAsync("NewPage2");
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            var hasInternet = Microsoft.Maui.Networking.Connectivity.Current.NetworkAccess == NetworkAccess.Internet;
            _ = DisplayAlert("Has internet ?", $"{hasInternet}", "OK");
        }
    }
}