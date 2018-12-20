using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace oscarsFilmsAppFinalTomas
{
    public partial class BestActress : ContentPage
    {
        public BestActress()
        {
            //create list and initliaze te information beig stored

            listView.ItemsSource = new List<bestActressesInformationList>
            {
                new bestActressesInformationList{Name="Frances McDormand" ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2017",nameOfFilm="Three Billboards Outside Ebbing, Missouri"},
                new bestActressesInformationList{Name="Emma Stone" ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2016",nameOfFilm="La La Land"},
                new bestActressesInformationList{Name="Brie Larson" ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2015",nameOfFilm="Room"},
                new bestActressesInformationList{Name="Julianne Moore " ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2014",nameOfFilm="Still Alice"},
                new bestActressesInformationList{Name="Cate Blanchett " ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2013",nameOfFilm="Blue Jasmine"},
                new bestActressesInformationList{Name="Jennifer Lawrence  " ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2012",nameOfFilm="Silver Linings Playbook"},
                new bestActressesInformationList{Name="Meryl Streep  " ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2011",nameOfFilm="The Iron Lady"},
                new bestActressesInformationList{Name="Natalie Portman  " ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2010",nameOfFilm="Black Swan"},
                new bestActressesInformationList{Name="Sandra Bullock" ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2009",nameOfFilm="The Blind Side"},
                new bestActressesInformationList{Name="Kate Winslet " ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2008",nameOfFilm="The Reader"},
                new bestActressesInformationList{Name="Marion Cotillard " ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2007",nameOfFilm="La Vie en Rose"},
                new bestActressesInformationList{Name="Helen Mirren " ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2006",nameOfFilm="The Queen"},
                new bestActressesInformationList{Name="Reese Witherspoon " ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2005",nameOfFilm="Walk the Line"},
                new bestActressesInformationList{Name="Hilary Swank  " ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2004",nameOfFilm="Million Dollar Baby"},
                new bestActressesInformationList{Name="Charlize Theron" ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2003",nameOfFilm="Monster"},
                new bestActressesInformationList{Name="Nicole Kidman" ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2002",nameOfFilm="The Hours"},
                new bestActressesInformationList{Name="Halle Berry " ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2001",nameOfFilm="Monster's Ball"},
                new bestActressesInformationList{Name="Julia Roberts " ,ImageUrl="/Users/tomasomalley/Projects/oscarsFilmsAppFinalTomas/oscarsFilmsAppFinalTomas/photos/oscarTrophy.png" , yearOfOscar="2000",nameOfFilm="Erin Brockovich"},
            };
        }
    }
}
