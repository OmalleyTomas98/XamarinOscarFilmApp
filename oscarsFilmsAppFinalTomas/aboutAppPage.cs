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
    public partial class aboutAppPage : ContentPage
    {
        public aboutAppPage()
        {
            InitializeComponent();
        }
        //When pressed navigates the user to the Best Pictures Section
        private void bestPictureButton_Clicked(object sender, EventArgs e)
        {

            //Pushes the user yto page
            Navigation.PushAsync(new BestPictures());
        }

        //When pressed navigates the user to the Best Actor Section

        void bestActorButton_Clicked(object sender, EventArgs e)
        {
            //Pushes the user actor page

            Navigation.PushAsync(new BestActors());
        }
        //When pressed navigates the user to the Best Actress Section

        void bestActressesButton_Clicked(object sender, EventArgs e)
        {
            //Pushes the user yto page

            Navigation.PushAsync(new BestActress());
        }

    }
}


   
