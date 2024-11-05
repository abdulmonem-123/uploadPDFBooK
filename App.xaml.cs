// App.xaml.cs
using Microsoft.Maui.Hosting;
using System.Net.Http;
using uploadPDFBooK;

namespace uploadPDFBooK
{
    public partial class App : Application
    {


        public App()
        {
            InitializeComponent();
            MainPage = new AppShell(); // استخدم AppShell هنا إذا كان لديك التنقل
        }

    }
}