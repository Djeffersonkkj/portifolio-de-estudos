'''Faça uma função que calcule o IMC (peso/altura*altura) de uma pessoa e conforme o
seu retorno classifique, no programa principal, conforme a tabela abaixo:'''

#criando função
def imc(altura, peso):
    imc = peso / (altura * altura)
    return imc

#recebendo dados
peso = float(input('digite o peso da pessoa em kg: '))
altura = float(input('digite a altura da pessoa em metros: '))

#classificando o resultado do imc
imc_pessoa = imc(altura, peso)
situation = None
if imc_pessoa < 18.5:
    situation = 'abaixo do peso'
elif 18.5 <= imc_pessoa <= 25:
    situation = 'peso normal'
elif 25.1 <= imc_pessoa <= 30:
    situation = 'acima do peso'
else:
    situation = 'obeso'
    
#exibindo resultado

print(f'o imc da pessoa é {imc_pessoa:.2f}, e sua classificação é "{situation}"')