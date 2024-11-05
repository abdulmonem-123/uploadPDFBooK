using System;
using Microsoft.Maui.Controls;
using System.Threading.Tasks;
using Supabase.Gotrue;
using uploadPDFBooK.Models;
using ModelsUser = uploadPDFBooK.Models.User;
using GotrueUser = Supabase.Gotrue.User;
using Supabase.Interfaces;

namespace uploadPDFBooK
{
    public partial class LoginPage : ContentPage
    {
        public Task SupabaseClient { get; private set; }

        public LoginPage()
        {
            InitializeComponent();
        }

       

        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            string username = UsernameEntry.Text;
            string password = PasswordEntry.Text;

            if (await AuthenticateUser(username, password))
            {
                await DisplayAlert("نجاح", "تم تسجيل الدخول بنجاح!", "موافق");
                // الانتقال إلى الصفحة التالية بعد النجاح
                await Shell.Current.GoToAsync("//PDFView"); // تأكد من وجود HomePage في مشروعك أو استخدم صفحة أخرى
            }
            else
            {
                await DisplayAlert("خطأ", "اسم المستخدم أو كلمة المرور غير صحيحة.", "موافق");
            }
        }

        private async Task<bool> AuthenticateUser(string username, string password)
        {
            //var users = await SupabaseClient

            var response = await MauiProgram.SupabaseClient
                
                .From<ModelsUser>()
                .Filter("user", Supabase.Postgrest.Constants.Operator.Equals, username)
                .Filter("password", Supabase.Postgrest.Constants.Operator.Equals, password)
                .Get();

            return response.Models.Count > 0;
        }


    }
}
