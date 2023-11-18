namespace DotNet8InMauiShellIssue
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            Routing.RegisterRoute(nameof(NewPage), typeof(NewPage));//局域网发送界面
            InitializeComponent();
        }
    }
}
