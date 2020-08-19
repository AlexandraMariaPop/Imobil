import 'Persoana.dart';
class Proprietar extends Persoana
{
  int pretcerut;
  Proprietar(String nume, int varsta, int telefon, String email, int pretcerut) : super(nume, varsta, telefon, email)
  {
    this.pretcerut = pretcerut;
  }
  int get Pret_Cerut => pretcerut;
  set Pret_Cerut(int value) => pretcerut=value;
  @override
  String toString() {
    StringBuffer sb = new StringBuffer();
    sb.writeln('*');
    sb.writeln('NUME: ' + nume + ', ');
    sb.writeln('VARSTA: ' + varsta.toString() + ', ');
    sb.writeln('NUMAR DE TELEFON: ' + telefon.toString() + ', ');
    sb.writeln('EMAIL: ' + email + ', ');
    sb.writeln('PRET CERUT: $pretcerut');
    sb.writeln('* ');
    return sb.toString();
  }
  }