using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json;

namespace oscarsFilmsAppFinalTomas
{
    public partial class Directors : ContentPage
    {
        void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            listView.ItemsSource = getGetDierctprs(e.NewTextValue);
        }



        IEnumerable<bestActressesInformationList> getGetDierctprs(string serachText = null) {

            var contacts = new List<bestActressesInformationList> {

                new bestActressesInformationList{Name="Guillermo del Toro" ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2017",nameOfFilm="ToroAward winner \tThe Shape of Water"},
                new bestActressesInformationList{Name="Damien Chazelle" ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2016",nameOfFilm="La La Land"},
                new bestActressesInformationList{Name="Alejandro G. Iñárritu" ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2015",nameOfFilm="The Revenant"},
                new bestActressesInformationList{Name=" Alejandro G. Iñárritu " ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2014",nameOfFilm="Birdman"},
                new bestActressesInformationList{Name="Alfonso Cuarón" ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2013",nameOfFilm="Gravity"},
                new bestActressesInformationList{Name="Ang Lee  " ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2012",nameOfFilm="Life of Pi  "},
                new bestActressesInformationList{Name="Michel Hazanavicius" ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2011",nameOfFilm="The artist"},
                new bestActressesInformationList{Name="Tom Hooper " ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2010",nameOfFilm="The Kings Speeech"},
                new bestActressesInformationList{Name="Kathryn Bigelow" ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2009",nameOfFilm="The hurt Locker"},
                new bestActressesInformationList{Name="Danny Boyle " ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2008",nameOfFilm="SlumDog Millionare"},
                new bestActressesInformationList{Name="Coen Brothers " ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2007",nameOfFilm="No Country For old men"},
                new bestActressesInformationList{Name=" Martin Scorsese" ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2006",nameOfFilm="The Departed"},
                new bestActressesInformationList{Name="Ang lee  " ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2005",nameOfFilm="Broke Back mountain"},
                new bestActressesInformationList{Name="Clint Eastwood  " ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2004",nameOfFilm="Million Dollar Baby"},
                new bestActressesInformationList{Name="Peter Jackson" ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2003",nameOfFilm="The Lord of the Rings:The return of the King "},
                new bestActressesInformationList{Name="Roman Polanski" ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2002",nameOfFilm="The Pianist"},
                new bestActressesInformationList{Name="Ron Howard " ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2001",nameOfFilm="A beautiful Mind"},
                new bestActressesInformationList{Name="Steven Soderbergh " ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2000",nameOfFilm="Traffic"},
            };

            if (String.IsNullOrWhiteSpace(serachText))
                return contacts;


            return contacts.Where(c => c.Name.StartsWith(serachText, StringComparison.Ordinal));



                }
        public Directors()
        {
            InitializeComponent();
            //populates the xaml list view with getGetDierctprs method

            listView.ItemsSource= getGetDierctprs();


        }



    }
}

