using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;




namespace oscarsFilmsAppFinalTomas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class newFilms : TabbedPage
    {
        public newFilms()
        {
            InitializeComponent();
        }
        //event handler button opens newFilms page when entered
        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
          
            {
                // opens newFilms page when entered

                Navigation.PushAsync(new  newFilms());
            }
        } 
    }
}