'''Crie uma função que recebe por parâmetro o raio de uma esfera e calcula o
seu volume (v = 4/3 * pi * raio ao cubo).'''

#importando biblioteca para pi
import math
#criando fução
def volume(r):
    v = 4/3 * math.pi * r ** 3
    return v

#recebendo dados
raio = float(input('digite o raio da esfera: '))

#exibindo resultado

print(f'o volume da esfera é aproximadamente {volume(raio):.2f}m³')
    