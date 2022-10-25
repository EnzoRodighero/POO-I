using System;
abstract class Pessoa {
    public string Nome {get; set;}
    public int Idade {get; set;}
    public float Peso {get; set;}
    protected int Energia;

    public Pessoa () {
        Energia = 100;
    }

    public Pessoa (string pNome, int pIdade, float pPeso) {
        Nome = pNome;
        Idade = pIdade;
        Peso = pPeso;
    }

    ~Pessoa () {

    }

    //Uso do virtual permite que os métodos possam ser alterados nas classes que irão herdar desta classe

    public virtual void Andar () {
        Energia -= 20;
    }

    public virtual int Dormir () {
        Energia += 50;
        if (Energia > 100) {
            Energia = 100;
        }
        return Energia;
    }

    public virtual int MostraEnergia () {
        return Energia;
    }
}

class Pai: Pessoa {
    public Pai () {

    }

    public Pai (string pNome, int pIdade, float pPeso) {
        Nome = pNome;
        Idade = pIdade;
        Peso = pPeso;
    }

    ~Pai () {

    }

    //Nessa classe escolhi alterar os métodos da classe Pessoa
    //Uso do 'override' permite alterar os métodos herdados da classe Pessoa

    public override void Andar () {
        Energia -= 30;
    }

    public override int Dormir () {
        Energia += 50;
        if (Energia > 100) {
            Energia = 100;
        }
        return Energia;
    }
}

class Filho: Pessoa {

    public Filho () {

    }

    public Filho (string pNome, int pIdade, float pPeso) {
        Nome = pNome;
        Idade = pIdade;
        Peso = pPeso;
    }

    ~Filho () {

    }
    
    //Caso não queira fazer alteração nos métodos da classe Pessoa é preciso não implementar nada! (Com exceção dos constructors e destructor)
    //Isso é possível pois essa classe herda da classe pessoa!
}

class App {
    static string Ler (string pTxt) {
        string Campo;
        Console.WriteLine ("Insira {0}: ", pTxt);
        Campo = Console.ReadLine ();
        return Campo;
    }

    static void PecaDadosPai (ref Pai pPai) {
        pPai.Nome = Ler ("Nome");
        pPai.Idade = int.Parse (Ler ("Idade"));
        pPai.Peso = float.Parse (Ler ("Peso"));
    }

    static void PecaDadosFilho (ref Filho pFilho) {
        pFilho.Nome = Ler ("Nome");
        pFilho.Idade = int.Parse (Ler ("Idade"));
        pFilho.Peso = float.Parse (Ler ("Peso"));
    }

    static void MostraDadosPai (Pai pPai) {
        Console.WriteLine ("Nome: {0}", pPai.Nome);
        Console.WriteLine ("Idade: {0}", pPai.Idade);
        Console.WriteLine ("Peso: {0}", pPai.Peso);
    }

    static void MostraDadosFilho (Filho pFilho) {
        Console.WriteLine ("Nome: {0}", pFilho.Nome);
        Console.WriteLine ("Idade: {0}", pFilho.Idade);
        Console.WriteLine ("Peso: {0}", pFilho.Peso);
    }

    static void Main () {
        Pai Jose = new Pai ();
        Filho Enzo = new Filho ();

        //Jose.Nome = "Jose";
        //Jose.Idade = 52;
        //Jose.Peso = 70;

        //Enzo.Nome = "Enzo";
        //Enzo.Idade = 21;
        //Enzo.Peso = 90;

        Console.WriteLine ("Dados do Pai!");
        PecaDadosPai (ref Jose);
        Console.WriteLine ("Dados do Filho!");
        PecaDadosFilho (ref Enzo);

        MostraDadosPai (Jose);
        MostraDadosFilho (Enzo);

        Console.WriteLine ("Pai andou!"); 
        Jose.Andar ();
        Console.WriteLine ("Filho andou!"); 
        Enzo.Andar ();

        Console.WriteLine ("Energia do pai: {0}", Jose.MostraEnergia ());
        Console.WriteLine ("Energia do Filho: {0}", Enzo.MostraEnergia ());

        Console.WriteLine ("Pai dormiu!"); 
        Jose.Dormir ();
        Console.WriteLine ("Filho dormiu!");  
        Enzo.Dormir ();

        Console.WriteLine ("Energia do pai: {0}", Jose.MostraEnergia ());
        Console.WriteLine ("Energia do Filho: {0}", Enzo.MostraEnergia ());
    }
}
