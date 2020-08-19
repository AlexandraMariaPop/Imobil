import 'package:imobil_project/imobil_project.dart' as imobil_project;
import 'Agent.dart';
import 'Apartament.dart';
import 'Casa.dart';
import 'Client.dart';
import 'Persoana.dart';
import 'Poza.dart';
import 'Proprietar.dart';
import 'Teren.dart';
import 'imobil.dart';
void main(List<String> arguments) {
  print('Hello world: ${imobil_project.calculate()}!');
  List<String> locatiideinteres1 = new List<String>();
  Client client1=new Client('Ana', 33, 423879, 'sgd@dhb.com', 250,locatiideinteres1);
  client1.Locatii_De_Interes = 'Pantelimon';
  client1.Locatii_De_Interes = 'Oradea';
  Client client2 = new Client('Andrei', 23,11111, 'qwergh', 500, locatiideinteres1);
  client2.Locatii_De_Interes = 'Arad';
  client2.Locatii_De_Interes = 'Oradea';
  Client client3 = new Client('Mikey', 33, 123, '  ', 1000, locatiideinteres1);
  client3.Locatii_De_Interes = 'New York';
  client3.Locatii_De_Interes = 'Canada';

  Proprietar proprietar1 = new Proprietar('Elena', 33, 2434, 'er@c.com', 500);
  Proprietar proprietar2 = new Proprietar('Scott', 55, 1234, 'scott@c.com', 505);
  Proprietar proprietar3 = new Proprietar('Kim', 45, 298765, 'kim@c.com', 1200);

  Agent agent1 = new Agent('Cristian', 22, 2435, 'lskadj@jsk.com');
  Agent agent2 = new Agent('Mihai', 25, 4353452225, '66@smn.com');

  Poza poza1 = new Poza('wsfhd', 22, 'Curte Mare');

  Imobil imobil1 = new Imobil(proprietar1, 'Deva',5000 ,poza1);
  imobil1.Asignare_Agent = agent1;
  imobil1.Asignare_Client_Potential = client1;

  Apartament apartament1 = new Apartament(proprietar2, 'Alba Iulia', 3333, poza1, 4, 5, true);
  apartament1.Asignare_Agent=agent1;
  apartament1.Asignare_Client_Potential = client2;

  Casa casa1 = new Casa(proprietar3, 'Bucuresti', 400, poza1, 15, 3, 'Curte mare');
  casa1.Asignare_Agent = agent2;
  casa1.Asignare_Client_Potential = client3;

  Teren teren1 = new Teren(proprietar2, 'Brasov', 1000, poza1);
  teren1.Asignare_Agent = agent2;
  // teren1.AsignareClientPotential = client3;

  var lista1 = new List<Imobil>();
  lista1.add(imobil1);
  lista1.add(casa1);
  lista1.add(apartament1);
  lista1.add(teren1);

  print('IMOBILE FARA CLIENT POTENTIAL');
  lista1.forEach((element) { if(element.client_potential==null)
    print(element);});

  teren1.Asignare_Client_Potential = client2;
  print('IMOBILE CU PROCENT DE NEGOCIERE MAI MIC DE 10%');
  for (int i = 0; i < lista1.length; i++)
  {
    if (lista1[i].OfertaVSPret() < 10)
      print(lista1[i].toString()+ 'PROCENT: '+ lista1[i].OfertaVSPret().toString());
  }


}
