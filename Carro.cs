//exercício 1 13/09/2022
using System;

class Pneu {
    public int Pressao {get; set;}

    public Pneu () {

    }

    public Pneu (int pPressao) {
        Pressao = pPressao;
    }

    ~Pneu () {

    }

    public void Rodar () {
        Console.WriteLine ("Rodou!");
    }
}

class Carro {
    //exemplo de associação
    public Pneu PI; 
    public Pneu PII; 
    public Pneu PIII; 
    public Pneu PIV; 

    public Carro () {
        Pneu PI = new Pneu ();
        Pneu PII = new Pneu ();
        Pneu PIII = new Pneu ();
        Pneu PIV = new Pneu ();        
    }

    ~Carro () {

    }

    public void Ligar () {
        Console.WriteLine ("Ligou!");
    }

    public void Desligar () {
        Console.WriteLine ("Desligou!");
    }
}

class App {
    static void Main () {
        Carro Peugeot408 = new Carro ();
        Peugeot408.Ligar ();
        Peugeot408.Desligar ();
    }
}

