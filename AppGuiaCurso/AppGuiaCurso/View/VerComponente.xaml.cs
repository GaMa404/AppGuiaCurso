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
    public partial class VerComponente : ContentPage
    {
        public VerComponente(Componentes c)
        {
            InitializeComponent();
            BindingContext = c;

            imagem1.Source = ImageSource.FromResource(c.CaminhoImagem);
            imagem2.Source = ImageSource.FromResource(c.CaminhoImagem2);
            imagem3.Source = ImageSource.FromResource(c.CaminhoImagem3);
            imagem4.Source = ImageSource.FromResource(c.CaminhoImagem4);
            imagem5.Source = ImageSource.FromResource(c.CaminhoImagem5);
            imagem6.Source = ImageSource.FromResource(c.CaminhoImagem6);
        }
    }
}