using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    public class Kontinent
    {
        private int kontNr;
        private string kontName;
        private string kontLoc;
        private string kontDesc;

        public int KontNr { get => kontNr; set => kontNr = value; }
        public string KontName { get => kontName; set => kontName = value; }
        public string KontLoc { get => kontLoc; set => kontLoc = value; }
        public string KontDesc { get => kontDesc; set => kontDesc = value; }

        public Kontinent (int knr, string kn, string kl, string kd)
        {
            KontNr = knr;
            KontName = kn;
            KontLoc = kl;
            KontDesc = kd;
        }

    }
}
