'''3. Crie a função que leia a lista abaixo e 
retorne uma nova lista com os múltiplos de 3:
Utilize o return na função e salve a nova lista
na variável mult_3.'''

#variável
lista = [97, 80, 94, 88, 80, 1, 16, 53, 62, 32, 24, 99]

#função
def multiplo3(a):
    mult_3 = []
    for x in a:
        divisão = x % 3
        if divisão == 0:
            mult_3.append(x)
    return(mult_3)

print(multiplo3(lista))