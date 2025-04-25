'''Chegou a hora de você testar os conhecimentos desenvolvidos durante a aula.
Continuando com o projeto das laranjas/toranjas agora você deve selecionar parte
dos dados. As colunas que iremos avaliar são as de diâmetro e peso. Crie arrays
específicos para guardar o diâmetro e peso da laranja e toranja. O diâmetro está
na coluna zero e o peso na coluna 1. Os dados referentes a laranja vão até a linha
4999 e os referentes à toranja iniciam na linha 5000 do arquivo.

Após fazer a seleção de dados, importe a biblioteca matplotlib e crie um gráfico
para a laranja e para a toranja do peso pelo diâmetro.'''

import numpy as np

url = 'https://raw.githubusercontent.com/allanspadini/numpy/dados/citrus.csv'

dados = np.loadtxt(url, delimiter=',', usecols=np.arange(1, 6, 1), skiprows=1)

#colunas
diametro_laranjas = dados[:5000,0]
peso_laranjas = dados[:5000,1]
diametro_toranjas = dados[5000:,0]
peso_toranjas = dados[5000:,1]

#criar gráfico

import matplotlib.pyplot as plt

plt.plot(diametro_laranjas, peso_laranjas)
plt.plot(diametro_toranjas, peso_toranjas)
plt.legend(['laranja', 'toranja'])
plt.show()


