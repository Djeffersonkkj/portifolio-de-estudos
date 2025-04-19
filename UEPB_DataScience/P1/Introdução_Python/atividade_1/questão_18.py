#Q:18 - Escreva um programa que leia o nome de um mês e e'x'iba o número correspondente.

mes_nome = input('Escreva o nome do mês que deseja saber o número: ')

if mes_nome in ['Janeiro','janeiro','Jan','Jan']:
    print('Janeiro é o mês 1.')
elif mes_nome in ["Fevereiro", 'fevereiro', 'fev', 'Fev']:
    print('Fevereiro é o mês 2.')
elif mes_nome in ['Março', 'março', 'Mar', 'mar']:
    print('Março é o mês 3.')
elif mes_nome in ['Abril', 'abril', 'Abr', 'abr']:
    print('Abril é o mês 4.')
elif mes_nome in ['Maio', 'maio', 'Mai', 'mai']:
    print('Maio é o mês 5.')
elif mes_nome in ['Junho', 'junho', 'Jun', 'jun']:
    print('Junho é o mês 6.')
elif mes_nome in ['Julho', 'julho', 'jul', 'Jul']:
    print('Julho é o mês 7.')
elif mes_nome in ['Agosto', 'agosto', 'ago', 'Ago']:
    print('Agosto é o mês 8.')
elif mes_nome in ['Setembro', 'setembro', 'Set', 'set']:
    print('Setembro é o mês 9.')
elif mes_nome in ['Outubro', 'outubro', 'Out', 'out']:
    print('Outubro é o mês 10.')
elif mes_nome in ['Novembro', 'novembro', 'Nov', 'nov']:
    print('Novembro é o mês 11.')
elif mes_nome in ['Dezembro', 'dezembro', 'dez', 'Dez']:
    print('Dezembro é o mês 12.')
else:
    print('O mês que você digitou é invalido.\n\
Verifique se algum caractere está incorreto.\n\
Você pode digitar o nome completo do mês ou as 3 primeiras letras em português.')