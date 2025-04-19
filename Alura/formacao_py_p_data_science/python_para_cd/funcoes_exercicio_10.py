'''10. Você iniciou um estágio em uma empresa que trabalha com processamento
de linguagem natural (NLP). Sua líder requisitou que você criasse um trecho de
código que recebe uma frase digitada pela pessoa usuária e filtre apenas as
palavras com tamanho maior ou igual a 5, exibindo-as em uma lista. Essa demanda
é voltada para a análise do padrão de comportamento de pessoas na escrita de
palavras acima dessa quantidade de caracteres.

Dica: utilize as funções lambda e filter() para filtrar essas palavras. Lembrando 
que a função embutida filter() recebe uma função (no nosso exemplo uma função lambda)
e filtra um iterável de acordo com a função. Para tratar a frase use replace() para
trocar a ',' '.', '!' e '?' por espaço.

Use a frase "Aprender Python aqui na Alura é muito bom" para testar o código.

Caso precise de ajuda, opções de solução das atividades estão disponíveis na seção “Opinião da pessoa instrutora”.

OBS: Caso ainda não tenha o notebook dos desafios aproveite para baixá-lo agora.
Ele possui as células e textos para você construir suas soluções e pode te ajudar
a verificar seus códigos. Você pode baixar ele para resolver as atividades e
desafios testando os seus conhecimentos até o momento.'''

frase = input('digite a frase: ')
frase = frase.replace(',',' ').replace('.',' ').replace('!',' ').replace('?',' ')
frase = frase.split()
palavras_filtradas = list((filter(lambda palavra: len(palavra) >= 5, frase)))

print(palavras_filtradas)