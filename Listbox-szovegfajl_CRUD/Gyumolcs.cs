using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listbox_szovegfajl_CRUD
{
    internal class Gyumolcs
    {
        ulong termekkod;
        string nev;
        int mennyiseg;

        public ulong Termekkod { get => termekkod; set => termekkod = value; }
        public string Nev { get => nev; set => nev = value; }
        public int Mennyiseg { get => mennyiseg; set => mennyiseg = value; }

        public Gyumolcs(ulong id, string nev, int mennyiseg)
        {
            Termekkod = termekkod;
            Nev = nev;
            Mennyiseg = mennyiseg;
        }
        public override string ToString()
        {
            return $"{this.termekkod} - {this.nev} - {this.mennyiseg}";
        }
        public string toTxt()
        {
            return $"{this.termekkod} - {this.nev} - {this.mennyiseg}";
        }
    }
}
