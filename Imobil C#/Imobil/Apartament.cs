using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imobil
{
    class Apartament: Imobil
    {
        public int nr_camere;
        public int etaj;
        public bool loc_de_parcare;
        public Apartament(Proprietar proprietar, string locatie, int dimensiune, Poza poze,int nr_camere, int etaj,bool loc_de_parcare): base(proprietar,locatie,dimensiune,poze)
        {
            this.nr_camere = nr_camere;
            this.etaj = etaj;
            this.loc_de_parcare = loc_de_parcare;
        }
        public int Numar_De_Camere
        {
            get
            {
                return nr_camere;
            }
            set
            {
                nr_camere = value;
            }
        }
        public int Etaj
        {
            get
            {
                return etaj;
            }
            set
            {
                etaj = value;
            }
        }
        public bool LocDeParcare
        {
            get
            {
                return loc_de_parcare;
            }
            set
            {
                loc_de_parcare = value;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("~~APARTAMENT~~");
            sb.AppendLine($"PROPRIETAR: {proprietar}");
            sb.AppendLine($"LOCATIE: {locatie}");
            sb.AppendLine($"DIMENSIUNE: {dimensiune}");
            sb.AppendLine($"POZE: {poze}");
            sb.AppendLine($"NUMAR DE CAMERE : {nr_camere}");
            sb.AppendLine($"ETAJ : {etaj}");
            sb.AppendLine($"LOC DE PARCARE : {loc_de_parcare}");
            return sb.ToString();
        }
    }
}
