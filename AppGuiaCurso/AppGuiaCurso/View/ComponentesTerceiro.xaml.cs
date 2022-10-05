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
    public partial class ComponentesTerceiro : ContentPage
    {
        public ComponentesTerceiro()
        {
            InitializeComponent();
        }

        private async void Button_Clicked_Web3(object sender, EventArgs e)
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

        private async void Button_Clicked_Mob2(object sender, EventArgs e)
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

        private async void Button_Clicked_IPS(object sender, EventArgs e)
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

        private async void Button_Clicked_TCC(object sender, EventArgs e)
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

        private async void Button_Clicked_SE2(object sender, EventArgs e)
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

        private async void Button_Clicked_QTS(object sender, EventArgs e)
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