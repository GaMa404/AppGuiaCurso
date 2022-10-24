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

                    CaminhoImagem = "AppGuiaCurso.Imagens.SegundoAno.ProWebII.Captura de tela 2022-10-20 155132.png",
                    CaminhoImagem2 = "AppGuiaCurso.Imagens.SegundoAno.ProWebII.Captura de tela 2022-10-20 155148.png",
                    CaminhoImagem3 = "AppGuiaCurso.Imagens.SegundoAno.ProWebII.Captura de tela 2022-10-20 155210.png",
                    CaminhoImagem4 = "AppGuiaCurso.Imagens.SegundoAno.ProWebII.Captura de tela 2022-10-20 155314.png",
                    CaminhoImagem5 = "AppGuiaCurso.Imagens.SegundoAno.ProWebII.Captura de tela 2022-10-24 091311.png",
                    CaminhoImagem6 = "AppGuiaCurso.Imagens.SegundoAno.ProWebII.Captura de tela 2022-10-24 091354.png",
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

                    CaminhoImagem = "AppGuiaCurso.Imagens.SegundoAno.MobileI.WhatsApp Image 2022-10-24 at 08.26.42.jpeg",
                    CaminhoImagem2 = "AppGuiaCurso.Imagens.SegundoAno.MobileI.WhatsApp Image 2022-10-24 at 08.26.43 (1).jpeg",
                    CaminhoImagem3 = "AppGuiaCurso.Imagens.SegundoAno.MobileI.WhatsApp Image 2022-10-24 at 08.26.43.jpeg",
                    CaminhoImagem4 = "AppGuiaCurso.Imagens.SegundoAno.MobileI.WhatsApp Image 2022-10-24 at 08.26.44 (1).jpeg",
                    CaminhoImagem5 = "AppGuiaCurso.Imagens.SegundoAno.MobileI.WhatsApp Image 2022-10-24 at 08.26.44.jpeg",
                  //CaminhoImagem6 = "AppGuiaCurso.Imagens.SegundoAno.MobileI.",
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

                    CaminhoImagem = "AppGuiaCurso.Imagens.SegundoAno.DS.Captura de tela 2022-10-24 092459.png",
                    CaminhoImagem2 = "AppGuiaCurso.Imagens.SegundoAno.DS.Captura de tela 2022-10-24 092829.png",
                    CaminhoImagem3 = "AppGuiaCurso.Imagens.SegundoAno.DS.Captura de tela 2022-10-24 092905.png",
                    CaminhoImagem4 = "AppGuiaCurso.Imagens.SegundoAno.DS.Captura de tela 2022-10-24 093003.png",
                  //CaminhoImagem5 = "AppGuiaCurso.Imagens.SegundoAno.DS.",
                  //CaminhoImagem6 = "AppGuiaCurso.Imagens.SegundoAno.DS.",
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

                    CaminhoImagem = "AppGuiaCurso.Imagens.SegundoAno.Embarcados.Captura de tela 2022-10-24 090805.png",
                    CaminhoImagem2 = "AppGuiaCurso.Imagens.SegundoAno.Embarcados.Captura de tela 2022-10-24 090838.png",
                    CaminhoImagem3 = "AppGuiaCurso.Imagens.SegundoAno.Embarcados.Captura de tela 2022-10-24 090850.png",
                  //CaminhoImagem4 = "AppGuiaCurso.Imagens.SegundoAno.Embarcados.",
                  //CaminhoImagem5 = "AppGuiaCurso.Imagens.SegundoAno.Embarcados.",
                  //CaminhoImagem6 = "AppGuiaCurso.Imagens.SegundoAno.Embarcados.",
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

                    CaminhoImagem = "AppGuiaCurso.Imagens.SegundoAno.BancoII.Captura de tela 2022-10-24 091720.png",
                    CaminhoImagem2 = "AppGuiaCurso.Imagens.SegundoAno.BancoII.Captura de tela 2022-10-24 091829.png",
                    CaminhoImagem3 = "AppGuiaCurso.Imagens.SegundoAno.BancoII.Captura de tela 2022-10-24 092231.png",
                    CaminhoImagem4 = "AppGuiaCurso.Imagens.SegundoAno.BancoII.Captura de tela 2022-10-24 092257.png",
                  //CaminhoImagem5 = "AppGuiaCurso.Imagens.SegundoAno.BancoII.",
                  //CaminhoImagem6 = "AppGuiaCurso.Imagens.SegundoAno.BancoII.",
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