class Pessoa:
    __slots__ = ['__nome', '__idade'] #__slots__ reserva espaço para os atributos especificados
    
    def __init__(self, nome, idade):
        self.__nome = nome
        self.__idade = idade


#Testando ------------------------------------------
pessoa = Pessoa('João', 15)
pessoa.altura = 1.75