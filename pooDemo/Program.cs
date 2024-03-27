// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");

// Apuntador apuntadorPlatzi = new Apuntador();
// Apuntador apuntadorPlatzi2 = new Apuntador();

// apuntadorPlatzi.color = "negro";
// apuntadorPlatzi2.color = "blanco";

// class Apuntador
// {
//     public string color;
//     public double largo;
//     public short numeroBotones;
//     public bool tieneSticker;
// }

using pooDemo.Models;

var poderVolar = new SuperPoder();
poderVolar.nombre = "volar";
poderVolar.descripcion = "capacidad para volar y planear en el aire";
poderVolar.nivel = SuperPoder.NivelPoder.Medio;

var superFuerza = new SuperPoder();
superFuerza.nombre = "super Fuerza";
superFuerza.nivel = SuperPoder.NivelPoder.Alto;


var superman = new SuperHeroe();

superman.id = 1;
superman.nombre = "superman";
superman.identidadSecreta = "Clark Kent";
superman.ciudad = "Metropolis";
superman.puedeVolar = true;

List<SuperPoder> poderesSuperman = new List<SuperPoder>();
poderesSuperman.Add(poderVolar);
poderesSuperman.Add(superFuerza);
superman.superPoderes = poderesSuperman;
string resultadoUsarPoderes = superman.usarSuperPoderes();
Console.WriteLine(resultadoUsarPoderes);

var batman = new SuperHeroe();

batman.id = 2;
batman.nombre = "Batman";
batman.identidadSecreta = "Bruce Wayne";
batman.ciudad = "Gotham";
batman.puedeVolar = false;


var wonderWoman = new SuperHeroe();

wonderWoman.id = 3;
wonderWoman.nombre = "Wonder Woman";
wonderWoman.identidadSecreta = "Diana Prince";
wonderWoman.ciudad = "Themyscira";
wonderWoman.puedeVolar = true;

List<SuperPoder> poderesWonderWoman = new List<SuperPoder>();
poderesWonderWoman.Add(poderVolar);
poderesWonderWoman.Add(superFuerza);
wonderWoman.superPoderes = poderesWonderWoman;
string resultadoUsarPodereswonderWoman = wonderWoman.usarSuperPoderes();
Console.WriteLine(resultadoUsarPodereswonderWoman);


var flash = new SuperHeroe();

flash.id = 4;
flash.nombre = "Flash";
flash.identidadSecreta = "Barry Allen";
flash.ciudad = "Central City";
flash.puedeVolar = false;



