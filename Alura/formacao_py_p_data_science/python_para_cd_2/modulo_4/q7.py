'''7. Você foi contratado(a) como uma pessoa cientista de dados
para auxiliar um laboratório que faz experimentos sobre o comportamento
de uma cultura de fungos. O laboratório precisa avaliar constantemente
a razão (divisão) entre os dados de pressão e temperatura do ambiente
controlado recolhidos durante a experimentação para definir a melhor condição
para os testes.

Para cumprir com a demanda, você precisa criar uma função divide_colunas
que recebe os dados das colunas de pressão e temperatura
(que vem no formato de listas) e gerar uma nova coluna com o resultado da
divisão. Os parâmetros da função são as duas listas e você deve tratar
dentro dela ao menos 2 tipos de exceções:

Verificar se as listas têm o mesmo tamanho (ValueError)
Verificar se existe alguma divisão por zero (ZeroDivisionError)
Para testar a função, vamos realizar a divisão entre duas listas
de dados coletados no experimento, com os valores de pressão
e temperatura do ambiente controlado.

Como teste, use os seguintes dados:'''

#dados =====================================================

#dados se exceção
pressoes1 = [100, 120, 140, 160, 180]
temperaturas1 = [20, 25, 30, 35, 40]

#dados com exceção
#Exceção de ZeroDivisionError
pressoes2 = [60, 120, 140, 160, 180]
temperaturas2 = [0, 25, 30, 35, 40]

# Exceção de ValueError
pressoes3 = [100, 120, 140, 160]
temperaturas3 = [20, 25, 30, 35, 40]

#criando função =============================================

def razao(pressoes, temperaturas):
    try:
        if len(pressoes) != len(temperaturas): #Verificando se as listas tem o mesmo tamanho
            raise ValueError('A quantidade de elementos em cada lista é diferente.')
        razao = [p/t for p,t in zip(pressoes, temperaturas)]
        return razao
    
    #tratando erros
    except ValueError:
        print('A quantidade de elementos em cada lista é diferente.')
        return None
    except ZeroDivisionError:
        print('Não é possível dividir por Zero.')
        return None
    except Exception as erro:
        print(type(erro), f'Erro: {erro}')
        return None
        
#testando ===================================================

print(razao(pressoes1, temperaturas1))
print(razao(pressoes2, temperaturas2))
print(razao(pressoes3, temperaturas3))

