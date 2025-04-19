#Q:5 - Crie um programa que avalie se três números podem ser lados de um triângulo. Para serem lados
#de um triângulo, a soma de dois lados deve ser maior que o terceiro lado.

lado_1 = float(input('Digite o primeiro lado do triângulo: '))
lado_2 = float(input('Digite o segundo lado do triângulo: '))
lado_3 = float(input('Digite o terceiro lado do triângulo: '))

if lado_1 + lado_2 > lado_3 and lado_1 + lado_3 > lado_2 and lado_2 + lado_3 > lado_1:
    print('É possível criar um triângulo com esses valores.')
else:
    print('Não é possível criar um triângulo com esses valores.')