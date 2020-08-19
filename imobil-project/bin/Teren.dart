import 'imobil.dart';
import 'Proprietar.dart';
import 'Poza.dart';
class Teren extends Imobil
{
  Teren(Proprietar proprietar, String locatie, int dimensiune, Poza poze): super(proprietar,locatie,dimensiune,poze);

  @override
  String toString() {
    StringBuffer sb = new StringBuffer();
    sb.writeln('~~TEREN~~');
    sb.writeln('PROPRIETAR: ' +proprietar.toString());
    sb.writeln('LOCATIE: '+locatie.toString());
    sb.writeln('DIMENSIUNE: '+dimensiune.toString());
    sb.writeln('POZE: '+poze.toString());
    return sb.toString();

  }
}