'''7. Você recebeu uma demanda para tratar 2 listas com os nomes e 
sobrenomes de cada estudante concatenando-as para apresentar seus nomes
completos na forma Nome Sobrenome. As listas são:'''

nomes = ["joão", "MaRia", "JOSÉ"]
sobrenomes = ["SILVA", "souza", "Tavares"]

def nome_completo(a, b):
    #tratamento de dados
    nomes_tratados = [n.capitalize() for n in nomes]
    sobrenomes_tratados = [s.capitalize() for s in sobrenomes]
    
    nomes_completos = [f'{n} {s}' for n, s in zip(nomes_tratados, sobrenomes_tratados)]
    return nomes_completos
    
        
        

print(nome_completo(nomes, sobrenomes))