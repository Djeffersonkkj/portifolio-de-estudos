#Q:16 - Desenvolva um programa que simule um sistema de login, onde o usuário deve digitar um nome
#de usuário e uma senha. O programa deve permitir o acesso apenas se o nome de usuário for "cd2" e a
#senha for "cd2_123". Mostra a mensagem informando usuário logado com sucesso ou login e/ou senha
#invalido.

usuario = input('usuário: ')
senha = input('senha: ')

if usuario in ['cd2'] and senha in ['cd2_123']:
    print('Você foi logado com sucesso.')
else:
    print('login e/ou senha invalido.')