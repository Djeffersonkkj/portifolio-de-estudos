#Escrever um programa de computador que leia 10 números positivos e, ao final, apresente a soma de todos
#os números lidos. Você deve testar se o numero é positivo.

valor = 1
soma = 0

while valor <= 10:
    if valor >= 0:
        soma = valor + soma
    else:
        print ("erro: um dos valores é negativo.")
        valor = 10
    valor = valor + 1
    
print (f"a soma dos números de 1 até 10 é: {soma}")