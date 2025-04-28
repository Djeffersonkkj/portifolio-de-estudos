'''Apenas criando os hixogramas das questões'''

import matplotlib.pyplot as plt

#Questão 1 ---------------------------------------------

casamento_x = [0, 6, 12, 18, 24, 30]
casamento_y = [2800, 1400, 600, 150, 50]
casamento_centro = [(casamento_x[i] + casamento_x[i+1])/2 for i in range(len(casamento_x)-1)]

plt.figure(figsize=(8,6))
plt.bar(casamento_centro, casamento_y, width=6, edgecolor='black', align='center' )

plt.xlabel('anos de casamento')
plt.ylabel('número de divorcios')
plt.title('QUESTÃO 1')
plt.grid(axis='y', linestyle='--', alpha=0.7)
plt.show()