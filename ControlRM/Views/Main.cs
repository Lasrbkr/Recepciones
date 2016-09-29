using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControlRM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Main : MasterDetailPage
    {
        #region Variables

        #endregion
        #region Constructor
        public Main()
        {
            InitializeComponent();
            masterPage.ListView.ItemSelected += ListView_ItemSelected;
        }
        #endregion
        #region Eventos
        void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(((MasterPageItems)e.SelectedItem).TargetType)) 
                { 
                    BarBackgroundColor = (Color)Application.Current.Resources["DarkBlueColor"] 
                };
            }

            masterPage.ListView.SelectedItem = null;
        }
        #endregion
    }
}
