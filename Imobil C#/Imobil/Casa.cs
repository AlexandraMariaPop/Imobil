using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imobil
{
    class Casa: Imobil
    {
        public int nr_camere;
        public int etaje;
        public string curte;
        public Casa(Proprietar proprietar, string locatie, int dimensiune, Poza poze, int nr_camere, int etaje,string curte) : base(proprietar, locatie, dimensiune, poze)
        {
            this.nr_camere = nr_camere;
            this.etaje = etaje;
            this.curte = curte;
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
        public int Etaje
        {
            get
            {
                return etaje;
            }
            set
            {
                etaje = value;
            }
        }
        public string Curte
        {
            get
            {
                return curte;
            }
            set
            {
                curte = value;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("~~CASA~~");
            sb.AppendLine($"PROPRIETAR: {proprietar}");
            sb.AppendLine($"LOCATIE: {locatie}");
            sb.AppendLine($"DIMENSIUNE: {dimensiune}");
            sb.AppendLine($"POZE: {poze}");
            sb.AppendLine($"NUMAR DE CAMERE : {nr_camere}");
            sb.AppendLine($"ETAJE : {etaje}");
            sb.AppendLine($"CURTE: {curte}");
            return sb.ToString();
        }
    }
}
