'''Faça uma função para verificar se um determinado número pertence a uma
lista de números. O retorno da função é uma mensagem indicando se o
número pertence ou não. Não utilizar as funções predefinidas do python.'''

#criando função
def verificar_valor(lista, numero):
    pertence = f'O número {numero} NÃO PERTENCE a lista'
    for i in range(len(lista)):
        if numero == lista[i]:
            pertence = f'O número {numero} PERTENCE a lista'
            break
    return pertence

#dados

lista = [3, 5, 8, 12, 1]
verificar = int(input('digite o número que deseja verificar se pertence a lista: '))

#exibindo

print(verificar_valor(lista, verificar))