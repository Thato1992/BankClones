using Microsoft.Maui.Controls;
using System;

namespace BankClones.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Handle "For Me" dot click
        private async void OnForMeClicked(object sender, EventArgs e)
        {
            // Navigate to the "For Me" page (or perform other actions)
            await DisplayAlert("For Me", "You selected the 'For Me' option.", "OK");
        }

        // Handle "For Business" dot click
        private async void OnForBusinessClicked(object sender, EventArgs e)
        {
            // Navigate to the "For Business" page (or perform other actions)
            await DisplayAlert("For Business", "You selected the 'For Business' option.", "OK");
        }

        // Handle "Menu" button click
        private async void OnMenuClicked(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet(null, "Cancel", null,
                "Remote Banking", "About");

            switch (action)
            {
                case "Remote Banking":
                    await Shell.Current.GoToAsync("remote_banking");
                    break;
                case "About":
                    await Shell.Current.GoToAsync("about");
                    break;
            }
        }

        // Handle "Sign In" button click
        private async void OnSignInClicked(object sender, EventArgs e)
        {
            // Handle the Sign In button action (e.g., navigate to a new page)
            await DisplayAlert("Sign In", "You clicked the Sign In button.", "OK");
        }

        // Handle each Quick Action frame click
        private async void OnQuickActionClicked(object sender, EventArgs e)
        {
            // Check if the sender is a Frame
            var frame = sender as Frame;
            if (frame != null)
            {
                // Retrieve the label text from the Frame's content
                var label = frame.Content as VerticalStackLayout;
                var actionLabel = label?.Children[1] as Label; // Assumes the second child is the Label
                string actionText = actionLabel?.Text ?? "Unknown Action";

                // Handle the quick action frame click (e.g., navigate or show a message)
                await DisplayAlert("Quick Action", $"You clicked: {actionText}", "OK");
            }
        }
    }
}
