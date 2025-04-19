#FEITO POR: Djefferson dos Santos Lima ; Lucas Edson da Silva Cosendey
input('by Djefferson dos Santos Lima ; Lucas Edson da Silva Cosendey\nPressione ENTER para começar...')

#importanto função para limpar terminal-------------------------------------------------------
import os
def clear():
    os.system('cls' if os.name == 'nt' else 'clear')

#classe e lista dos alunos--------------------------------------------------------------------
turma = []

class Aluno():
    def __init__(self, nome, matricula):
        self.nome = nome
        self.matricula = matricula
        self.n1_et1 = None
        self.n2_et1 = None
        self.n1_et2 = None
        self.n2_et2 = None
        self.status = None
        self.mediaanual = None
        
    def addnotas(self, n1_et1, n2_et1, n1_et2, n2_et2):
        self.n1_et1 = n1_et1
        self.n2_et1 = n2_et1
        self.n1_et2 = n1_et2
        self.n2_et2 = n2_et2
        print('NOTAS ADICIONADAS COM SUCESSO!')
        
    def notascadastradas(self):
        return (self.n1_et1 is not None and self.n2_et1 is not None and self.n1_et2 is not None and self.n2_et2 is not None)

        
    def calcularmedia(self):
        self.mediaanual = (self.n1_et1 + self.n2_et1 + self.n1_et2 + self.n2_et2) / 4
        
    def atualizarstatos(self):
        if self.mediaanual >= 70:
            self.status = 'APROVADO'
        else:
            self.status = 'REPROVADO'
    
    def mostraraluno(self):
        print(f'=========== | NOME: {self.nome} | ===========')
        print(f'MATRÍCULA: {self.matricula}')
        print(f'NOTA 1 ETAPA 1: {self.n1_et1} | NOTA 2 ETAPA 1: {self.n2_et1}')
        print(f'NOTA 1 ETAPA 2: {self.n1_et2} | NOTA 2 ETAPA 2: {self.n2_et2}')
        if self.mediaanual is not None:
            print(f'MÉDIA ANUAL: {self.mediaanual:.2f}', end=' | ')
        else:
            print('MÉDIA ANUAL: NÃO CALCULADA', end=' | ')
        if self.status is not None:
            print(f'SITUAÇÃO: {self.status}\n')
        else:
            print('SITUAÇÃO: NÃO DEFINIDA\n')
        
    
#Criar um Menu de opções----------------------------------------------------------------------
while True:
    clear()
    print('================OPÇÕES================\n')
    print('|1 - Cadastrar Um Aluno')
    print('|2 - Cadastrar Notas Das Etapas')
    print('|3 - Cadastrar Média Anual')
    print('|4 - Cadastrar Status do Aluno')
    print('|5 - Lista Dos Alunos')
    print('|6 - Sair Do Sistema\n')
    try:
        op = int(input('DIGITE UMA OPÇÃO: '))
    except ValueError:
        print('!! OPÇÃO INVÁLIDA. DIGITE UM NÚMERO !!')
        input('\nPressione ENTER para continuar...')
        continue
    if op == 6:
        clear()
        print('============ VOCÊ SAIU DO SISTEMA ============')
        break
    
    elif op == 1: #cadastrando o aluno na turma
        clear()
        print('============= CADASTRAR ALUNO =============\n')
        nome = input('DIGITE O NOME COMPLETO DO ALUNO: ').upper()
        matricula = input('DIGITE A MATRICULA DO ALUNO: ').upper()
        
        existe = False #testando se a matrícula já existe no sistema
        for a in turma:
            if a.matricula == matricula:
                existe = True
                break
            
        if existe:
            clear()
            print('!!   NÃO FOI POSSÍVEL REALIZAR O CADASTRO: ESTA MATRÍCULA JÀ EXISTE NO SISTEMA   !!')
            input('\nPressione ENTER para continuar...')
            continue
        
        turma.append(Aluno(nome, matricula))
        print('| CADASTRO REALIZADO COM SUCESSO |')
        input('\nPressione ENTER para continuar...')
        
    elif op == 2:
            clear()
            print('=========== CADASTRAR NOTAS DAS ETAPAS ===========\n')
            if not turma:
                print('!!   NÃO EXISTEM ALUNOS CADASTRADOS    !!')
                input('\nPressione ENTER para continuar...')
                continue
            achei = False #verificar se existe algum aluno sem nota
            for a in turma:
                if not a.notascadastradas(): #verificar se as notas do aluno já estão cadastradas
                    print(f'ADICIONAR NOTAS - {a.nome} | matrícula: {a.matricula}')
                    try:
                        n1_et1 = int(input('Digite 1° nota da 1° etapa: '))
                        n2_et1 = int(input('Digite 2° nota da 1° etapa: '))
                        n1_et2 = int(input('Digite 1° nota da 2° etapa: '))
                        n2_et2 = int(input('Digite 2° nota da 2° etapa: '))
                    except ValueError:
                        print('!! DIGITE APENAS NÚMEROS !!')
                        input('\nPressione ENTER para continuar...')
                        continue
                    clear()
                    a.addnotas(n1_et1, n2_et1, n1_et2, n2_et2)
                    achei = True 
            if not achei:
                print('!!   TODOS OS ALUNOS ESTÃO COM AS NOTAS CADASTRADAS   !!')
                input('\nPressione ENTER para continuar...')

    elif op == 3:
        clear()
        if not turma:
                print('!!   NÃO EXISTEM ALUNOS CADASTRADOS    !!')
                input('\nPressione ENTER para continuar...')

                continue
        achei = False
        for a in turma:
            if a.notascadastradas():
                a.calcularmedia()
            if not a.notascadastradas():
                achei = True
        print('MÉDIAS ANUAIS CADASTRADAS')
        if achei == True:
            print('!!   EXISTEM ALUNOS SEM NOTAS CADASTRADAS   !!')
        input('\nPressione ENTER para continuar...')

        
    elif op == 4:
        if not turma:
                print('!!   NÃO EXISTEM ALUNOS CADASTRADOS    !!')
                input('\nPressione ENTER para continuar...')
                continue
        achei = False #verificar se existe algum aluno cujo a nota não esteja cadastrada
        for a in turma:
            if a.notascadastradas():
                a.atualizarstatos()
            if not a.notascadastradas():
                achei = True
        
        print('SITUAÇÕES CADASTRADAS')
        if achei:
            print('!!  EXISTEM ALUNOS SEM NOTAS CADASTRADAS  !!')
        input('\nPressione ENTER para continuar...')

            
    elif op == 5:
        clear()
        if not turma:
            print('!!   NÃO EXISTEM ALUNOS CADASTRADOS    !!')
            input('\nPressione ENTER para continuar...')
            continue
        for a in turma:
            a.mostraraluno()
        input('\nPressione ENTER para continuar...')
