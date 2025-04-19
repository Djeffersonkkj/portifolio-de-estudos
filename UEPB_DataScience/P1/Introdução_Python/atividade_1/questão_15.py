#Faça um programa que leia três notas de um aluno e calcule a média ponderada, considerando os
#pesos 2, 3 e 5 para as notas.


nota_p2 = float(input('Escreva uma nota do aluno (peso 2):'))
nota_p3 = float(input('Escreva uma nota do aluno (peso 3):'))
nota_p5 = float(input('Escreva uma nota do aluno (peso 5):'))

media_ponderada = (2 * nota_p2 + 3 * nota_p3 + 5 * nota_p5) / (2 + 3 + 5)
print(f'A média ponderada do aluno é: {media_ponderada}')
