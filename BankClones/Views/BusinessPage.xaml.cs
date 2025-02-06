namespace BankClones.Views
{
    public partial class BusinessPage : ContentPage
    {
        public BusinessPage()
        {
            InitializeComponent();
        }

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
    }
}
