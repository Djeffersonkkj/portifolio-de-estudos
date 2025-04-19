'''Faça uma função que receba um número inteiro por parâmetro e informe se
ele é par, ímpar ou zero.'''

#criando a função

def PouI(n):
    numero = None
    if n % 2 == 0 and n != 0:
        numero = 'par'
    elif n % 2 != 0:
        numero = 'ímpar'
    elif n == 0:
        numero = 'zero'
        
    return numero
        
#recebendo input

n = int(input('digite um número inteiro: '))

#testando função

print(f'o número {n} é {PouI(n)}')