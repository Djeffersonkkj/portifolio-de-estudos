#Escrever um algoritmo que imprima a tabuada de um número informado pelo usuário;

nmr_tabuada = int(input("digite o número que você deseja saber a tabuada: "))
x = 0

while x <= 10:
    multiplicação = int(nmr_tabuada*x)
    print (f"{nmr_tabuada} x {x} = {multiplicação} ")
    x = x + 1

