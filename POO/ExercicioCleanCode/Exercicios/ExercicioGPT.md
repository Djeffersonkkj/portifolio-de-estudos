Boa — esse capítulo é **100% prática**, então o melhor jeito de aprender é refatorando código ruim até ele ficar legível.

Abaixo está uma **trilha de exercícios progressiva**, como se fosse um mini-treinamento de refatoração. Cada atividade foca em **um tópico específico do Capítulo 2 — Nomes Significativos** do *Código Limpo*.

👉 Todas usam **C#** e simulam situações reais.

---

# 🧠 Treinamento — Nomes Significativos (Clean Code)

## ✅ Como usar esta lista

Para cada atividade:

1. **Leia o código ruim**
2. **Renomeie apenas** (não mude lógica inicialmente)
3. Depois refatore se necessário
4. Explique em voz alta o motivo das mudanças

---

# 🟢 Nível 1 — O nome deve revelar a intenção

## 🎯 Conceito

> O nome precisa responder: *"o que isso faz?"*

---

### Atividade 1 — Variáveis misteriosas

Refatore os nomes:

```csharp
int d; // tempo em dias

if (d > 30)
{
    Console.WriteLine("Cliente antigo");
}
```

### Objetivo

Transformar em algo que não precise de comentário.

✅ Pergunta:

* O que significa `d`?

---

### Atividade 2 — Método sem intenção

```csharp
public void Processar(List<Usuario> l)
{
    foreach(var x in l)
    {
        if(x.A)
            Enviar(x);
    }
}
```

Refatore nomes de:

* método
* parâmetros
* variáveis

---

## ✔️ Você aprendeu:

* nomes devem explicar propósito
* comentários não substituem bons nomes

---

# 🟡 Nível 2 — Evitar desinformação

## 🎯 Conceito

Nomes não devem enganar.

---

### Atividade 3 — Nome mentiroso

```csharp
List<Usuario> usuariosArray = new List<Usuario>();
```

Problema?

Refatore.

---

### Atividade 4 — Similaridade perigosa

```csharp
var pedido1 = ObterPedido();
var pedidol = ObterPedido();
```

👉 Descubra o erro visual.

Refatore para evitar confusão.

---

## ✔️ Você aprendeu:

* evitar nomes parecidos
* evitar termos técnicos incorretos

---

# 🟠 Nível 3 — Faça distinções significativas

## 🎯 Conceito

Diferenças no nome devem representar diferenças reais.

---

### Atividade 5 — Ruído desnecessário

```csharp
class ProductData {}
class ProductInfo {}
class ProductObject {}
```

Pergunta:
👉 Qual a diferença entre eles?

Refatore criando nomes com significado real.

---

### Atividade 6 — Parâmetros genéricos

```csharp
void SetData(string data)
```

Refatore para algo específico.

---

## ✔️ Você aprendeu:

* palavras extras não criam significado
* “Data”, “Info”, “Manager” são suspeitos

---

# 🔵 Nível 4 — Use nomes pronunciáveis

## 🎯 Conceito

Se você não consegue falar, você não consegue discutir.

---

### Atividade 7 — Nome criptografado

```csharp
DateTime genymdhms;
```

Refatore para algo falável.

---

### Atividade 8 — Conversa entre devs

Imagine alguém dizendo:

> "O problema está no `usrPrflCfgMgr`"

Refatore o nome.

---

## ✔️ Você aprendeu:

* código é comunicação humana

---

# 🟣 Nível 5 — Use nomes pesquisáveis

## 🎯 Conceito

Evite valores difíceis de encontrar no projeto.

---

### Atividade 9 — Número mágico

```csharp
if(usuario.Idade > 18)
```

Transforme em algo pesquisável.

---

### Atividade 10 — Variável impossível de buscar

```csharp
int e = 5;
```

Refatore.

Pergunta:
👉 Como procurar isso no projeto?

---

## ✔️ Você aprendeu:

* constantes são melhores que números mágicos

---

# 🔴 Nível 6 — Evite codificação mental

## 🎯 Conceito

O leitor não deve traduzir nomes na cabeça.

---

### Atividade 11 — Prefixos desnecessários

```csharp
string strNome;
int intIdade;
```

Refatore.

---

### Atividade 12 — Notação húngara moderna 😬

```csharp
private List<Usuario> _lstUsuarios;
```

Refatore seguindo padrões modernos de C#.

---

## ✔️ Você aprendeu:

* tipo já é visível pelo compilador

---

# 🟤 Nível 7 — Classes e métodos

## 🎯 Conceito

* Classes → substantivos
* Métodos → verbos

---

### Atividade 13 — Classe mal nomeada

```csharp
class Processar
{
}
```

Refatore.

---

### Atividade 14 — Método ambíguo

```csharp
bool Usuario()
```

O que isso faz?

Refatore para um verbo claro.

---

## ✔️ Você aprendeu:

* nomes indicam responsabilidade

---

# ⚫ Nível 8 — Não seja engraçadinho

## 🎯 Conceito

Código não é lugar para piadas internas.

---

### Atividade 15 — Nome criativo demais

```csharp
void FazerMagicaFinanceira()
```

Refatore para algo profissional.

---

# 🟢 Desafio Final (🔥 MUITO IMPORTANTE)

Pegue este código e refatore **APENAS NOMES**:

```csharp
class D
{
    public List<U> l;

    public void P()
    {
        foreach(var x in l)
        {
            if(x.S == 1)
                F(x);
        }
    }
}
```

### Regras:

✅ não mudar lógica
✅ só nomes
✅ código deve ficar autoexplicativo

---

# 🧩 Exercício EXTRA (nível sênior)

Abra um projeto antigo seu e:

1. Escolha 1 classe
2. Renomeie tudo seguindo o capítulo 2
3. Veja quantos comentários se tornam desnecessários

👉 Esse é exatamente o efeito que o livro defende.

---

Se quiser, posso te passar depois também:

✅ ✅ **Checklist profissional de nomes (o que devs sênior verificam)**
✅ ✅ **10 smells de nomes ruins que aparecem em entrevistas**
✅ ✅ **Um mini-projeto completo só de refatoração Clean Code**
✅ ✅ **Teste prático estilo empresa para treinar naming**

Qual você quer fazer agora?
