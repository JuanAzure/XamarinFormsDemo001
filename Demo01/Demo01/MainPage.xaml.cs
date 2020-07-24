using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace Demo01
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            if(!string.IsNullOrWhiteSpace(Altura.Text) && !string.IsNullOrWhiteSpace(Peso.Text))

            {
                var altura = double.Parse(Altura.Text);
                var peso = double.Parse(Peso.Text);
                var _imc = peso / (altura * altura);
                imc.Text = _imc.ToString();

                string resultado = "";
                if (_imc < 18.5)
                {
                    resultado = "Tienes bajo peso";
                }
                else if (_imc > 18.5 && _imc <= 24.9)
                {
                    resultado = "Tu peso es normal";
                }

                else if (_imc > 25 && _imc <= 29.9)
                {
                    resultado = "Tienes sobre peso";
                }
                else
                {
                    resultado = "Tienes Obesidad";
                }
                DisplayAlert("IMC", resultado, "OK");
            }
            else
            {
                DisplayAlert("Datos errones", "Por favor, llena toda la informacion", "OK");
            }
        }
            
    }
}
