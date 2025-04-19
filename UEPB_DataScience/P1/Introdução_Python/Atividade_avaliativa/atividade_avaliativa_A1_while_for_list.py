
'''
esdras contratar desenvolvedores
aluno: matrícula, nome, cpf, email, média e situação 
armazenar para 46 alunos
pode encerrar a qualquer momento
situacao e reprovado automático

                !!!!ATENÇÃO!!!!

RESOLUÇÃO 1 | 1 - cadastrar aluno.
RESOLUÇÃO 2 | 3 - Atribuir situação dos alunos.
RESOLUÇÃO 3 | 4 - Relatório.
RESOLUÇÃO 4 | 4 - Relatório. > 3 - RELATÓRIO | Alunos cuja média individual excede a média geral da turma
'''

#QUESTÂO 1-----------------------------------------------------------

matricula = [''] * 46
nome = [''] * 46
cpf = [''] * 46
email = [''] * 46
media = [0] * 46
situacao = [''] * 46
cadastrados = 0
relatorio = False

while True:
    print('')
    print('1 - Cadastrar aluno.')
    print('2 - Alunos cadastrados.')
    print('3 - Atribuir situação dos alunos.')
    print('4 - Relatório.')
    print('5 - Sair do sistema.')
    op = int(input('Selecione uma opção: '))
    print()
    
    if op == 1: 
        if cadastrados < 46:
            matricula[cadastrados] = int(input('Matrícula: '))
            nome[cadastrados] = input('nome: ')
            cpf[cadastrados] = input('cpf: ')
            email[cadastrados] = input('e-mail: ')
            media[cadastrados] = float(input('Média: '))
            print('Cadastro realizado com sucesso.')
            cadastrados +=1
            relatorio = False
        else:
            print('Quantidade máxima de cadastros atingido.')
    elif op == 2:
        if cadastrados > 0:
            print('Alunos cadastrados:', cadastrados)
            print()
            for i in range(cadastrados):
                print('Matrícula:', matricula[i])
                print('Nome:', nome[i])
                print('Cpf:', cpf[i])
                print('E-mail:', email[i])
                print('Média:', media[i])
                print('Situação:', situacao[i])
                print('----------------------------------------')
        else:
            print('Não existem cadastros no sistema.')
#QUESTÃO 2-----------------------------------------------------------
    elif op == 3:
        if cadastrados > 0:
            for i in range(cadastrados):
                if media[i] >= 70:
                    situacao[i] = 'Aprovado'
                else:
                    situacao[i] = 'Reprovado'
                
                relatorio = True
        
            print('O diário já pode ser entregue!')
        else:
            print('Não existem cadastros no sistema.')
#QUESTÃO 3-----------------------------------------------------------
    elif op == 4:
        if cadastrados > 0:
            if relatorio == True:
                print('1 - RELATÓRIO | aprovados')
                print('2 - RELATÓRIO | reprovados')
                print('3 - RELATÓRIO | Alunos cuja média individual excede a média geral da turma')
                op_2 = int(input('Selecione uma opção: '))
                print()
                
                quant = 0
                
                if op_2 == 1:
                    for i in range(cadastrados):
                        if media[i] >= 70:
                            quant += 1
                            print('Matrícula:', matricula[i])
                            print('Nome:', nome[i])
                            print('Cpf:', cpf[i])
                            print('E-mail:', email[i])
                            print('Média:', media[i])
                            print('Situação:', situacao[i])
                            print('----------------------------------------')
                    print('Alunos aprovados: ', quant)
                elif op_2 == 2:
                    for i in range(cadastrados):
                        if media[i] < 70:
                            quant += 1
                            print('Matrícula:', matricula[i])
                            print('Nome:', nome[i])
                            print('Cpf:', cpf[i])
                            print('E-mail:', email[i])
                            print('Média:', media[i])
                            print('Situação:', situacao[i])
                            print('----------------------------------------')
                    print('Alunos reprovados: ', quant)
                #QUESTÃO 4 ------------------------------------------------------
                elif op_2 == 3:
                    media_soma = 0
                    for i in range(cadastrados):
                        media_soma += media[i]
                        
                    media_geral = media_soma / cadastrados
                    achei = False
                    for i in range(cadastrados):
                        if media[i] > media_geral:
                            achei = True
                            print(f'|Nome: {nome[i]} | média: {media[i]} | Media da turma: {media_geral:.2f}')
                            print('----------------------------------------')
                    if achei == False:
                        print('A média de nenhum aluno excede a média geral da turma.')
                else:
                    print('A opção escolhida é inesistente.')
            else:
                print('Atribua as situações dos alunos.')
        else:
            print('Não existem cadastros no sistema.')
    elif op == 5:
        print('você saiu do sistema!')
        break
    else:
        print('A opção escolhida é inesistente.')