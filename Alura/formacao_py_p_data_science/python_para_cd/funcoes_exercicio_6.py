'''6. Para atender a uma demanda de uma instituição de ensino para a 
análise do desempenho de seus(suas) estudantes, você precisa criar uma
função que receba uma lista de 4 notas e retorne:

maior nota
menor nota
média
situação (Aprovado(a) ou Reprovado(a))
Para testar o comportamento da função, os dados podem ser exibidos em
um texto:'''

#recebendo dados
notas = []
x = 1
while x <= 4:
    nota = float(input(f'digite a {x}° nota do aluno: '))
    notas.append(nota)
    x += 1
    
#função de tratamento de dados
def situation(n):
    maior_nota = max(notas)
    menor_nota = min(notas)
    media = (sum(notas)) / len(notas)
    situacao = None
    if media >= 7:
        situacao = 'aprovado'
    else:
        situacao = 'reprovado'
    return maior_nota, menor_nota, media, situacao

#testando
maior, menor, media, situacao = situation(notas)
print(f"O(a) estudante obteve uma média de {media}, com a sua maior nota\
de {maior} pontos e a menor nota de {menor} pontos e foi {situacao}")