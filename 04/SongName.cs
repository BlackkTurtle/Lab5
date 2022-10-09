using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    public class SongName:ArtistName
    {
        public SongName(string[] arraystr) : base(arraystr)
        {
            Songname = arraystr[1];
        }
        private string songname;
        public string Songname {
            get { return songname; }
            set {
                if (value.Length < 3 || value.Length > 30)
                {
                    throw new ArgumentException("Artist name should be between 3 and 30 symbols.");
                }
                else
                {
                    this.songname = value;
                }
            }
        }
    }
}
