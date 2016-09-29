#region Referencias
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
#endregion
namespace ControlRM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : ContentPage
    {
        #region Variables
        public ListView ListView { get { return listView; } }
        List<MasterPageItems> listaItems = new List<MasterPageItems>();
        #endregion
        #region Constructor
        public MasterPage()
        {
            InitializeComponent();

            listaItems.Clear();
            listaItems.Add(new MasterPageItems { Titulo = "Recepciones", IconSource = "recepciones.png", TargetType = typeof(Recepciones) });
            listaItems.Add(new MasterPageItems { Titulo = "Refrigeración", IconSource = "recepciones.png", TargetType = typeof(Refrigeraciones) });
            listaItems.Add(new MasterPageItems { Titulo = "Clorinación del Agua", IconSource = "recepciones.png", TargetType = typeof(Recepciones) });
            listView.ItemsSource = listaItems;
        }
        #endregion

    }
}
