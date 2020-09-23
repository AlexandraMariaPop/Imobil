using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imobil
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> locatiideinteres1 = new List<string>();
            Client client1=new Client("Ana", 33, 423879, "sgd@dhb.com", 250,locatiideinteres1);
            client1.LocatiiDeInteres = "Pantelimon";
            client1.LocatiiDeInteres = "Oradea";
            Client client2 = new Client("Andrei", 23,11111, "qwergh", 500, locatiideinteres1);
            client2.LocatiiDeInteres = "Arad";
            client2.LocatiiDeInteres = "Oradea";
            Client client3 = new Client("Mikey", 33, 123, "  ", 1000, locatiideinteres1);
            client3.LocatiiDeInteres = "New York";
            client3.LocatiiDeInteres = "Canada";

            Proprietar proprietar1 = new Proprietar("Elena", 33, 2434, "er@c.com", 500);
            Proprietar proprietar2 = new Proprietar("Scott", 55, 1234, "scott@c.com", 505);
            Proprietar proprietar3 = new Proprietar("Kim", 45, 298765, "kim@c.com", 1200);

            Agent agent1 = new Agent("Cristian", 22, 2435, "lskadj@jsk.com");
            Agent agent2 = new Agent("Mihai", 25, 4353452225, "66@smn.com");
            
            Poza poza1 = new Poza("wsfhd", 22, "Curte Mare");

            Imobil imobil1 = new Imobil(proprietar1, "Deva",5000 ,poza1);
            imobil1.AsignareAgent = agent1;
            imobil1.AsignareClientPotential = client1;

            Apartament apartament1 = new Apartament(proprietar2, "Alba Iulia", 3333, poza1, 4, 5, true);
            apartament1.AsignareAgent=agent1;
            apartament1.AsignareClientPotential = client2;

            Casa casa1 = new Casa(proprietar3, "Bucuresti", 400, poza1, 15, 3, "Curte mare");
            casa1.AsignareAgent = agent2;
            casa1.AsignareClientPotential = client3;

            Teren teren1 = new Teren(proprietar2, "Brasov", 1000, poza1);
            teren1.AsignareAgent = agent2;
           // teren1.AsignareClientPotential = client3;

            List<Imobil> lista1 = new List<Imobil>();
            lista1.Add(imobil1);
            lista1.Add(casa1);
            lista1.Add(apartament1);
            lista1.Add(teren1);

            Console.WriteLine("IMOBILE FARA CLIENT POTENTIAL");
            foreach (var item in lista1)
            {
                if(item.clientpotential==null)
                    Console.WriteLine(item);
            }
            teren1.AsignareClientPotential = client2;
            Console.WriteLine("IMOBILE CU PROCENT DE NEGOCIERE MAI MIC DE 10%");
            for (int i = 0; i < lista1.Count; i++)
            {
                if (lista1[i].OfertaVSPret() < 10)
                    Console.WriteLine(lista1[i]+ "PROCENT: "+ lista1[i].OfertaVSPret());
            }
            Console.ReadKey();
        }
    }
}
