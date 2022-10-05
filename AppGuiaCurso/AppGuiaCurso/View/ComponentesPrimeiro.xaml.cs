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
    public partial class ComponentesPrimeiro : ContentPage
    {
        public ComponentesPrimeiro()
        {
            InitializeComponent();
        }

        private async void Button_Clicked_Web1(object sender, EventArgs e)
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
            catch(Exception ex)
            {
                await DisplayAlert("Erro!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_Analise(object sender, EventArgs e)
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

        private async void Button_Clicked_Alg(object sender, EventArgs e)
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

        private async void Button_Clicked_Fund(object sender, EventArgs e)
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

        private async void Button_Clicked_Dsgn(object sender, EventArgs e)
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

        private async void Button_Clicked_BD1(object sender, EventArgs e)
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