'''
Q:2 - Crie um programa que solicita dois números ao usuário e exibe o maior deles.
'''

nmr_A = int(input('digite o primeiro número: '))
nmr_B = int(input('digite o segundo número: '))

if nmr_A > nmr_B:
    print(f'O número {nmr_A} é maior que {nmr_B}.')
elif nmr_A == nmr_B:
    print(f'Ambos possuem o mesmo valor.')
else:
    print(f'O número {nmr_B} é maior que {nmr_A}.')