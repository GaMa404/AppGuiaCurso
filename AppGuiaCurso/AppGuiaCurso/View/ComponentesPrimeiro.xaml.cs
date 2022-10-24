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

                    ValoresAtitudes = "• Incentivar a criatividade.\n" +
                                      "• Estimular a organização.\n" +
                                      "• Estimular o interesse na resolução de situações - problema.",

                    CaminhoImagem = "AppGuiaCurso.Imagens.PrimeiroAno.ProWebI.Captura de tela 2022-10-20 150632.png",
                    CaminhoImagem2 = "AppGuiaCurso.Imagens.PrimeiroAno.ProWebI.Captura de tela 2022-10-20 150756.png",
                    CaminhoImagem3 = "AppGuiaCurso.Imagens.PrimeiroAno.ProWebI.Captura de tela 2022-10-20 150818.png",
                    CaminhoImagem4 = "AppGuiaCurso.Imagens.PrimeiroAno.ProWebI.Captura de tela 2022-10-20 150901.png",
                    //CaminhoImagem5 = "AppGuiaCurso.Imagens.PrimeiroAno.ProWebI.",
                    //CaminhoImagem6 = "AppGuiaCurso.Imagens.PrimeiroAno.ProWebI.",
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

                    ValoresAtitudes = "• Incentivar a criatividade.\n" +
                                      "• Estimular a organização.\n" +
                                      "• Estimular o interesse na resolução de situações - problema.",

                    CaminhoImagem = "AppGuiaCurso.Imagens.PrimeiroAno.Analise.Captura de tela 2022-10-20 152844.png",
                    CaminhoImagem2 = "AppGuiaCurso.Imagens.PrimeiroAno.Analise.Captura de tela 2022-10-20 152919.png",
                    CaminhoImagem3 = "AppGuiaCurso.Imagens.PrimeiroAno.Analise.Captura de tela 2022-10-20 152944.png",
                    CaminhoImagem4 = "AppGuiaCurso.Imagens.PrimeiroAno.Analise.Captura de tela 2022-10-20 152955.png",
                    CaminhoImagem5 = "AppGuiaCurso.Imagens.PrimeiroAno.Analise.Fluxograma Matrícula.png",
                    CaminhoImagem6 = "AppGuiaCurso.Imagens.PrimeiroAno.Analise.WhatsApp Image 2022-10-20 at 15.27.22.jpeg",
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

                    AtribuicoesResponsabilidades = "• Realizar versionamento no desenvolvimento de programas.\n" +
                                                   "• Utilizar algoritmos em linguagem de programação, por meio de ambientes de desenvolvimento de acordo com as necessidades.",

                    ValoresAtitudes = "• Incentivar atitudes de autonomia.\n" +
                                      "• Incentivar comportamentos éticos.\n" +
                                      "• Estimular o interesse na resolução de situações - problema.",

                    CaminhoImagem = "AppGuiaCurso.Imagens.PrimeiroAno.Algoritmo.Captura de tela 2022-10-20 151650.png",
                    CaminhoImagem2 = "AppGuiaCurso.Imagens.PrimeiroAno.Algoritmo.Captura de tela 2022-10-20 151725.png",
                    CaminhoImagem3 = "AppGuiaCurso.Imagens.PrimeiroAno.Algoritmo.Captura de tela 2022-10-20 151740.png",
                    //CaminhoImagem4 = "AppGuiaCurso.Imagens.PrimeiroAno.Algoritmo.",
                    //CaminhoImagem5 = "AppGuiaCurso.Imagens.PrimeiroAno.Algoritmo.",
                    //CaminhoImagem6 = "AppGuiaCurso.Imagens.PrimeiroAno.Algoritmo.",
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

                    ValoresAtitudes = "• Desenvolver a criticidade.\n" +
                                      "• Incentivar comportamentos éticos.\n" +
                                      "• Promover ações que considerem o respeito às normas estabelecidas.",

                    CaminhoImagem = "AppGuiaCurso.Imagens.PrimeiroAno.Fundamentos.Captura de tela 2022-10-20 153108.png",
                    CaminhoImagem2 = "AppGuiaCurso.Imagens.PrimeiroAno.Fundamentos.Captura de tela 2022-10-20 153108.png",
                    CaminhoImagem3 = "AppGuiaCurso.Imagens.PrimeiroAno.Fundamentos.Captura de tela 2022-10-20 153108.png",
                    //CaminhoImagem4 = "AppGuiaCurso.Imagens.PrimeiroAno.Fundamentos.",
                    //CaminhoImagem5 = "AppGuiaCurso.Imagens.PrimeiroAno.Fundamentos.",
                    //CaminhoImagem6 = "AppGuiaCurso.Imagens.PrimeiroAno.Fundamentos.",
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

                    ValoresAtitudes = "• Incentivar a criatividade.\n" +
                                      "• Respeitar as manifestações culturais de outros povos.\n" +
                                      "• Estimular o interesse na resolução de situações - problema.",

                    CaminhoImagem = "AppGuiaCurso.Imagens.PrimeiroAno.Design.Lamborghini.gif",
                    CaminhoImagem2 = "AppGuiaCurso.Imagens.PrimeiroAno.Design.LamborghiniCartão2.png",
                    CaminhoImagem3 = "AppGuiaCurso.Imagens.PrimeiroAno.Design.logo metally.png",
                    CaminhoImagem4 = "AppGuiaCurso.Imagens.PrimeiroAno.Design.Rede De Display - Anúncio em Vídeo.png",
                    //CaminhoImagem5 = "AppGuiaCurso.Imagens.PrimeiroAno.Design.",
                    //CaminhoImagem6 = "AppGuiaCurso.Imagens.PrimeiroAno.Design.",
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

                    ValoresAtitudes = "• Estimular a organização.\n" +
                                      "• Estimular o interesse na resolução de situações - problema.\n" +
                                      "• Promover ações que considerem o respeito às normas estabelecidas.",

                    CaminhoImagem = "AppGuiaCurso.Imagens.PrimeiroAno.BancoI.Captura de tela 2022-10-20 153821.png",
                    CaminhoImagem2 = "AppGuiaCurso.Imagens.PrimeiroAno.BancoI.Captura de tela 2022-10-20 153920.png",
                    CaminhoImagem3 = "AppGuiaCurso.Imagens.PrimeiroAno.BancoI.Captura de tela 2022-10-20 153936.png",
                    CaminhoImagem4 = "AppGuiaCurso.Imagens.PrimeiroAno.BancoI.Captura de tela 2022-10-20 154001.png",
                    CaminhoImagem5 = "AppGuiaCurso.Imagens.PrimeiroAno.BancoI.Captura de tela 2022-10-20 154723.png",
                    //CaminhoImagem6 = "AppGuiaCurso.Imagens.PrimeiroAno.BancoI.",
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