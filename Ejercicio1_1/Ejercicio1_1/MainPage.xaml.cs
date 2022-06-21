using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio1_1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void btnsuma_Clicked(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtnum1.Text) && !string.IsNullOrEmpty(txtnum2.Text))
            {
                Double resultadoNum = Convert.ToDouble(txtnum1.Text) + Convert.ToDouble(txtnum2.Text);
                String resultadoText = "Resultado de la suma";
                await Navigation.PushAsync(new SecondPage(resultadoText, resultadoNum));
            }
            else
            {
                DisplayAlert("Aviso", "Necesita llenar los campos.", "Ok");
            }
            
        }
        private async void btnresta_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtnum1.Text) && !string.IsNullOrEmpty(txtnum2.Text))
            {
                Double resultadoNum = Convert.ToDouble(txtnum1.Text) - Convert.ToDouble(txtnum2.Text);
                String resultadoText = "Resultado de la resta";
                await Navigation.PushAsync(new SecondPage(resultadoText, resultadoNum));
            }
            else
            {
                DisplayAlert("Aviso", "Necesita llenar los campos.", "Ok");
            }
        }
        private async void btndivi_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtnum1.Text) && !string.IsNullOrEmpty(txtnum2.Text))
            {
                Double resultadoNum = Convert.ToDouble(txtnum1.Text) / Convert.ToDouble(txtnum2.Text);
                String resultadoText = "Resultado de la division";
                await Navigation.PushAsync(new SecondPage(resultadoText, resultadoNum));
            }
            else
            {
                DisplayAlert("Aviso", "Necesita llenar los campos.", "Ok");
            }
        }
        private async void btnmulti_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtnum1.Text) && !string.IsNullOrEmpty(txtnum2.Text))
            {
                Double resultadoNum = Convert.ToDouble(txtnum1.Text) * Convert.ToDouble(txtnum2.Text);
                String resultadoText = "Resultado de la multiplicacion";
                await Navigation.PushAsync(new SecondPage(resultadoText, resultadoNum));
            }
            else
            {
                DisplayAlert("Aviso", "Necesita llenar los campos.", "Ok");
            }
        }
    }
}
