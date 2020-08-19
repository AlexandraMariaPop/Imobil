import 'imobil.dart';
import 'Proprietar.dart';
import 'Poza.dart';
class Casa extends Imobil
{
  int nr_camere;
  int etaje;
  String curte;
  Casa(Proprietar proprietar, String locatie, int dimensiune, Poza poze, int nr_camere, int etaje,String curte) : super(proprietar, locatie, dimensiune, poze)
  {
    this.nr_camere = nr_camere;
    this.etaje = etaje;
    this.curte = curte;

  }
  int get Numar_De_Camere => nr_camere;
  set Numar_De_Camere(int value) => nr_camere=value;

  int get Etaje => etaje;
  set Etaje(int value) => etaje=value;

  String get Curte =>curte;
  set Curte(String value) =>curte=value;

  @override
  String toString() {
    StringBuffer sb = new StringBuffer();
    sb.writeln('~~CASA~~');
    sb.writeln('PROPRIETAR: ' +proprietar.toString());
    sb.writeln('LOCATIE: '+locatie.toString());
    sb.writeln('DIMENSIUNE: '+dimensiune.toString());
    sb.writeln('POZE: '+poze.toString());
    sb.writeln('NUMAR DE CAMERE : '+nr_camere.toString());
    sb.writeln('ETAJe : '+etaje.toString());
    sb.writeln('CURTE '+curte.toString());
    return sb.toString();

  }
}