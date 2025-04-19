#1. Escreva um código que lê a lista abaixo e faça:
#A leitura do tamanho da lista
#A leitura do maior e menor valor
#A soma dos valores da lista
#Ao final exiba uma mensagem dizendo: "A lista possui [tam] números em que o maior número 
# é [maior] e o menor número é [menor]. A soma dos valores presentes nela é igual a [soma]"
lista = [16, 14, 63, 65, 17, 99, 70, 11, 20, 48, 79, 32, 17, 89, 12, 25, 66]

tam_lista = len(lista)
max_lista = max(lista)
min_lista = min(lista)
soma_lista = sum(lista)

print(f'"A lista possui {tam_lista} números em que o maior número é {max_lista}\n e o menor número é {min_lista}. A soma dos valores presentes nela é igual a {soma_lista}"')