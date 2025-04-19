'''2. Escreva uma função que gere a tabuada de um número inteiro de 1 a 10, 
de acordo com a escolha da pessoa usuária. Como exemplo, para o número 7, a
tabuada deve ser mostrada no seguinte formato:'''

#entrada
numero = int(input('Digite o número inteiro que deseja ver a atabuada: '))

#função para gerar tabuada
def tabuada(numero):
    x = 0
    while x <= 10:
        print(f'{numero} x {x} = {numero * x}\n')
        x +=1

#exibindo
tabuada(numero)