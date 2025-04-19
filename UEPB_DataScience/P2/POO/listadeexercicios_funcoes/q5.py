'''Crie uma função que receba por parâmetro um número inteiro e verifique se o
número é positivo ou negativo. Retorne o valor lógico (verdadeiro ou falso).'''

#criando função 
def negatico_ou_positivo(n):
    '''quando positivo retorna True, negativo retorna False
    e 0 retorna None'''
    resultado = None
    if n > 0:
        resultado = True
    elif n < 0:
        resultado = False
        
    return resultado

#recebendo dados
numero = int(input('digite um número inteiro: '))

#exibindo
print(negatico_ou_positivo(numero))