'''Faça uma função que recebe, por parâmetro, a altura (alt) e o sexo de uma
pessoa e retorna o seu peso ideal. Para homens, calcular o peso ideal usando a
fórmula peso ideal = 72.7 * alt - 58 e, para mulheres, peso ideal = 62.1 * alt -
44.7.'''

#criando função
def peso_ideal(altura, sexo):
    peso_i = None
    sexo = sexo.lower()
    if sexo in ['homem', 'masculino', 'm']:
        peso_i = 72.7 * altura - 58
    elif sexo in ['mulher', 'feminino', 'f']:
        peso_i = 62.1 * altura - 44.7
    return peso_i

#recebendo dados
sexo = input('digite o sexo da pessoa (masculino ou feminino): ')
alt = float(input('digite a altura da pessoa em metros: '))

#exibindo
print(f'o peso ideal para a esta pessoa é:  {peso_ideal(alt, sexo):.2f}')