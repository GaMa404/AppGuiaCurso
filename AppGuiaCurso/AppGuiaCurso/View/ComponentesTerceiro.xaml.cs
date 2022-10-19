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
                    Nome = "Programação Web III",

                    AtribuicoesResponsabilidades = "• Documentar, construir e manter sistemas de informação para web.",

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

        private async void Button_Clicked_Mob2(object sender, EventArgs e)
        {
            try
            {
                var c = new Componentes
                {
                    Nome = "Programação de Aplicativos Mobile II",

                    AtribuicoesResponsabilidades = "• Documentar, construir e manter sistemas de informação para plataformas móveis.",

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

        private async void Button_Clicked_IPS(object sender, EventArgs e)
        {
            try
            {
                var c = new Componentes
                {
                    Nome = "Internet, Protocolos e Segurança de Sistemas da Informação",

                    AtribuicoesResponsabilidades = "• Implementar rotinas de segurança da informação.\n" +
                                                   "• Utilizar protocolos de redes e internet para comunicação de dados.",

                    ValoresAtitudes = "• Incentivar comportamentos éticos.\n" +
                                      "• Promover ações que considerem o respeito às normas estabelecidas.\n" +
                                      "• Fortalecer a persistência e o interesse na resolução de situações-problema.",
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
                    Nome = "Planejamento e Desenvolvimento do Trabalho de Conclusão de Curso (TCC) em Desenvolvimento de Sistemas",

                    AtribuicoesResponsabilidades = "• Planejar e desenvolver projetos de sistemas computacionais.",

                    ValoresAtitudes = "• Estimular a organização.\n" +
                                      "• Incentivar comportamentos éticos.\n" +
                                      "• Responsabilizar-se pela produção, utilização e divulgação de informações.",
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
                    Nome = "Qualidade e Teste de Software",

                    AtribuicoesResponsabilidades = "• Testar softwares para melhoria da qualidade de sistemas.\n" +
                                                   "• Elaborar registros e planilhas de acompanhamento e controle das atividades.",

                    ValoresAtitudes = "• Desenvolver criticidade.\n" +
                                      "• Incentivar comportamentos éticos.\n" +
                                      "• Responsabilizar-se pela produção, utilização e divulgação de informações.",
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