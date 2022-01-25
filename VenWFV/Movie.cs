using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VenWFV
{
    class Movie : Artwork
    {
        string leadArtist;
        public string LeadArtist { get => leadArtist; set => leadArtist = value; }
        public Movie(string title, string genre, string artist, string releaseYear, string leadArtist)
            : base(title, genre, artist, releaseYear)
        {
            LeadArtist = leadArtist;
            TypeName = "Undefined Artwork";
        }
        public override string[] GetItemData()
        {
            string[] ArtworkData = { "Movie", this.Title, this.Genre, this.Artist, this.ReleaseYear, this.LeadArtist};
            return ArtworkData;
        }
    }
}
