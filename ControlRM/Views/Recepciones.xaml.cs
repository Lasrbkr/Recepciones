#region Referencias
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
#endregion
namespace ControlRM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Recepciones : ContentPage
    {
        #region Variables
        DatosRecepciones datosrecepciones = new DatosRecepciones();
        #endregion
        #region Constructor
        public Recepciones()
        {
            InitializeComponent();
            Appearing += Recepciones_Appearing;
            listView.Refreshing += ListView_Refreshing;
        }
        #endregion
        #region Eventos
        #region Window
        async void Recepciones_Appearing(object sender, EventArgs e)
        {
            listView.IsRefreshing = true;
            await cargarRecepciones();
        }
        #endregion
        #region Click
        void Nuevo_Clicked(object sender, EventArgs e)
        {
            Recepcion recepcion = new Recepcion();
            Navigation.PushModalAsync(recepcion, true);
        }
        #endregion
        #region Loading
        async void ListView_Refreshing(object sender, EventArgs e)
        {
            await cargarRecepciones();
        }
        #endregion
        #endregion
        #region Metodos
        private async Task cargarRecepciones()
        {
            List<RecepcionesModel> lista = new List<RecepcionesModel>();
            lista = await datosrecepciones.SP_CargarListaRecepciones();
            listView.ItemsSource = lista.OrderByDescending(i => i.Fecha.iso);
            listView.IsRefreshing = false;
        }
        #endregion
    }
}
