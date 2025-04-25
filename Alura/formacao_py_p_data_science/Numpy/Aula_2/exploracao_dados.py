import numpy as np #estou importando a biblioteca numpy e dizendo que seu prefixo será np

#trazer os arquivos para o código
url = 'https://raw.githubusercontent.com/alura-cursos/numpy/refs/heads/dados/apples_ts.csv'
dados = np.loadtxt( url ,delimiter=',', usecols=np.arange(1,88,1))

#fazendo a transposição dos dados (troca linha por coluna)
dados_transposto = dados.T

datas =  np.arange(1,88,1)

'''o colchetes determina a quantidade de linhas que vou pegar. Colocar só [:] é todas linhas,
mas colocar [0:2] quer dizer que quero pegar da linha 1 até 2. O que vem depois da vícgula
são as colunas que quero pegar. Como o dado está transposto, a primeira coluna se tornou
as datas.'''

precos = dados_transposto[:,1:6]

moscow = precos[:,0]
Kaliningrad = precos[:,1]
Petersburg = precos[:,2]
Krasnodar = precos[:,3]
Ekaterinburg = precos[:,4]
#agora vou fazer a parte de visualizar os dados
import matplotlib.pyplot as plt

#plt.plot(datas, precos[:,0]) #datas eixo x | preços eixo y
#plt.show()
