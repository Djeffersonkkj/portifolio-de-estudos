'''Chegou a hora de você testar os conhecimentos desenvolvidos
durante a aula. Continuando com o projeto das laranjas/toranjas agora
você deve calcular o coeficiente ângular e o linear para a reta da laranja
e para a reta da toranja. Use a fórmula de mínimos quadrados para encontrar
cada um.'''

import numpy as np

url = 'https://raw.githubusercontent.com/allanspadini/numpy/dados/citrus.csv'

dados = np.loadtxt(url, delimiter=',', usecols=np.arange(1, 6, 1), skiprows=1)

#colunas
diametro_laranjas = dados[:5000,0]
peso_laranjas = dados[:5000,1]
diametro_toranjas = dados[5000:,0]
peso_toranjas = dados[5000:,1]

Y = peso_laranjas
X = diametro_laranjas
n = np.size(peso_laranjas)

a = (n*np.sum(X*Y) - np.sum(X)*np.sum(Y))/(n*np.sum(X**2) - np.sum(X)**2)
b = np.mean(np.sum(Y)) - a * np.mean(np.sum(X))

'''Para a toranja basta trocar o laranja por toranja
no nome das variáveis.'''