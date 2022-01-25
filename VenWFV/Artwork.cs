using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VenWFV
{
    class Artwork
    {
        string typeName;
        string title;
        string genre;
        string artist;
        string releaseYear;

        public string Title { get => title; set => title = value; }
        public string Genre { get => genre; set => genre = value; }
        public string Artist { get => artist; set => artist = value; }
        public string ReleaseYear { get => releaseYear; set => releaseYear = value; }
        public string TypeName { get => typeName; set => typeName = value; }

        public Artwork()
        {
            Title = title;
            Genre = genre;
            Artist = artist;
            ReleaseYear = releaseYear;
            TypeName = "Undefined Artwork";
        }
        public Artwork(string title, string genre, string artist, string releaseYear)
        {
            Title = title;
            Genre = genre;
            Artist = artist;
            ReleaseYear = releaseYear;
            TypeName = "Undefined Artwork";
        }
        public Artwork(string title, string genre, string artist, string releaseYear, string leadActor)
        {
            Title = title;
            Genre = genre;
            Artist = artist;
            ReleaseYear = releaseYear;
            TypeName = "Undefined Artwork";
        }
        public virtual string[] GetItemData()
        {
            string[] ArtworkData = { "Undefined Artwork", this.Title, this.Genre, this.Artist, this.ReleaseYear};
            return ArtworkData;
        }
    }
}
