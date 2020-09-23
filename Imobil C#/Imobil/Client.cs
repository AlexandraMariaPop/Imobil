using System.Collections.Generic;
using System.Text;

namespace Imobil
{
    public class Client : Persoana
    {
        public int buget;
        public List <string> locatiideinteres;
        public Client(string nume, int varsta, long telefon, string email, int buget, List<string> locatiideinteres) : base(nume, varsta, telefon, email)
        {
            this.buget = buget;
            this.locatiideinteres = new List<string>();

        }

        public int Buget
        {
            get
            {
                return buget;
            }
            set
            {
                buget = value;
            }
        }
        public string LocatiiDeInteres
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                foreach (var item in locatiideinteres)
                {
                    sb.Append(item);
                }
                return sb.ToString();
            }
            set
            {
                locatiideinteres.Add(value+ " ");
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("*");
            sb.Append("NUME: " + nume + ", ");
            sb.Append("VARSTA: " + varsta + ", ");
            sb.Append("NUMAR DE TELEFON: " + telefon + ", ");
            sb.Append("EMAIL: " + email+", ");
            sb.Append("BUGET: " + buget+", ");
            sb.Append("*");
            return sb.ToString();
        }
    }
}