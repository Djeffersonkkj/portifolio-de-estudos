#Escreva um programa que leia um número de 1 a 7 e imprima o dia da semana correspondente
#(considerando 1 como domingo, 2 como segunda-feira, etc.).

semana_nmr = int(input("Digite o valor de um dia da semana: "))

if semana_nmr == 1:
    print('O valor 1 equivale ao domingo.')
elif semana_nmr == 2:
    print('O valor 2 equivale à segunda-feira.')
elif semana_nmr == 3:
    print('O valor 3 equivale à terça-feira.')
elif semana_nmr == 4:
    print('O valor 4 equivale à quarta-feira.')
elif semana_nmr == 5:
    print('O valor 5 equivale à quinta-feira.')
elif semana_nmr == 6:
    print('O valor 6 equivale à sexta-feira')
elif semana_nmr == 7:
    print('O valor 7 equivale ao sábado')
else:
    print('O valor que você digitou é inválido.\nDigite um número entre 1 e 7')