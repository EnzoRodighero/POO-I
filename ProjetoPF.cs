using System;

class Pessoa {
    public string Nome {get; set;}
    public int Idade {get; set;}
    public float Peso {get; set;}

    public Pessoa () {

    }

    public Pessoa (string pNome, int pIdade, float pPeso) {
        Nome = pNome;
        Idade = pIdade;
        Peso = pPeso;
    }

    ~Pessoa () {

    }
}

class Pai: Pessoa {
    public float Salario {get; set;}
    private int Energia;

    public Pai () {
        Energia = 100;
    }

    public Pai (float pSalario) {
        Salario = pSalario;
    }

    ~Pai () {

    }

    public int Andar () {
        return Energia = Energia - 40;
    }

    public int Dormir () {
        Energia = Energia + 70;
        if (Energia > 100) {
            Energia = 100;
        }
        return Energia; 
    }

    public int MostraEnergiaPai () {
        return Energia;
    }
}

class Filho: Pessoa {
    public string NomeMae {get; set;}
    private int Energia;

    public Filho () {
        Energia = 100;
    }

    public Filho (string pNomeMae) {
        NomeMae = pNomeMae;
    }

    ~Filho () {

    }

    public int Andar () {
        return Energia = Energia - 20;
    }
    public int Dormir () {
        Energia = Energia + 80;
        if (Energia > 100) {
            Energia = 100;
        }
        return Energia; 
    }

    public int MostraEnergiaFilho () {
        return Energia;
    }
}

class App {
    static string Ler (string txt) {
        string Campo;
        Console.WriteLine ("Insira {0}", txt);
        Campo = Console.ReadLine ();
        return Campo; 
    }

    static void PecaDadosPai (ref Pai pPai) {
        pPai.Nome = Ler ("Nome:");
        pPai.Idade = int.Parse (Ler ("Idade:"));
        pPai.Peso = float.Parse (Ler ("Peso:"));
        pPai.Salario = float.Parse (Ler ("Salario:"));
    }

    static void PecaDadosFilho (ref Filho pFilho) {
        pFilho.Nome = Ler ("Nome:");
        pFilho.Idade = int.Parse (Ler ("Idade:"));
        pFilho.Peso = float.Parse (Ler ("Peso:"));
        pFilho.NomeMae = Ler ("Nome da Mae:");
    }

    static void MostraDadosPai (Pai pPai) {
        Console.WriteLine ("Nome: {0}", pPai.Nome);
        Console.WriteLine ("Idade: {0}", pPai.Idade);
        Console.WriteLine ("Peso: {0}", pPai.Peso);
        Console.WriteLine ("Salario: {0}", pPai.Salario);
        Console.WriteLine (" ");
    }
    
    static void MostraDadosFilho (Filho pFilho) {
        Console.WriteLine ("Nome: {0}", pFilho.Nome);
        Console.WriteLine ("Idade: {0}", pFilho.Idade);
        Console.WriteLine ("Peso: {0}", pFilho.Peso);
        Console.WriteLine ("Nome da Mae: {0}", pFilho.NomeMae);
        Console.WriteLine (" ");
    }

    static void Main () {
        Pai Jose = new Pai ();

        Console.WriteLine ("Dados Pai!");
        PecaDadosPai (ref Jose);
        MostraDadosPai (Jose);
        Jose.MostraEnergiaPai ();

        Filho Enzo = new Filho ();

        Console.WriteLine ("Dados Filho!");
        PecaDadosFilho (ref Enzo);
        MostraDadosFilho (Enzo);
        Enzo.MostraEnergiaFilho ();

        Jose.Andar ();
        Enzo.Andar ();

        Console.WriteLine ("Energia atual do Pai: {0}", Jose.MostraEnergiaPai ());
        Console.WriteLine ("Energia do Filho: {0}", Enzo.MostraEnergiaFilho ());
        
        Console.WriteLine ("Apos dormir!");

        Jose.Dormir ();
        Enzo.Dormir ();
        
        Console.WriteLine ("Energia atual do Pai: {0}", Jose.MostraEnergiaPai ());
        Console.WriteLine ("Energia do Filho: {0}", Enzo.MostraEnergiaFilho ());
    }
}