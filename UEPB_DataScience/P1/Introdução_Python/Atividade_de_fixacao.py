'''
Criar um menu de opções e implementar soluções para todas as questões. O usuário
deverá escolher uma opção para finalizar o laço.

1) Usando while, crie um algoritmo que exibe uma pirâmide semelhante a abaixo, sendo que o maior
valor n da pirâmide é definido pelo usuário. Ex: n=9

2) Construa um programa, usando while, que leia n números, ao fim deverá mostrar quantos
números foram digitados e a soma desses números, lembrando que o número zero será o último
número digitado e não entrará na soma dos valores.

3) Na matemática, um número abundante é um número inteiro cuja soma de todos os seus divisores
positivos próprios(excluindo ele mesmo) é maior do que o próprio número. Construa um programa
que receba um número inteiro e que verifique se ele é um número abundante. Escreva uma
mensagem informando se o número é ou não abundante.

4) Foi feita uma estatística entre os alunos de uma universidade a fim de identificar o grau de
adequação de seus alunos aos cursos. Nesta estatística foi perguntado: * qual o curso que faz
(Administração, Computação, Medicina, Direito e Jornalismo); * Qual o motivo da escolha (opções:
remuneração obtida pela profissão; aptidão ou outros); * idade; * Gênero. Escreva um algoritmo que
leia os dados desta pesquisa (para finalizar a entrada de dados será digitado "FIM") e apresente os
seguintes dados estatísticos: * quantos alunos com idade inferior a 20 anos escolheu seu curso por
aptidão; * qual o percentual de alunos em cada um dos cursos em relação ao total; * Qual a média
de idade dos alunos em Computação; * Qual o nome, idade e curso selecionado pelo aluno mais
jovem que escolheu o seu curso devido à remuneração.
'''

