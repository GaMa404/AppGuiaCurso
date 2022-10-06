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
                    Nome = "Programação Web I",

                    AtribuicoesResponsabilidades = "• Desenvolver sites para Web.",

                    ValoresAtitudes = "• Incentivar a criatividade." +
                                      "• Estimular a organização." +
                                      "• Estimular o interesse na resolução de situações - problema.",
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
                    Nome = "Análise e Projeto de Sistemas",

                    AtribuicoesResponsabilidades = "• Elaborar projetos de sistema de informação.",

                    ValoresAtitudes = "• Incentivar a criatividade." +
                                      "• Estimular a organização." +
                                      "• Estimular o interesse na resolução de situações - problema.",
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
                    Nome = "Técnicas de Programação e Algoritmo",

                    AtribuicoesResponsabilidades = "• Realizar versionamento no desenvolvimento de programas." +
                                                   "• Utilizar algoritmos em linguagem de programação,por meio de ambientes de desenvolvimento de acordo com as necessidades.",

                    ValoresAtitudes = "• Incentivar atitudes de autonomia." +
                                      "• Incentivar comportamentos éticos." +
                                      "• Estimular o interesse na resolução de situações - problema.",
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
                    Nome = "Fundamentos da Informática",

                    AtribuicoesResponsabilidades = "• Operar sistemas computacionais.",

                    ValoresAtitudes = "• Desenvolver a criticidade." +
                                      "• Incentivar comportamentos éticos." +
                                      "• Promover ações que considerem o respeito às normas estabelecidas.",
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
                    Nome = "Design Digital",

                    AtribuicoesResponsabilidades = "• Desenvolver elementos gráficos para aplicativos e sites.",

                    ValoresAtitudes = "• Incentivar a criatividade." +
                                      "• Respeitar as manifestações culturais de outros povos." +
                                      "• Estimular o interesse na resolução de situações - problema.",
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
                    Nome = "Banco de Dados I",

                    AtribuicoesResponsabilidades = "• Modelar banco de dados.",

                    ValoresAtitudes = "• Estimular a organização." +
                                      "• Estimular o interesse na resolução de situações - problema." +
                                      "• Promover ações que considerem o respeito às normas estabelecidas.",
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