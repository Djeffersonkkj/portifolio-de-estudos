'''2. Os dados seguintes referem-se ao tempo de espera (em minutos) de 30 clientes em uma fila de 
banco, em um dia de grande movimento: 
23   19    70    21   16   13   11   16   33   22   17   15   22   28   25 
10    8    20   16   14   19   23   36   30   30   28   35   14   16    12 
a)   
Calcule: Média, Mediana e Moda dos dados NÃO agrupados. 
b)   Calcule: Variância, Desvio Padrão e Coeficiente de Variação.'''
import numpy as np
lista = [8, 10, 11, 12, 13, 14, 14, 15, 16, 16, 16, 16, 17, 19, 19, 20, 21, 22, 22, 23, 23, 25, 28, 28, 30, 30, 33, 35, 36, 70]
soma = sum(lista)
media = soma / len(lista)

#desvio de cada nota
desvio_nota = []
for i in lista:
    desvio = i - media 
    if desvio < 0:
        desvio = abs(desvio)
    desvio_nota.append(desvio)
    
desvio_n_q = []
for i in desvio_nota:
    desvio_q = i ** 2
    desvio_n_q.append(desvio_q)

variancia = sum(desvio_n_q) / len(lista)
desvio_padrao = variancia ** 0.5
coeficiente_variacao = (desvio_padrao / media) * 100

print(variancia)
print(desvio_padrao)
print(coeficiente_variacao)


#atividade 4

idade = [14, 15, 16, 17, 18]
fi = [10, 16, 5, 12, 9]
amostra = []
amostra2 = []
desvio_2 = []
desvio_n_q2 = []
for i, f in zip(idade, fi):
    amostra.append(i*f)
    
media_2 = sum(amostra) / sum(fi)

for i, f in zip(idade, fi):
    for _ in range(f):
        amostra2.append(i)

print('a média é', media_2)
print('mediana = 15,50')
print('moda é 15')

for i in amostra2:
    desvio = i - media_2
    if desvio < 0:
        desvio = abs(desvio)
    desvio_2.append(desvio)
    
desvio_n_q2 = []
for i in desvio_2:
    desvio_q = i ** 2
    desvio_n_q2.append(desvio_q)

variancia2 = sum(desvio_n_q2) / len(amostra2)
desvio_padrao2 = variancia2 ** 0.5
coeficiente_variacao2 = (desvio_padrao2 / media_2) * 100

print('a média é: ', media_2)
print('a variancia é: ', variancia2)
print('o desvio padrão é: ', desvio_padrao2)
print(coeficiente_variacao2)