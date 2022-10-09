using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    public class ArtistName
    {
        public ArtistName(string[] arraystr)
        {
            SongException = arraystr;
            Artistname = arraystr[0];
        }
        private string[] SongException {
            set
            {
                if (value == null || value.Length != 3)
                {
                    throw new ArgumentException("Invalid song.");
                }
                else
                {
                    return;
                }
            }
        }
        private string artistname;
        public string Artistname
        {
            get
            {
                return this.artistname;
            }
            set
            {
                if (value.Length<3||value.Length>20)
                {
                    throw new ArgumentException("Artist name should be between 3 and 20 symbols.");
                }
                else
                {
                    this.artistname = value;
                }
            }
        }
    }
}
