class Persoana
{
  String nume;
  String email;
  int varsta;
  int telefon;

  Persoana(String nume, int varsta, int telefon, String email)
  {

    this.nume = nume;
    this.varsta = varsta;
    this.telefon = telefon;
    this.email = email;
  }
  String get Nume => nume;
  set NUME(String value) => nume=value;

  String get Email => email;
  set Email(String value) => email=value;

  int get Varsta => varsta;
  set Varsta(int value) => varsta=value;

  int get Telefon => telefon;
  set Telefon(int value) => telefon=value;
@override
  String toString() {
  StringBuffer sb = new StringBuffer();
  sb.writeln('*');
  sb.writeln('NUME: ' + nume + ', ');
  sb.writeln('VARSTA: ' + varsta.toString() + ', ');
  sb.writeln('NUMAR DE TELEFON: ' + telefon.toString() + ', ');
  sb.writeln('EMAIL: ' + email+', ');
  sb.writeln('* ');
  return sb.toString();

  }
}
