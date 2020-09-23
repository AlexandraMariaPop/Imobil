using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imobil
{
    public class Persoana
    {
        public string nume;
        public string email;
        public int varsta;
        public long telefon;
        
        public Persoana(string nume, int varsta, long telefon, string email)
        {
           
            this.nume = nume;
            this.varsta = varsta;
            this.telefon = telefon;
            this.email = email;
        }
        public string Nume
        {
            get
            {
                return nume;
            }

            set
            {
                nume = value;
            }


        }
      
        public int Varsta
        {
            get
            {
                return varsta;

            }
            set
            {
                varsta = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }

        }
        public long Telefon
        {
            get
            {
                return telefon;
            }
            set
            {
                telefon = value;
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
            sb.Append(" * ");
            return sb.ToString();
        }
    
    }
}
