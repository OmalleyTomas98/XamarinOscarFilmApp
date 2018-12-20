using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace oscarsFilmsAppFinalTomas
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        //event button handler 
        private void btnLogin_Clicked(object sender, EventArgs e)
        {

            //stores user username and password 
          bool isUser, isPwd;
            //wraps the password and username into string if they arent empty
            isUser = String.IsNullOrEmpty(entUser.Text);
            isPwd = String.IsNullOrEmpty(entPassword.Text);

            if (isUser || isPwd)
            {
            }

            else
            {
                //user has entered password and username they will navigate to the newFilms page

                Navigation.PushAsync(new newFilms());
            }

        } //end login clicked

    }
}