using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DanielAldaz
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NotesCalc : ContentPage
    {
        public NotesCalc(string luser)
        {
            InitializeComponent();
            user.Text = "Usuario conectado: " + luser;
        }

        private void B_info_Clicked(object sender, EventArgs e)
        {

            double ins_val = Convert.ToDouble(t_ins_value.Text);

            // Control

            if (ins_val >= 3000)

            {
                DisplayAlert("Error de Usuario !!", "El valor de inscripción debe ser menor a $3000.00 !!", "Cerrar");
            }

            if (ins_val == 0)

            {
                DisplayAlert("Error de Usuario !!", "El valor de inscripción debe ser mayor a 0 !!", "Cerrar");
            }

            if (ins_val <= 3000 && ins_val > 0)

            {
                double resultado = 3000 - ins_val;
                double result = ((3000*0.05) + resultado)/5;
                t_value2.Text = result.ToString();
            }

        }

        private async void B_info2_Clicked(object sender, EventArgs e)
        {
            string tuser = "danielaldaz2022";
            string name_val = Convert.ToString(t_name.Text);
            string insc_val = Convert.ToString(t_value2.Text);

            await Navigation.PushAsync(new AbstractPage(tuser, name_val, insc_val));

        }
        
    }
}