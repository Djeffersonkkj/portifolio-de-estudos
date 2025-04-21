'''3. Crie uma função que recebe uma lista como parâmetro e converta
todos os valores da lista para float. A função deve conter um tratamento
de erro indicando o tipo de erro gerado e retornar a lista caso não tenha
ocorrido nenhum erro. Por fim, deve ter a cláusula finally para imprimir
o texto: 'Fim da execução da função'.'''

#criando função
def con_float(lista):
    try:
        lista_float = [float(v) for v in lista]
        return lista_float
    except Exception as erro:
        print(type(erro), f'Erro: {erro}')
    finally:
        print('Fim da execução da função')


#criando lista
lista = [1, 2, 3, 4, 5, 6]
lista2 = [1, 2, 'b', 4, 5]

#tsestando
print(con_float(lista))
print(con_float(lista2))