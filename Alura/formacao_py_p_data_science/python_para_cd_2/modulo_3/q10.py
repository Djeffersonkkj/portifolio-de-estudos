'''Nessa mesma tabela de cadastro de filiais, há uma coluna com as
informações da quantidade de pessoas colaboradoras e o(a) gestor(a)
gostaria de ter um agrupamento da soma dessas pessoas para cada estado.
As informações contidas na tabela são:

A partir da lista de tuplas, crie um dicionário em que as chaves são os
nomes dos Estados únicos e os valores são as listas com o número de colaboradores(as)
referentes ao Estado. Crie também um dicionário em que as chaves são os nomes dos
Estados e os valores são a soma de colaboradores(as) por Estado.'''

funcionarios = [('SP', 16), ('ES', 8), ('MG', 9), ('MG', 6), ('SP', 10), ('MG', 4),
                ('ES',9), ('ES', 7), ('ES', 12), ('SP', 7), ('SP', 11), ('MG',8), ('ES',8),
                ('SP',9), ('RJ', 13), ('MG', 5), ('RJ', 9), ('SP', 12), ('MG', 10), ('SP', 7),
                ('ES', 14), ('SP', 10), ('MG', 12)]

lista = [[estado[1] for estado in funcionarios if estado[0] == 'SP'], [estado[1] for estado in funcionarios if estado[0] == 'ES'],
         [estado[1] for estado in funcionarios if estado[0] == 'MG'], [estado[1] for estado in funcionarios if estado[0] == 'RJ']]

funcionarios_soma = {'SP': sum(lista[0]), 'ES': sum(lista[1]), 'MG': sum(lista[2]), 'RJ': sum(lista[3])}
funscionarios_dict = {'SP': lista[0], 'ES': lista[1], 'MG': lista[2], 'RJ': lista[3]}

print('Soma dos funcionários: ', funcionarios_soma)
print('Funcionários por estado: ', funscionarios_dict)

