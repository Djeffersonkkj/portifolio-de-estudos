'''9. Você recebeu o desafio de criar um código que calcula os gastos
de uma viagem para um das quatro cidades partindo de Recife, sendo elas:
Salvador, Fortaleza, Natal e Aracaju.

O custo da diária do hotel é de 150 reais em todas elas e o consumo de
gasolina na viagem de carro é de 14 km/l, sendo que o valor da gasolina 
é de 5 reais o litro. O gastos com passeios e alimentação a se fazer em 
cada uma delas por dia seria de [200, 400, 250, 300], respectivamente.

Sabendo que as distâncias entre Recife e cada uma das cidades é de 
aproximadamente [850, 800, 300, 550] km, crie três funções nas quais: 
a 1ª função calcule os gastos com hotel (gasto_hotel), a 2ª calcule os 
gastos com a gasolina (gasto_gasolina) e a 3ª os gastos com passeio e
alimentação (gasto_passeio).

Para testar, simule uma viagem de 3 dias para Salvador partindo de
Recife. Considere a viagem de ida e volta de carro.'''

#dados
diaria = 150

salvador = {'food': 200, 'km': 850}
fortaleza =  {'food': 400, 'km': 800}
natal =  {'food': 250, 'km': 300}
aracaju =  {'food': 300, 'km': 550}

cidade = int(input('1| SALVADOR \n2| FORTALEZA \n3| NATAL \n4| ARACAJU \nescolha a cidade: '))
if cidade == 1:
    cidade = salvador
elif cidade == 2:
    cidade = fortaleza
elif cidade == 3:
    cidade = natal
elif cidade == 4:
    cidade = aracaju
    
dias = int(input('digite quantos dias de viagem: '))

#funções
def gasto_hotel(dias):
    return dias * diaria

def gasto_gasolina(km):
    return (km / 14) * 5  

def gasto_passeio(dias, cidade):
    return dias * cidade['food'] 

gasto_total_hotel = gasto_hotel(dias)
gasto_total_gasolina = gasto_gasolina(cidade['km']) * 2  # Ida e volta
gasto_total_passeio = gasto_passeio(dias, cidade)

# Exibição
print(f'Sua viagem terá um gasto de R${gasto_total_hotel:.2f} com hotel, '
      f'R${gasto_total_gasolina:.2f} com gasolina e '
      f'R${gasto_total_passeio:.2f} com passeio.')