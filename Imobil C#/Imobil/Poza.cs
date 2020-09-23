namespace Imobil
{
    public class Poza
    {
        public string url;
        public int nr_ordine;
        public string descriere;
        public Poza(string url,int nr_ordine,string descriere)
        {
            this.url = url;
            this.nr_ordine = nr_ordine;
            this.descriere = descriere;
        }
        public string URL
        {
            get
            {
                return url;
            }
            set
            {
                url = value;
            }
        }
        public int NumarDeOrdine
        {
            get
            {
                return nr_ordine;
            }
            set
            {
                nr_ordine = value;
            }
        }
        public string Descriere
        {
            get
            {
                return descriere;
            }
            set
            {
                descriere = value;
            }
        }
        public override string ToString()
        {
            return ($"[POZA]--URL: {URL} -- NUMAR DE ORDINE: {nr_ordine} -- DESCRIERE: {descriere}");
        }
    }
}