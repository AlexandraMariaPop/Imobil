import 'dart:core';
import 'Poza.dart';
import 'Proprietar.dart';
import 'Agent.dart';
import 'Client.dart';
class Imobil
{
  Proprietar proprietar;
  String locatie;
  int dimensiune;
  Poza poze;
  Agent agent;
  Client client_potential;
  Imobil(proprietar, String locatie, int dimensiune, Poza poze)
  {
    this.proprietar = proprietar;
    this.locatie = locatie;
    this.dimensiune = dimensiune;
    this.poze = poze;
  }
  Proprietar get PROPRIETAR => proprietar;
  set PROPRIETAR(Proprietar value) => proprietar=value;

  String get LOCATIE => locatie;
  set LOCATIE(String value) => locatie=value;

  int get DIMENSIUNE=>dimensiune;
  set DIMENSIUNE(int value)=>dimensiune=value;

  Poza get POZE=>poze;
  set POZE(Poza value)=>poze=value;

  Agent get Asignare_Agent=>agent;
  set Asignare_Agent(Agent value)=>agent=value;

  Client get Asignare_Client_Potential=>client_potential;
  set Asignare_Client_Potential(Client value)=>client_potential=value;

  double OfertaVSPret()
  {
    return 100-((100 * client_potential.Buget) / proprietar.pretcerut);
  }
  @override
  String toString() {
    StringBuffer sb = new StringBuffer();
    sb.writeln('~~IMOBIL~~');
    sb.writeln('PROPRIETAR: ' +proprietar.toString());
    sb.writeln('LOCATIE: '+locatie.toString());
    sb.writeln('DIMENSIUNE: '+dimensiune.toString());
    sb.writeln('POZE: '+poze.toString());
    return sb.toString();

  }
}