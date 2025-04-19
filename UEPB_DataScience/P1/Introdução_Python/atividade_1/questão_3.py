'''
Q:3 - Elabore um programa que verifica se um número digitado é positivo, negativo ou zero.
'''

nmr = int(input('Digite um número: '))

if nmr > 0:
    print(f'O número {nmr} é positivo.')
elif nmr == 0:
    print(f'O número é {nmr} (zero).')
else:
    print(f'O número {nmr} é negativo.')