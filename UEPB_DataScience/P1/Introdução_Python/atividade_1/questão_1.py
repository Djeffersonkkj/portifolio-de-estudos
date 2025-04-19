"""
Q:1 - Escreva um programa que recebe a idade de uma pessoa e imprime "Maior de idade" se a idade
for maior ou igual a 18, ou "Menor de idade" caso contrário.
"""

idade = int(input("Informe uma idade: "))

if idade >= 18:
    print('Maior de idade.')
else:
    print('Menor de idade.')
