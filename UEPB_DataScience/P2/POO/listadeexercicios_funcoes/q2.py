'''Escreva um programa para ler as notas das três avaliações de um aluno no
bimestre. Também faça uma função que receba as notas por parâmetro,
calcule e retorne a média bimestral. Por fim, escreva a mensagem de Aprovado
ou Recuperação.'''

#criando funções

def average_situation(n1, n2, n3):
    #tirando a média
    m = (n1 + n2 + n3) / 3
    #situação
    s = None
    if m >= 7:
        s = 'aprovado'
    else:
        s = 'reprovado'
        
    return [m, s]

#recebendo dados

n1 = float(input('digite a nta da primeira avaliação: '))
n2 = float(input('digite a nta da segunda avaliação: '))
n3 = float(input('digite a nta da terceira avaliação: '))

#testando função

situation = average_situation(n1, n2, n3)
print(f'a média bimestral do aluno(a) foi {situation[0]:.2f} e ele está {situation[1]}')