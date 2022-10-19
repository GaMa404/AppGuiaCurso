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
                    Nome = "Programação Web II",

                    AtribuicoesResponsabilidades = "• Planejar projetos de sistemas de informação para Web.   ",

                    ValoresAtitudes = "• Incentivar a criatividade.\n" +
                                      "• Responsabilizar-se pela produção, utilização e divulgação de informações.\n" +
                                      "• Fortalecer a persistência e o interesse na resolução de situações-problema.",
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
                    Nome = "Programação de Aplicativos Mobile I",

                    AtribuicoesResponsabilidades = "• Elaborar projetos de aplicativos para plataformas móveis.",

                    ValoresAtitudes = "• Incentivar a criatividade.\n" +
                                      "• Estimular a organização.\n" +
                                      "• Responsabilizar-se pela produção, utilização e divulgação de informações.",
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
                    Nome = "Desenvolvimento de Sistemas",

                    AtribuicoesResponsabilidades = "• Codificar e depurar programas.\n" +
                                                   "• Selecionar linguagens de programação e ambientes de desenvolvimento de acordo com as especificidades do projeto.",

                    ValoresAtitudes = "• Desenvolver a criatividade.\n" +
                                      "• Incentivar ações que promovam a cooperação.\n" +
                                      "• Fortalecer a persistência e o interesse na resolução de situações-problema.\n",
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_SE(object sender, EventArgs e)
        {
            try
            {
                var c = new Componentes
                {
                    Nome = "Sistemas Embarcados I",

                    AtribuicoesResponsabilidades = "• Desenvolver sistemas embarcados.",

                    ValoresAtitudes = "• Incentivar a criatividade.\n" +
                                      "• Estimular a organização.\n" +
                                      "• Fortalecer a persistência e o interesse na resolução de situações-problema.",
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
                    Nome = "Banco de Dados II",

                    AtribuicoesResponsabilidades = "• Implementar banco de dados.",

                    ValoresAtitudes = "• Incentivar a criatividade.\n" +
                                      "• Desenvolver a criticidade.\n" +
                                      "• Fortalecer a persistência e o interesse na resolução de situações-problema.",
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