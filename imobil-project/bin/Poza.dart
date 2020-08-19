class Poza
{
  String url;
  int nr_ordine;
  String descriere;
  Poza(this.url, this. nr_ordine, this. descriere);

  String get URL => url;
  set URL(String value) => url=value;

  int get NR_ORDINE => nr_ordine;
  set NR_ORDINE(int value) => nr_ordine=value;

  String get DESCRIERE => descriere;
  set DESCRIERE(String value) => descriere=value;
@override
  String toString() {
  return ('[POZA]--URL: $URL -- NUMAR DE ORDINE: $nr_ordine -- DESCRIERE: $descriere');
  }
}