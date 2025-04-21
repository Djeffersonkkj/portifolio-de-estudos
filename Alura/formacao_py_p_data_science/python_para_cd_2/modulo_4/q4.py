'''4. Crie uma função que recebe duas listas como parâmetros e agrupe
os elementos um a um das listas, formando uma lista de tuplas de 3
elementos, no qual o primeiro e segundo elemento da tupla são os valores
na posição i das listas e o terceiro elemento é a soma dos valores na
posição i das listas.

A função deve conter um tratamento de erro indicando o tipo de erro gerado
e retornar como resultado a lista de tuplas. Caso as listas enviadas como
parâmetro tenham tamanhos diferentes, a função deve retornar um IndexError
com a frase: 'A quantidade de elementos em cada lista é diferente.' Dados
para testar a função:'''

#valores sem erro
lista1 = [4,6,7,9,10]
lista2 = [-4,6,8,7,9]

#Listas com tamanhos diferentes
lista3 = [4,6,7,9,10,4]
lista4 = [-4,6,8,7,9]

#Listas com valores incoerentes
lista5 = [4,6,7,9,'A']
lista6 = [-4,'E',8,7,9]

#criando função
def sum_list(l1, l2):
    try:
        if len(l1) != len(l2):
            raise IndexError('A quantidade de elementos em cada lista é diferente.')
        lista_sum = [(i1, i2, i1 + i2) for i1, i2 in zip(l1, l2)]
        return lista_sum
    except Exception as erro:
        print(type(erro), f'Erro: {erro}')
        return None
#testando

print(sum_list(lista1, lista2))
print(sum_list(lista3, lista4))
print(sum_list(lista5, lista6))