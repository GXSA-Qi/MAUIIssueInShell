namespace DotNet8InMauiShellIssue
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            Routing.RegisterRoute(nameof(NewPage), typeof(NewPage));
            InitializeComponent();
        }
    }
}
