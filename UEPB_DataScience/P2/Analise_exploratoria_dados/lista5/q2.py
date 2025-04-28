'''O Departamento Pessoal de uma certa firma fez um levantamento dos salários dos
120 funcionários do setor administrativo, obtendo os resultados (em salários mínimos)
da tabela abaixo.'''

import matplotlib.pyplot as plt

faixa_salarial = [0, 2, 4, 6, 10]
frequencia_relativa = [0.25, 0.40, 0.20, 0.15]
funcionarios = 120

frequencia_absoluta = [fr * funcionarios for fr in frequencia_relativa]

larguras = [faixa_salarial[i+1] - faixa_salarial[i] for i in range(len(faixa_salarial)-1)]
densidade = [frequencia_absoluta[i] / larguras[i] for i in range(len(larguras))]

plt.figure(figsize=(8,6))
plt.bar(faixa_salarial[:-1], densidade, width=larguras, edgecolor='black', align='edge')

plt.xlabel('Salário (em salários mínimos)')
plt.ylabel('Densidade')
plt.title('QUESTÃO 2')
plt.grid(axis='y', linestyle='--', alpha=0.7)
plt.show()