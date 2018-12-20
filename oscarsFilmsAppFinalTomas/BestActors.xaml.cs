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
    public partial class BestActors : ContentPage
    {
        //event handler 
        void Handle_TextChangedACTORS(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            //collects the bestActor Info and filters by name
            listView.ItemsSource = getBestActors(e.NewTextValue);
        }

        //create list and initliaze te information beig stored
        IEnumerable<bestActorsInfo> getBestActors(string serachText = null)
        {
            //create list and initliaze te information beig stored

            var contacts = new List<bestActorsInfo> {

                //names ,images , information to be dipslayed withi the bestActors Xaml
                new bestActorsInfo{Name="Gary Oldman" ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2017",nameOfFilm="Darkest Hour"},
                new bestActorsInfo{Name="Casey Affleck" ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2016",nameOfFilm="Manchester by the Sea"},
                new bestActorsInfo{Name="Leonardo DiCaprio " ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2015",nameOfFilm="The Revenant"},
                new bestActorsInfo{Name="Eddie Redmayne  " ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2014",nameOfFilm="The Theory of Everything"},
                new bestActorsInfo{Name="Matthew McConaughey" ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2013",nameOfFilm="Dallas Buyers Club "},
                new bestActorsInfo{Name="Daniel Day-Lewis   " ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2012",nameOfFilm="Lincoln "},
                new bestActorsInfo{Name="Jean Dujardin" ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2011",nameOfFilm="The artist"},
                new bestActorsInfo{Name="Colin Firth " ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2010",nameOfFilm="The Kings Speeech"},
                new bestActorsInfo{Name="Jeff Bridges " ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2009",nameOfFilm="Crazy Heart"},
                new bestActorsInfo{Name="Sean Penn " ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2008",nameOfFilm="Milk"},
                new bestActorsInfo{Name="Daniel Day-Lewis " ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2007",nameOfFilm="No Country For old men"},
                new bestActorsInfo{Name="Forest Whitaker" ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2006",nameOfFilm="The Last king of Scotland"},
                new bestActorsInfo{Name="Philip Seymour Hoffman" ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2005",nameOfFilm="Capote"},
                new bestActorsInfo{Name="Jamie Foxx  " ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2004",nameOfFilm="Ray"},
                new bestActorsInfo{Name="Sean Penn" ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.pngg" , yearOfOscar="2003",nameOfFilm="Mystic River "}
                ,new bestActorsInfo{Name="Adrian Brody" ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2002",nameOfFilm="The Pianist"},
                new bestActorsInfo{Name="Denzel Washington  " ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2001",nameOfFilm="Training Day"},
                new bestActorsInfo{Name="Russell Crowe " ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2000",nameOfFilm="Gladiator"},
            };

            //if else return all content if the bar is populated with text
            if (String.IsNullOrWhiteSpace(serachText))
                return contacts;

            //if else return all content if the bar is populated with text

            return contacts.Where(c => c.Name.StartsWith(serachText, StringComparison.Ordinal));
        }
        public BestActors()
        {
            InitializeComponent();
            //initialize listview with method getActors
            listView.ItemsSource = getBestActors();
        }
    }
}

