function Imobil(proprietar,locatie,dimensiune,poze,pretcerut)
{
   //properties
    this.prorpietar=proprietar;
    this.locatie=locatie;
    this.dimensiune=dimensiune;
    this.poze=poze;
    this.pretcerut=pretcerut;

    //methods
    this.asignareAgent=function(agent)
    {
    this.agent=agent;
    }
    this.asignareProprietar=function(proprietar)
    {
        this.proprietar=proprietar;
    }
    this.asignareClientPotential=function(clientpotential,buget)
    {
        this.clientpotential=clientpotential;
        this.buget=buget;
      
    }
    this.eliminareClientPotential=function(clientpotential,buget)
    {
        this.clientpotential=null;
        this.buget=null;
    }
    this.ofertaVSpret=function()
    {
       
       return 100-((this.buget*100)/this.pretcerut);
    }

}


function Apartament(proprietar,locatie,dimensiune,poze,pretcerut,agent,nrcamere,etaj,locdeparcare)
{
    Imobil.call(this,proprietar,locatie,dimensiune,poze,pretcerut);
    this.agent=agent;
    this.nrcamere=nrcamere;
    this.etaj=etaj;
    this.locdeparcare=locdeparcare;

}


function Casa(proprietar,locatie,dimensiune,poze,pretcerut,agent,nrcamere,etaje,curte)
{
    Imobil.call(this,proprietar,locatie,dimensiune,poze,pretcerut);
    this.agent=agent;
    this.etaje=etaje;
    this.curte=curte;
}


function Teren(proprietar,locatie,dimensiune,poze,pretcerut,agent)
{
    Imobil.call(this,proprietar,locatie,dimensiune,poze,pretcerut);
    this.agent=agent;
}


function Poza(URL,nrordine,descriere)
{
    this.URL=URL;
    this.nrordine=nrordine;
    this.descriere=descriere;
}


function Persoana(nume,varsta,email,telefon)
{
    this.nume=nume;
    this.varsta=varsta;
    this.email=email;
    this.telefon=telefon;
}


function Client(nume,varsta,email,telefon,locatiideinteres,buget)
{
   Persoana.call(this,nume,varsta,email,telefon);
   this.locatiideinteres=locatiideinteres;
   this.buget=buget;
}


function Agent(nume,varsta,email,telefon)
{
    Persoana.call(this,nume,varsta,email,telefon);
}


function Proprietar(nume,varsta,email,telefon,pretcerut)
{
    Persoana.call(this,nume,varsta,email,telefon);
    this.pretcerut=pretcerut;
}


proprietar1=new Proprietar('Mihai',35,'a@c.com',325353524,120);
proprietar2=new Proprietar('Mikey Foster',37,'bluebird@socialhouse.com',476528,234);
proprietar3=new Proprietar('Scoot',29,'scootie@socialhouse.com',534,222);
agent1=new Agent("Mike",35,false,66666);
agent2=new Agent("Andrei",88,false,1233);
client1=new Client("Ana",33,"sgd@dhb.com",423879,"qwerty",250);
client2=new Client("Ana",33,"sgd@dhb.com",423879,"qwerty",1000);
imobil1=new Imobil(proprietar1,"str principala nr 1", 222,new Poza("www.poza.com",123,"teren mare"),1000);
apartament1=new Apartament(proprietar2,"str principala nr 1", 222,new Poza("www.poza.com",123,"curte mare"),1002,agent1,3,2,false);
casa1=new Casa(proprietar3,"Vadu Crisului",23133,new Poza("www.poza.com",123,"loc de joaca"),433,agent2,4,2,true);
imobil2=new Imobil(proprietar1,"Nedefinit", 222,new Poza("www.poza.com",123,"teren mare"),123);
apartament2=new Apartament(proprietar2,"Nedefinit", 222,new Poza("www.poza.com",123,"curte mare"),432,agent1,3,2,false);
casa2=new Casa(proprietar3,"Nedefinit",23133,new Poza("www.poza.com",123,"loc de joaca"),433,agent2,4,2,true);

imobil1.asignareAgent(agent1);
imobil1.asignareClientPotential(client1,client1.buget);
imobil1.asignareProprietar(proprietar1);
console.log("PROCENT :"+imobil1.ofertaVSpret()+"%");

apartament1.asignareAgent(agent1);
apartament1.asignareClientPotential(client2,client2.buget);
apartament1.asignareProprietar(proprietar3);
console.log("PROCENT :"+apartament1.ofertaVSpret()+"%");

casa1.asignareAgent(agent2);
casa1.asignareClientPotential(client1,client1.buget);
casa1.asignareProprietar(proprietar2);
console.log("PROCENT :"+casa1.ofertaVSpret()+"%");

console.log("IMOBILE FARA CLIENT POTENTIAL");
listaimobile=[imobil1,apartament1,casa1,imobil2,casa2,apartament2];
for(i=0; i<listaimobile.length;i++)
{
    if(listaimobile[i].clientpotential===undefined)
    console.log(listaimobile[i]);
}

console.log("IMOBILE CU PROCENT DE NEGOCIERE MAI MIC DE 10%")
for(i=0; i<listaimobile.length;i++)
{
    if(listaimobile[i].ofertaVSpret()<10)
    console.log(listaimobile[i]);
}
