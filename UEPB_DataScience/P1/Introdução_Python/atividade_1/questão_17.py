#Q:17 - Elabore um programa que leia o valor de três produtos e informe qual deles é o mais barato.

produto_1 = float(input('Digite o valor do primeiro produto: R$'))
produto_2 = float(input('Digite o valor do segundo produto: R$'))
produto_3 = float(input('Digite o valor do terceiro produto: R$'))

if produto_2 and produto_3 > produto_1:
    print(f'O primeiro produto, com o valor de R${produto_1:.2f} , é o mais barato.')
elif produto_1 and produto_3 > produto_2:
    print(f'O segundo produto, com o valor de R${produto_2:.2f} , é o mais barato ')
elif produto_1 and produto_2 > produto_3:
    print(f'O terceiro produto, com o valor de R${produto_3:.2f} , é o mais barato.')
elif produto_1 and produto_2 < produto_3:
    print(f'O primeiro e o segundo produto, com os valores de R${produto_1:.2f} , são os mais baratos.')
elif produto_1 and produto_3 < produto_2:
    print(f'O primeiro e o terceiro produto, com os valores de R${produto_1:.2f} , são os mais baratos.')
elif produto_2 and produto_3 < produto_1:
    print(f'O segundo e o terceiro produto, com os valores de R${produto_2:.2f} , são os mais baratos.')
elif produto_1 == produto_2 == produto_3:
    print('Os três produtos possuem o mesmo valor.')