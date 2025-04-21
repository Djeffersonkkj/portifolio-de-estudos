'''1. Faça um programa que solicite à pessoa usuária digitar dois 
números float e calcular a divisão entre esses números. O código deve
conter um tratamento de erro, indicando o tipo de erro que foi gerado
caso a divisão não seja possível de realizar.

Teste o programa com o segundo valor numérico do input igual a 0. Também
teste utilizando caracteres textuais no input para checar os tipos de erro que ocorrem.'''

#coleta de dados e divisão e tratamento de erro.
try:
    n1 = float(input('Digite o primeiro número: '))
    n2 = float(input('Digite o segundo número: '))
    print(f'O resultado da divisão de {n1} por {n2} é: {n1/n2 :.2f}')
except Exception as e:
    print(type(e), f'erro: {e}')
