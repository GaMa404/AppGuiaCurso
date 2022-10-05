using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AppGuiaCurso.Model;

namespace AppGuiaCurso.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ComponentesSegundo : ContentPage
    {
        public ComponentesSegundo()
        {
            InitializeComponent();
        }

        private async void Button_Clicked_Web2(object sender, EventArgs e)
        {
            try
            {
                var c = new Componentes
                {
                    Nome = "",

                    AtribuicoesResponsabilidades = "",

                    ValoresAtitudes = "",
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_Mob1(object sender, EventArgs e)
        {
            try
            {
                var c = new Componentes
                {
                    Nome = "",

                    AtribuicoesResponsabilidades = "",

                    ValoresAtitudes = "",
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_Etica(object sender, EventArgs e)
        {
            try
            {
                var c = new Componentes
                {
                    Nome = "",

                    AtribuicoesResponsabilidades = "",

                    ValoresAtitudes = "",
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_DS(object sender, EventArgs e)
        {
            try
            {
                var c = new Componentes
                {
                    Nome = "",

                    AtribuicoesResponsabilidades = "",

                    ValoresAtitudes = "",
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_SE1(object sender, EventArgs e)
        {
            try
            {
                var c = new Componentes
                {
                    Nome = "",

                    AtribuicoesResponsabilidades = "",

                    ValoresAtitudes = "",
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_BD2(object sender, EventArgs e)
        {
            try
            {
                var c = new Componentes
                {
                    Nome = "",

                    AtribuicoesResponsabilidades = "",

                    ValoresAtitudes = "",
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro!", ex.Message, "OK");
            }
        }
    }
}