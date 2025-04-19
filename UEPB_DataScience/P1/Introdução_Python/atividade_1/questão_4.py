'''
Q:4 - Escreva um programa que calcule o preço a pagar por um produto, considerando um desconto de
10% caso o valor total seja maior que R$ 100,00.
'''

produto_valor = float(input('Informe o valor do produto: '))
desconto = produto_valor * 0.1

if produto_valor <= 100:
    print(f'O valor do seu produto não se qualifica para o desconto.\n\
Adicione mais R${101 - produto_valor:.2f} à sua compra e receba 10% de desconto.')
else:
    print(f'O valor do seu produdo se qualifica para o desconto de 10%.\n\
O valor a pagar será R${produto_valor:.2f} - R${desconto:.2f} = R${produto_valor - (desconto):.2f}')