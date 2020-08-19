import 'Persoana.dart';

class Client extends Persoana
{
  int buget;
  List <String> locatiideinteres;
  Client(String nume, int varsta, int telefon, String email, int buget, List<String> locatiideinteres) : super(nume, varsta, telefon, email)
  {
    this.buget = buget;
    this.locatiideinteres = new List<String>();
  }

  int get Buget => buget;
  set Buget(int value) => buget=value;

  String get Locatii_De_Interes
  {
    var sb=new StringBuffer();
    locatiideinteres.forEach((element) {sb.writeln(element+ ' ');});
    return sb.toString();
  }
  set Locatii_De_Interes(String value) => locatiideinteres.add(value+ ' ');

  @override
  String toString() {
    StringBuffer sb = new StringBuffer();
    sb.writeln('*');
    sb.writeln('NUME: ' + nume + ', ');
    sb.writeln('VARSTA: ' + varsta.toString() + ', ');
    sb.writeln('NUMAR DE TELEFON: ' + telefon.toString() + ', ');
    sb.writeln(('BUGET: ' + buget.toString()));
    sb.writeln('EMAIL: ' + email + ', ');
    sb.writeln('* ');
    return sb.toString();
  }

  }