using Microsoft.Maui.Controls;
using System;
using IMProWater.Data;

namespace IMProWater
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private async void OnRegisterButtonClicked(object sender, EventArgs e)
        {
            string email = EmailEntry.Text;
            string password = PasswordEntry.Text;

            var user = new User { Email = email, Password = password };
            await Database.DatabaseInstance.InsertAsync(user);

            await DisplayAlert("Sukces", "Rejestracja zako�czona pomy�lnie!", "OK");
            // Przejd� do strony logowania
            await Navigation.PushAsync(new LoginPage());
        }
    }
}
