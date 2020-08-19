import 'imobil.dart';
import 'Proprietar.dart';
import 'Poza.dart';
class Apartament extends Imobil
{
  int nr_camere;
  int etaj;
  bool loc_de_parcare;
  Apartament(Proprietar proprietar, String locatie, int dimensiune, Poza poze,int nr_camere, int etaj,bool loc_de_parcare): super(proprietar,locatie,dimensiune,poze)
  {
    this.nr_camere = nr_camere;
    this.etaj = etaj;
    this.loc_de_parcare = loc_de_parcare;
  }
  int get Numar_De_Camere => nr_camere;
  set Numar_De_Camere(int value) => nr_camere=value;

  int get Etaj => etaj;
  set Etaje(int value) => etaj=value;

  bool get Loc_De_Parcare => loc_de_parcare;
  set Loc_De_Parcare(bool value) => loc_de_parcare=value;

@override
  String toString() {
  StringBuffer sb = new StringBuffer();
  sb.writeln('~~APARTAMENT~~');
  sb.writeln('PROPRIETAR: ' +proprietar.toString());
  sb.writeln('LOCATIE: '+locatie.toString());
  sb.writeln('DIMENSIUNE: '+dimensiune.toString());
  sb.writeln('POZE: '+poze.toString());
  sb.writeln('NUMAR DE CAMERE : '+nr_camere.toString());
  sb.writeln('ETAJ : '+etaj.toString());
  sb.writeln('LOC DE PARCARE : '+loc_de_parcare.toString());
  return sb.toString();

  }
}