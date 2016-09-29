#region Referencias
using System;
using System.Collections.Generic;
using Acr.UserDialogs;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
#endregion
namespace ControlRM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Recepcion : ContentPage
    {
        #region Variables
        DatosRecepciones datosrecepciones = new DatosRecepciones();
        #endregion
        #region Constructor
        public Recepcion()
        {
            InitializeComponent();
            btnCancelar.Clicked += BtnCancelar_Clicked;
            btnGuardar.Clicked += BtnGuardar_Clicked;
        }
        #endregion
        #region Eventos
        async void BtnGuardar_Clicked(object sender, EventArgs e)
        {
            UserDialogs.Instance.ShowLoading("Guardando", MaskType.Gradient);
            RecepcionesModel recepcion = new RecepcionesModel();
            recepcion.Nombre = "Prueba de Insert";
            recepcion.Fecha = new Fecha { iso = DateTime.Now, __type = "Date" };
            recepcion.Animal = "D-32412-SD";
            recepcion.Concepto = "M";
            recepcion.Kilos = 150;
            recepcion.Vale = "N39393";
            recepcion.Chofer = "Luis Salas";
            recepcion.KilosEntrada = 0;
            recepcion.KilosSalida = 0;
            recepcion.Consecutivo = 3;
            recepcion.APagar = 0;
            recepcion.Observaciones = "Registro de prueba nuevo";
            recepcion.Sirve = true;
            if (await datosrecepciones.SP_InsertarRecepciones(recepcion))
            {
                UserDialogs.Instance.HideLoading();
                UserDialogs.Instance.ShowSuccess(recepcion.objectId, 2000);
                Navigation.PopModalAsync(true);
            }
            else
            {
                UserDialogs.Instance.HideLoading();
                UserDialogs.Instance.ShowSuccess("Error al guardar", 2000);
            }
        }
        void BtnCancelar_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync(true);
        }
        #endregion

    }
}
