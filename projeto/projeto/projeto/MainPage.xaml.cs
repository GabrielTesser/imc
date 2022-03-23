using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace projeto
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked (object sender, EventArgs e)
        {
            double peso = Convert.ToDouble(txt_peso.Text);
            double altura = Convert.ToDouble(txt_altura.Text);

            double imc = peso / (altura * altura);

            if (imc < 18.5)
            {
                DisplayAlert("seu imc é: " + imc, "você esta abaixo do peso", "ok");

            }
            else if (imc > 18.5 && imc < 24.9)
            {

                DisplayAlert("seu imc é: " + imc, "você esta no peso ideal", "ok");

            }
            else if (imc > 25 && imc < 29.9)
            {

                DisplayAlert("seu imc é: " + imc, "você esta no acima do peso", "ok");

            }
            else if (imc > 30 && imc < 34.9)
            {

                DisplayAlert("seu imc é: " + imc, "você esta com obesidade grau 1", "ok");

            }else if (imc > 35 && imc < 39.9) 
            {

                DisplayAlert("seu imc é: " + imc, "você esta com obesidade grau 2", "ok");

            }else if (imc > 40)
            {

                DisplayAlert("seu imc é " + imc, "você esta com obesidade morbida", "ok");

            }

        }
    }
}
