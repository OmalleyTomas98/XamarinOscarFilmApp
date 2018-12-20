using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace oscarsFilmsAppFinalTomas
{
    public partial class BestPictures : ContentPage
    {
        //button event handler  popoulates the  getBestPicture method
        void Handle_TextChangedBestPictures(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {   //button event handler  popoulates the  getBestPicture method
            listView.ItemsSource = getBestPicture(e.NewTextValue);
        }
       // IEnumerable return the name of the list item instead of the location
        IEnumerable<bestPicturesInfoList> getBestPicture(string serachText = null)
        {
            //a new instance of list named  bestPicturesInfoList
            var contacts = new List<bestPicturesInfoList> {
                //All the data stored for data binding in the Best Picture List
                new bestPicturesInfoList{ Name="The Shape of Water"} ,                 new bestPicturesInfoList{ Name="Moonlight"} ,                 new bestPicturesInfoList{ Name="Spotlight"} ,                 new bestPicturesInfoList{ Name="Birdman"} ,                 new bestPicturesInfoList{ Name="12 Years a Slave"} ,                 new bestPicturesInfoList{ Name="Argo"} ,                 new bestPicturesInfoList{ Name="The Artist "} ,                 new bestPicturesInfoList{ Name="The King's Speech"} ,                 new bestPicturesInfoList{ Name="The Hurt Locker"} ,                 new bestPicturesInfoList{ Name="Slumdog Millionaire"} ,                 new bestPicturesInfoList{ Name="No Country for Old Men"} ,                 new bestPicturesInfoList{ Name="The Departed "} ,                 new bestPicturesInfoList{ Name="Crash"} ,                 new bestPicturesInfoList{ Name="Million Dollar Baby"} ,                 new bestPicturesInfoList{ Name="The Lord of the Rings: The Return of the King"} ,                 new bestPicturesInfoList{ Name="Chicago "} ,                 new bestPicturesInfoList{ Name=" Beautiful Mind"} ,                 new bestPicturesInfoList{ Name="Gladiator "} ,                 new bestPicturesInfoList{ Name="American Beauty "} ,                 new bestPicturesInfoList{ Name="Shakespeare in Love "} ,                 new bestPicturesInfoList{ Name="Titanic  "} ,                 new bestPicturesInfoList{ Name="The English Patient "} ,                 new bestPicturesInfoList{ Name="Braveheart "} ,                 new bestPicturesInfoList{ Name="Forrest Gump "} ,                 new bestPicturesInfoList{ Name="Schindler's List "} ,                 new bestPicturesInfoList{ Name="Unforgiven "} ,                 new bestPicturesInfoList{ Name="The Silence of the Lambs "} ,                 new bestPicturesInfoList{ Name="Dances with Wolves "} ,                 new bestPicturesInfoList{ Name="Driving Miss Daisy "} ,                 new bestPicturesInfoList{ Name="Rain Man "} ,                 new bestPicturesInfoList{ Name="The Last Emperor "} ,                 new bestPicturesInfoList{ Name="Platoon "} ,                 new bestPicturesInfoList{ Name="Out of Africa "} ,                 new bestPicturesInfoList{ Name="Amadeus "} ,                 new bestPicturesInfoList{ Name="Terms of Endearment "} ,                 new bestPicturesInfoList{ Name="Gandhi "} ,                 new bestPicturesInfoList{ Name="Chariots of Fire "} ,                 new bestPicturesInfoList{ Name="Ordinary People "} ,                 new bestPicturesInfoList{ Name="Kramer vs. Kramer "} ,                 new bestPicturesInfoList{ Name="The Deer Hunter "} ,                 new bestPicturesInfoList{ Name="Annie Hall "} ,                 new bestPicturesInfoList{ Name="Rocky "} ,                 new bestPicturesInfoList{ Name="Unforgiven "} ,                 new bestPicturesInfoList{ Name="Unforgiven "} ,                 new bestPicturesInfoList{ Name="Unforgiven "} ,                 new bestPicturesInfoList{ Name="Platoon "} ,                 new bestPicturesInfoList{ Name="Unforgiven "} ,                 new bestPicturesInfoList{ Name="Amadeus "} ,                 new bestPicturesInfoList{ Name="One Flew Over the Cuckoo's Nest "} ,                 new bestPicturesInfoList{ Name="The Godfather Part II "} ,                 new bestPicturesInfoList{ Name="The Sting "} ,                 new bestPicturesInfoList{ Name="The Godfather "} ,                 new bestPicturesInfoList{ Name="The French Connection "} ,                 new bestPicturesInfoList{ Name="Patton "} ,                 new bestPicturesInfoList{ Name="Midnight Cowboy "} ,                 new bestPicturesInfoList{ Name="Oliver!"} ,             };
            //logical expression the list will return users search text if there is 
            if (String.IsNullOrWhiteSpace(serachText))
                return contacts;

            //returns all contacts 
            return contacts.Where(c => c.Name.StartsWith(serachText, StringComparison.Ordinal));

        }
        public BestPictures()
        {
            InitializeComponent();
            //populates the xaml list view with bestpicture method
            listView.ItemsSource = getBestPicture();
        }
    }
}


