using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Imobil
{
    class Imobil
    {
        public Proprietar proprietar;
        public string locatie;
        public int dimensiune;
        public Poza poze;
        public Agent agent;
        public Client clientpotential; 

        public Imobil(Proprietar proprietar,string locatie,int dimensiune,Poza poze)
        {
            this.proprietar = proprietar;
            this.locatie = locatie;
            this.dimensiune = dimensiune;
            this.poze = poze;
        }
        public Proprietar PROPRIETAR
        {
            get
            {
                return proprietar;
            }
            set
            {
                proprietar = value;
            }
        }
        public string Locatie
        {
            get
            {
                return locatie;
            }
            set
            {
                locatie = value;
            }
        }
        public int Dimensiune
        {
            get
            {
                return dimensiune;
            }
            set
            {
                dimensiune = value;
            }
        }
        public Poza Poze
        {
            get
            {
                return poze;
            }
            set
            {
                poze = value;
            }
        }
        public Agent AsignareAgent
        {
            get
            {
                return agent;
            }
            set
            {
                agent = value;
            }
        }
        public Client AsignareClientPotential
        {
            get
            { 
                return clientpotential;
            }
            set
            {
                clientpotential = value;
            }
        }
        public Client EliminareClientPotential
        {
            set
            {
                clientpotential = null;
            }
        }
        public float OfertaVSPret()
        {
            return 100-((100 * clientpotential.Buget) / proprietar.pretcerut); 
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("~~IMOBIL~~");
            sb.AppendLine($"PROPRIETAR: {proprietar}");
            sb.AppendLine($"LOCATIE: {locatie}");
            sb.AppendLine($"DIMENSIUNE: {dimensiune}");
            sb.AppendLine($"POZE: {poze}");
            return sb.ToString();        
        }
    }
}
