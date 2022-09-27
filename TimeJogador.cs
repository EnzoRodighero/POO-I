//exercício 3 13/09/2022
using System;
using System.Collections.Generic;

class Jogador {
    public string Nome {get; set;}
    private int Energia;

    public Jogador () {
        Energia = 100;
    }

    public Jogador (string pNome) {
        Nome = pNome;
    }

    ~Jogador () {

    }
}

class Time {
    List <Jogador> Jogadores = new List <Jogador> (); //Pode ser declarado e inicializado ao meso tempo
    public Time () {
        
    }

    ~Time () {

    }

    public void Adicionar (Jogador pJogador) {
            Jogadores.Add (pJogador);
            Console.WriteLine ("Jogador Inserido!"); 
    }

    public void Mostrar () {
        for (int i = 0; i < Jogadores.Count; i++) {
            Console.WriteLine (Jogadores[i].Nome);
        }
    }

    public int MostraTotal () {
        return Jogadores.Count;
    }
}

class App {
    static string Ler (string pTxt) {
        string Campo;
        Console.WriteLine ("Insira: {0}", pTxt);
        Campo = Console.ReadLine ();
        return Campo;
    }
    
    static void PecaDadosJogador (ref Jogador pJogador) {
        pJogador.Nome = Ler ("Nome");
    }

    static void Main () {
        Jogador Enzo = new Jogador ();
        Time NE = new Time ();

        //Enzo.Nome = "Enzo";
        PecaDadosJogador (ref Enzo);
        NE.Adicionar (Enzo);
        NE.Mostrar ();
        Console.WriteLine (NE.MostraTotal ());
    }
}