using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imobil
{
    class Teren: Imobil
    {
        public Teren(Proprietar proprietar, string locatie, int dimensiune, Poza poze): base(proprietar,locatie,dimensiune,poze)
        {

        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("~~TEREN~~");
            sb.AppendLine($"PROPRIETAR: {proprietar}");
            sb.AppendLine($"LOCATIE: {locatie}");
            sb.AppendLine($"DIMENSIUNE: {dimensiune}");
            sb.AppendLine($"POZE: {poze}");
            return sb.ToString();
        }
    }
}
