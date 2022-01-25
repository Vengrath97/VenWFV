using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VenWFV
{
    class Song : Artwork
    {
        string leadArtist;
        public string LeadArtist { get => leadArtist; set => leadArtist = value; }
        public Song(string title, string genre, string artist, string releaseYear, string leadArtist)
            : base(title, genre, artist, releaseYear)
        {
            LeadArtist = leadArtist;
            TypeName = "Song";
        }
        public override string[] GetItemData()
        {
            string[] ArtworkData = { "Song", this.Title, this.Genre, this.Artist, this.ReleaseYear, this.LeadArtist };
            return ArtworkData;
        }
    }
}
