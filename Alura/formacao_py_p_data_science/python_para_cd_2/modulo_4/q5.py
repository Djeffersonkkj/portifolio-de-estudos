'''5. Como desafio, você recebeu a tarefa de desenvolver um código
que contabiliza as pontuações de estudantes de uma instituição de ensino
de acordo com suas respostas num teste. Este código deve ser testado
para um exemplo de 3 estudantes com uma lista de listas em que cada lista
possui as respostas de 5 questões objetivas de cada estudante. Cada
questão vale um ponto e as alternativas possíveis são A, B, C ou D.

Caso alguma alternativa em um dos testes não esteja entre as alternativas
possíveis, você deve lançar um ValueError com a mensagem "A alternativa
[alternativa] não é uma opção de alternativa válida". O cálculo das 3 notas
só será realizado mediante as entradas com as alternativas A, B, C ou D em

Os dados para o teste do código são:'''

#Gabarito da prova
gabarito = ['D', 'A', 'B', 'C', 'A']

#Notas sem exceção
testes_sem_ex = [['D', 'A', 'B', 'C', 'A'], ['C', 'A', 'A', 'C', 'A'], ['D', 'B', 'A', 'C', 'A']]

#Notas com exceção
testes_com_ex = [['D', 'A', 'B', 'C', 'A'], ['C', 'A', 'A', 'E', 'A'], ['D', 'B', 'A', 'C', 'A']]

def correcao(gabarito, respostas):
    try:
        notas = []
        for g in respostas:
            quest = 0
            for i in range(len(g)):
                if g[i] not in ['A', 'B', 'C', 'D']: #testando se todas as questôes são válidas
                    raise ValueError(f"A alternativa {g[i]} não é uma opção de alternativa válida")
                if g[i] == gabarito[i]:
                    quest += 1
            notas.append(quest)
        return notas
    except Exception as erro:
        print(type(erro), f'Erro: {erro}')
        return None

#testando
print(correcao(gabarito, testes_sem_ex))
print(correcao(gabarito, testes_com_ex))