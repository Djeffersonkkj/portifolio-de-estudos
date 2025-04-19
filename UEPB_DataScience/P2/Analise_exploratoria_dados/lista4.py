'''A lista 4 de análise exploratória de dados 
tem como todas as suas questões conseguir a média,
mediana, moda, variância, desvio padrão e coeficiência
de variação'''

from collections import Counter
#criando funções
def unrange(dados, fi):
    newlist = []
    for d, f in zip(dados, fi):
        for _ in range(f):
            newlist.append(d)
    return newlist

def resposta(lista):
    lista.sort()
    media = sum(lista) / len(lista)
    mediana = None
    moda = None
    variancia = None
    desvio_p = None
    coeficiente_v = None
    
    #calculo mediana
    n = len(lista)
    if n % 2 == 0:  # Se for par, pega a média dos dois valores centrais
        mediana = (lista[n // 2 - 1] + lista[n // 2]) / 2
    else:  # Se for ímpar, pega o valor central
        mediana = lista[n // 2]
    
     # Cálculo da moda
    contagem = Counter(lista)
    max_frequencia = max(contagem.values())
    moda = [num for num, freq in contagem.items() if freq == max_frequencia]

    #calculando variância
    diferenca = []
    for d in lista:
        dif = d - media
        if dif < 0:
            dif = abs(dif)
        diferenca.append(dif)
    dif_qdd = []
    for d in diferenca:
        dif_qdd.append(d ** 2)
    variancia = sum(dif_qdd) / len(dif_qdd)
    
    #calculando o desvio padrão
    desvio_p = variancia ** 0.5
    
    #calculando coeficiente de variação
    coeficiente_v = (desvio_p / media) * 100
    
    #exibindo
    print('a média é: ', media)
    print('a mediana é:', mediana)
    print('a moda é: ', moda)
    print('a variância é: ', variancia)
    print('o desvio padrão é: ', desvio_p)
    print('o coeficiente de variação é: ', coeficiente_v)
    
    

#questão 1
print('QUESTÃO 1----------------')

"""Em uma pesquisa socioeconômica sobre itens de conforto, perguntou-se aos
entrevistados, quantos aparelhos de TV há em sua casa. Os resultados aparecem
na tabela:"""

aparelhos = [1, 2, 3, 4]
fi_1 = [20, 12, 10, 7]
aparelhos = unrange(aparelhos, fi_1)
resposta(aparelhos)

#questão 2
print('QUESTÃO 2----------------')

'''Os dados seguintes referem-se ao tempo de espera (em minutos) de 30 clientes em
uma fila de banco, em um dia de grande movimento:'''

tempo = [23, 19, 7, 21, 16, 13, 11, 16, 33, 22, 17, 15, 12, 18, 25,
         10, 8, 20, 16, 14, 19, 23, 36, 30, 30, 28, 35, 14, 16, 12]

resposta(tempo)

#questão 3
print('QUESTÃO 3----------------')

'''As marcas obtidas, em metros, pelos alunos numa prova de salto em distância
foram as seguintes:'''

metros = [2.20, 2.28, 2.23, 2.20, 2.35, 2.28, 2.25, 2.30, 2.37]

resposta(metros)

#questão 4
print('QUESTÃO 4----------------')

'''Os dados da tabela abaixo são referentes as idades dos alunos de uma
determinada disciplina.'''

idade = [14, 15, 16, 17, 18]
fi_4 = [10, 16, 5, 12, 9]
idade = unrange(idade, fi_4)
resposta(idade)

#questão 5
print('QUESTÃO 5----------------')

'''Os dados que seguem referem-se à tonelagem (em milhares de toneladas) de
grandes tanques de óleo.'''

tonelagem = [189, 220, 227, 231, 239, 257, 269, 290, 195, 220, 229, 231, 249, 258, 
             269, 290, 214, 222, 229, 232, 253, 259, 270, 313, 218, 223, 230, 232, 253,
             260, 274, 361, 220, 224, 231, 237, 254, 268, 277, 375]

resposta(tonelagem)

#questão 6
print('QUESTÃO 6----------------')

'''Os dados abaixo apresentam a distâncias (em km) entre a residência e o local de
trabalho dos funcionários da empresa A.'''

km = [1.8, 2.5, 0.4, 1.9, 4.4, 2.2, 3.5, 0.2, 0.9, 1.1, 1.7, 1.2, 2.3, 1.9, 0.8, 
      1.5, 1.7, 1.4, 3.2, 15.1, 2.1, 0.5, 0.9, 1.7, 0.5, 0.8, 1.4, 1.8, 2.0, 1.1,
      1.0, 0.8, 1.4, 2.1, 3.7]
resposta(km)

#questão 7
print('QUESTÃO 7----------------')

'''A dona de um restaurante registrou durante 6 meses quantos clientes ele recebia
a cada semana. Os dados estão abaixo em ordem crescente.'''

vendas = [501, 512, 516, 525, 528, 536, 546, 556, 564, 567, 589, 597, 601, 603, 605, 612,
          615, 624, 629, 635, 642, 645, 648, 651]

resposta(vendas)


#questão 8
print('QUESTÃO 8----------------')
