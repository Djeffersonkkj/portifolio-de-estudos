#Leia 20 valores reais e escreva o seu somatório.


valores = float(1)
soma = 0

while valores <= 20:
    soma = valores + soma
    valores = valores+1
    
print (f'a soma dos números de 1 até 20 é: {soma}')
