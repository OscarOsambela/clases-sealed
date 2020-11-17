using System;


class MainClass {
  public static void Main (string[] args) {
    Caballo miBabieca = new Caballo("Babieca");
		Humano miJuan = new Humano("Juan");
		Gorila miGorila = new Gorila("Gorila");
    Ballena miBallena = new Ballena("Moby");
    Lagartija miLagartija = new Lagartija("Igor");

    miLagartija.getNombre();
    miLagartija.respirar();
    miJuan.getNombre();
    miJuan.respirar();
		miNino.
  }
}

abstract class Animales{
  public void respirar(){
		Console.WriteLine("Soy capaz de respirar");
	}
  public abstract void getNombre();
}

interface IMamiferoTerrestre{
  int numeroPatas();
}  

class Mamiferos:Animales{
  private string nombreSerVivo;
  
  //constructor
	public Mamiferos(string nombre){
		nombreSerVivo = nombre;
	}

	public void cuidarCrias(){
		Console.WriteLine("Soy capaz de cuidad crías");
	}
	public virtual void pensar(){
	  Console.WriteLine("Pensamiento básico e instintivo");
	}
  //añadir la palabra override el metodo que estamos heredado de la clase abstracta
	public override void getNombre(){
		Console.WriteLine("El nombre del mamífero es: " + nombreSerVivo);
	}
  
}

//subclases
class Lagartija:Animales{
  private string nombreReptil;

  public Lagartija(string nombre){
    nombreReptil = nombre;
  }
  //sobreescribir el metodo para separarla del metodo de clase abstracta
  public override void getNombre(){
    Console.WriteLine("El nombre del reptil es: " + nombreReptil);
  }
}

class Ballena:Mamiferos{
  public Ballena(string nombreBallena):base(nombreBallena){}
  public void nadar(){
    Console.WriteLine("Soy capaz de nadar");
  }
}
class Caballo:Mamiferos, IMamiferoTerrestre{
	public Caballo(string nombreCaballo):base(nombreCaballo){}
	public void galopar(){
		Console.WriteLine("Soy capaz de galopar");
	}
  public int numeroPatas(){
    return 4;
  }
}
class Humano:Mamiferos{
	public Humano(string nombreHumano):base(nombreHumano){}
	//este metodo con la palabra sealed al igual que la clase que no puede dar herencia, no puede ser sobreescrito por otro metodo en otra clase heredada
	public sealed override void pensar(){
		Console.WriteLine("Soy capaz de pensar");
	}
}

//la clase sealed impide que la clase pueda dar herencia a otra subclase, en este caso Gorila no podrá heredar a otra sub clase 
sealed class Gorila:Mamiferos, IMamiferoTerrestre{
	public Gorila(string nombreGorila):base(nombreGorila){}
	public void trepar(){
		Console.WriteLine("Soy capaz de trepar");
	}
  public override void pensar(){
    Console.WriteLine("Pensamiento animal");
  }
  public int numeroPatas(){
    return 2;
  }
}

