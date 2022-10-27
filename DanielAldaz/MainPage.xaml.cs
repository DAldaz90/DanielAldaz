using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DanielAldaz
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void but_login_Clicked(object sender, EventArgs e)
        {

            string user = "danielaldaz2022";
            string password = "uisrael2022";

            string T_User = txt_user.Text;
            string T_Pass = txt_pass.Text;

            if (user == T_User & password == T_Pass)
            {
                
                await Navigation.PushAsync(new NotesCalc(user));
                await DisplayAlert("Ingreso Exitoso !", "Datos Válidos para !!" + user, "Cerrar");
            }

            else
            {
                await DisplayAlert("Error !", "Usuario o Contraseña Incorrecta", "Cerrar");
            }
        }
    }
}
