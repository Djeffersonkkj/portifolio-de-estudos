'''Faça uma função para verificar se um determinado caractere pertence a uma
string digitada pelo usuário. O retorno da função é uma mensagem indicando
se o caractere pertence ou não a string. Não utilizar as funções
predefinidas do python.'''

#criando função

def v_caractere(str, caractere):
    pertence = f'"{caractere}" NÃO pertence ao texto'
    for i in range(len(str)):
        if caractere == str[i]:
            pertence = f'"{caractere}" PERTENCE ao texto'
            break
    return pertence

#recebendo dados
texto = input('digite uma frase: ')
caractere = input('digite o caractere que deseja ver se pertence ao texto: ')

#exibindo
print(v_caractere(texto, caractere))