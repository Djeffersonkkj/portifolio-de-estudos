import numpy as np #estou importando a biblioteca numpy e dizendo que seu prefixo será np

#trazer os arquivos para o código

dados = np.loadtxt('apples_ts.csv' ,delimiter=',', usecols=np.arange(1,88,1))

'''
sintaxe:
    np.loadtxt       | é a função para importar o outro arquivo de texto
    ('apples_ts.csv' | é o nome do arquivo que quero importar
    ,delimiter=',')  | é o que delimita cada informação no arquivo usado
    
Como no arquivo a primeira coluna é de str, a função não vai funcionar, pois
ela só funciona com float e int. Para solucionar as str devem ser removidas do array.
    usecols=    | fala as colunas que vão ser usadas
    np.arange() | gera um array com os valores especificados
'''

#fazendo a transposição dos dados (troca linha por coluna)
dados_transposto = dados.T