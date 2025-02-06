using BankClones.Views;

namespace BankClones
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Register routes for navigation
            Routing.RegisterRoute("remote_banking", typeof(RemoteBankingPage));  // Ensure this is here
            Routing.RegisterRoute("about", typeof(AboutPage));
        }
    }
}
