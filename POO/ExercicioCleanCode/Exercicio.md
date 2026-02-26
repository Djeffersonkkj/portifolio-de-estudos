O Capítulo 2 de *Código Limpo*, "Nomes Significativos", é a base de tudo. Se você não consegue dar nome às suas "crianças" (variáveis, métodos, classes), ninguém vai querer brincar no seu playground de código.

Preparei uma lista de exercícios práticos focada em **C#** para você afiar o seu senso crítico. Vamos lá?

---

### Exercício 1: Revelando a Intenção

O código abaixo funciona perfeitamente, mas é um mistério completo. Refatore-o para que os nomes revelem a intenção real (dica: é um sistema de checkout de e-commerce).

```csharp
// Código Original
public decimal Calc(decimal p, int q)
{
    var d = 0m;
    if (q > 10)
    {
        d = p * 0.1m;
    }
    return (p * q) - d;
}

```

---

### Exercício 2: Evitando Desinformação e Ruído

Identifique os erros de nomenclatura abaixo (baseado nas regras de evitar nomes que enganam ou palavras irrelevantes) e sugira nomes melhores.

1. `List<string> nomeStringList = new List<string>();`
2. `public class ClienteInfo { ... }`
3. `var dataFormatadaString = DateTime.Now.ToString();`
4. `public void ProcessarDados(int a1, int a2) { ... }`

---

### Exercício 3: Nomes Pronunciáveis e Buscáveis

Ninguém quer ler "m_s_ano_mes_dia". Além disso, números mágicos são um pesadelo para manutenção. Refatore o código abaixo usando `constants` ou `enums` e nomes claros.

```csharp
public void AgendarLembrete(DateTime dt)
{
    // O que é 86400? Por que 7?
    var s = 86400;
    var t = 7;
    
    if (dt.DayOfWeek == (DayOfWeek)0) // 0 é domingo?
    {
        // lógica aqui
    }
}

```

---

### Exercício 4: Classes vs. Métodos

Seguindo a regra de que **Classes devem ser substantivos** e **Métodos devem ser verbos**, corrija o design abaixo:

```csharp
public class ProcessarPagamento
{
    public void Cartao(decimal valor) { }
    public void GeradorDeRelatorio(string id) { }
}

```

---

### Exercício 5: Uma Palavra por Conceito

Imagine que você está em um projeto onde três desenvolvedores diferentes criaram métodos para "buscar um registro no banco de dados". Padronize os nomes abaixo para seguirem um único conceito.

* `public User FetchUser(int id);`
* `public Product GetProduct(int id);`
* `public Order RetrieveOrder(int id);`

---

### Resumo do Desafio Final

Pegue um projeto pessoal seu em C# (ou um método que você escreveu recentemente) e aplique o **"Checklist do Capítulo 2"**:

1. O nome revela a intenção?
2. Evitei nomes genéricos como `Data`, `Info`, `Manager`?
3. Usei nomes que podem ser pronunciados em uma conversa?
4. Troquei todos os números mágicos por constantes nomeadas?

---

> **Dica de mestre:** No C#, seguimos o **PascalCase** para classes e métodos, e **camelCase** para variáveis locais e parâmetros. Evite prefixos como `i_` para inteiros ou `str` para strings. O tipo já nos diz o que ele é; o nome deve nos dizer **o que ele faz**.

Gostaria que eu corrigisse suas respostas ou quer que eu crie um pequeno projeto prático para aplicarmos tudo isso de uma vez?