class Pessoa:
    def __init__ (self, pNome, pIdade, pPeso):
        self.Nome = pNome
        self.Idade = pIdade
        self.Peso = pPeso
        self.Energia = 100

    def Andar (self):
        self.Energia -= 20

    def Dormir (self):
        self.Energia += 60
        if (self.Energia > 100):
            self.Energia = 100

class Pai (Pessoa):
    def __init__ (self, pNome, pIdade, pPeso, pSalario):
        self.Salario = pSalario
        super ().__init__ (pNome, pIdade, pPeso)

    def Andar (self):
        self.Energia -= 30

    def Dormir (self):
        self.Energia += 50
        if (self.Energia > 100):
            self.Energia = 100

class Filho (Pessoa):
    pass

class App:
    def MostraDadosPai (pPai):
        print ('Nome: ', pPai.Nome)
        print ('Idade: ', pPai.Idade)
        print ('Peso: ', pPai.Peso)
        print ('Salario: ', pPai.Salario)

    def MostraDadosFilho (pFilho):
        print ('Nome: ', pFilho.Nome)
        print ('Idade: ', pFilho.Idade)
        print ('Peso: ', pFilho.Peso)

    def MostraEnergia (pObj, pTxt):
        print ('Energia do', pTxt, pObj.Energia)

    Jose = Pai ('Jose', 52, 70.50, 1000)
    Enzo = Filho ('Enzo', 21, 90.30)

    MostraDadosPai (Jose)
    MostraEnergia (Jose, 'Pai: ')

    print ('---') 

    MostraDadosFilho (Enzo)
    MostraEnergia (Enzo, 'Filho: ')

    Jose.Andar ()
    Enzo.Andar ()

    print ('Apos andar!')
    MostraEnergia (Jose, 'Pai: ')
    MostraEnergia (Enzo, 'Filho: ')

    Jose.Dormir ()
    Enzo.Dormir ()

    print ('Apos dormir!')
    MostraEnergia (Jose, 'Pai: ')
    MostraEnergia (Enzo, 'Filho: ')