while True:

    print('--------------------ATIVIDADE--------------------\n')
    print('1 |RESOLUÇÃO 1')
    print('2 |RESOLUÇÃO 2')
    print('3 |RESOLUÇÃO 3')
    print('4 |RESOLUÇÃO 4')
    print('0 |SAIR')
    op = int(input('DIGITE UMA OPÇÃO: '))
    
    if op == 1:
        print('-------------------QUESTÃO 1-------------------\n')
        tam = int(input('DIGITE UM NÚMERO POSITIVO INTEIRO: '))
        piramide = [0] * tam
        valor = 1
        indice = 0
        indice_2 = 0
        while indice < len(piramide):
            piramide[indice] = valor
            valor += 1
            indice += 1
        while tam > 0: 
            while indice_2 < len(piramide):
                print(piramide[indice_2], end= ' ')
                indice_2 += 1
            print()
            del piramide[0]
            tam -= 1
            indice_2 = 0
    elif op == 2:
        print('-------------------QUESTÃO 2-------------------\n')
        n = 0
        q = 0
        while True:
            print('0 |PARA FINALIZAR A OPERAÇÃO')
            adicionar = float(input('DIGITE UM VALOR POSITIVO: '))
            if adicionar > 0:
                n = adicionar + n
                q += 1
            elif adicionar == 0:
                print()
                print(f'SOMA DOS VALORES: {n}')
                print(f'VALORES DIGITADOS: {q}')
                break
            else:
                print('Valor inválido!')
    elif op == 3:
        print('-------------------QUESTÃO 3-------------------\n')
        n = int(input('DIGITE UM NÚMERO INTEIRO POSITIVO: '))
        soma = 0
        for i in range(1, n):
            if n % i == 0:
                soma += i
        if soma > n:
            print()
            print(f'O NÚMERO {n} É ABUNDANTE!')
        elif soma < n:
            print()
            print(f'O NÚMERO {n} NÃO É ABUNDANTE!')
    elif op == 4:
            print('-------------------QUESTÃO 4-------------------\n')
            maximo = 500
            aluno = [''] * maximo
            curso = [0] * maximo
            motivo = [0] * maximo
            idade = [0] * maximo
            genero = [0] * maximo
            cadastrados = 0
            
            while True:
                print()
                print('DIGITE "FIM" PARA FINALIZAR')
                op_2 = input('CADASTRAR ALUNO: ')
                
                if cadastrados < maximo:
                    if op_2 in ['FIM', 'fim', 'Fim']:
                        i_menor20_aptidão = 0
                        t_administracao = 0
                        t_computacao = 0
                        t_medicina = 0
                        t_direito = 0
                        t_jornalismo = 0
                        idades_computação = 0
                        for i in range(cadastrados):
                            if idade[i] < 20 and motivo[i] == 2:
                                i_menor20_aptidão += 1
                            if curso[i] == 1:
                                t_administracao += 1
                            if curso[i] == 2:
                                t_computacao += 1
                                idades_computação += idade[i]
                            if curso[i] == 3:
                                t_medicina += 1
                            if curso[i] == 4:
                                t_direito += 1
                            if curso[i] == 5:
                                t_jornalismo += 1
                        print()
                        print(f'Alunos com idade inferior a 20 que escolheram por aptidão: {i_menor20_aptidão}\n')
                        print(f'ALUNOS EM ADMINISTRAÇÃO: {t_administracao/cadastrados * 100 :.2f}%') 
                        print(f'ALUNOS EM COMPUTAÇÃO: {t_computacao/cadastrados * 100 :.2f}%')
                        print(f'ALUNOS EM MEDICINA: {t_medicina/cadastrados * 100 :.2f}%')
                        print(f'ALUNOS EM DIREITO: {t_direito/cadastrados * 100 :.2f}%')
                        print(f'ALUNOS EM JORNALISMO: {t_jornalismo/cadastrados * 100 :.2f}%\n')
                        if t_computacao > 0:
                            print(f'MÉDIA DE IDADE DOS ALUNOS EM COMPUTAÇÃO: {idades_computação/t_computacao :.2f}\n')
                        else:
                            print(f'MÉDIA DE IDADE DOS ALUNOS EM COMPUTAÇÃO: não há alunos nesse curso')
                        mais_jovem = min(idade[:cadastrados])
                        print('ALUNOS MAIS JOVENS:')
                        for i in range(cadastrados):
                            if idade[i] == mais_jovem:
                                name_curso = [0, 'Administração', 'Computação', 'Medicina', 'Direito', 'Jornalismo']
                                print(f'NOME: {aluno[i]} | IDADE: {idade[i]} | CURSO: {name_curso[curso[i]]}')
                        break
                    else:
                        aluno[cadastrados] = op_2
                        print(f'----------------{aluno[cadastrados].upper()}----------------')
                        print('CURSO:')
                        print('1 |Administração')
                        print('2 |Computação')
                        print('3 |Medicina')
                        print('4 |Direito')
                        print('5 |Jornalismo')
                        curso[cadastrados] = int(input('DIGITE UMA OPÇÃO: '))
                            
                        print()
                        print('MOTIVO DA ESCOLHA:')
                        print('1 |Remuneração obtida pela profissão')
                        print('2 |aptidão')
                        print('3 |outros')
                        motivo[cadastrados] = int(input('SELECIONE UMA OPÇÃO: '))
                        
                        print()
                        idade[cadastrados] = int(input('IDADE: '))
                        
                        print()
                        print('1 |Masculino')
                        print('2 |Feminino')
                        print('3 |Não-binário')
                        print('4 |Outro')
                        genero[cadastrados] = int(input('DIGITE UMA OPÇÃO: '))
                        cadastrados += 1
                else:
                    print('LIMITE DE CADASTROS ATINGIDO!')
                    i_menor20_aptidão = 0
                    t_administracao = 0
                    t_computacao = 0
                    t_medicina = 0
                    t_direito = 0
                    t_jornalismo = 0
                    idades_computação = 0
                    for i in range(cadastrados):
                        if idade[i] < 20 and motivo[i] == 2:
                            i_menor20_aptidão += 1
                        if curso[i] == 1:
                            t_administracao += 1
                        if curso[i] == 2:
                            t_computacao += 1
                            idades_computação += idade[i]
                        if curso[i] == 3:
                            t_medicina += 1
                        if curso[i] == 4:
                            t_direito += 1
                        if curso[i] == 5:
                            t_jornalismo += 1
                    print(f'Alunos com idade inferior a 20 que escolheram por aptidão: {i_menor20_aptidão}\n')
                    print(f'ALUNOS EM ADMINISTRAÇÃO: {t_administracao/cadastrados * 100 :.2f}%') 
                    print(f'ALUNOS EM COMPUTAÇÃO: {t_computacao/cadastrados * 100 :.2f}%')
                    print(f'ALUNOS EM MEDICINA: {t_medicina/cadastrados * 100 :.2f}%')
                    print(f'ALUNOS EM DIREITO: {t_direito/cadastrados * 100 :.2f}%')
                    print(f'ALUNOS EM JORNALISMO: {t_jornalismo/cadastrados * 100 :.2f}%\n')
                    if t_computacao > 0:
                        print(f'MÉDIA DE IDADE DOS ALUNOS EM COMPUTAÇÃO: {idades_computação/t_computacao :.2f}\n')
                    else:
                        print(f'MÉDIA DE IDADE DOS ALUNOS EM COMPUTAÇÃO: não há alunos nesse curso')
                    mais_jovem = min(idade[:cadastrados])
                    print('ALUNOS MAIS JOVENS:')
                    for i in range(cadastrados):
                        if idade[i] == mais_jovem:
                            name_curso = [0, 'Administração', 'Computação', 'Medicina', 'Direito', 'Jornalismo']
                            print(f'NOME: {aluno[i]} | IDADE: {idade[i]} | CURSO: {name_curso[curso[i]]}')
                    break
    elif op == 0:
        print('VOCÊ SAIU DO SISTEMA!')
        break
    else:
        print('Valor inválido!')