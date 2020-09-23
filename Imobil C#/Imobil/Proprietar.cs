using System.Text;

namespace Imobil
{
    public class Proprietar: Persoana
    {
        public int pretcerut;
        public Proprietar(string nume, int varsta, long telefon, string email, int pretcerut) : base(nume, varsta, telefon, email)
        {
            this.pretcerut = pretcerut;
        }

        public int PretCerut
        {
            get
            {
                return pretcerut;
            }
            set
            {
                pretcerut = value;
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
            sb.Append("PRET CERUT: " + pretcerut);
            sb.Append("*");
            return sb.ToString();
        }
    }
}