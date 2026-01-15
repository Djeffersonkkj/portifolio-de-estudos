Segue o texto **convertido para Markdown**, mantendo o conteúdo e a estrutura, só organizado melhor 👇

---

# Conectando C# (Backend) com HTML/JS (Frontend)

Para conectar **C# (Backend)** com **HTML/JS (Frontend)**, você precisará criar uma **API**.
Pense na API como um **garçom**: você (Frontend) faz o pedido, o garçom leva até a cozinha (Backend/C#) e depois traz o prato (Resposta).

Abaixo está a **análise detalhada** para o seu desafio.

---

## 1. Glossário para Iniciantes (Termos que você vai ouvir)

Antes de começar, vamos alinhar o *“internetês”*:

* **Endpoint**
  É a URL específica no seu C# onde o JS vai “bater”.
  Exemplo:

  ```
  https://localhost:5000/api/login
  ```

* **JSON**
  É o formato de texto que o JS e o C# usam para conversar.
  Parece um dicionário:

  ```json
  { "usuario": "fulano", "senha": "123" }
  ```

* **Request (Requisição)**
  O que o Frontend envia para o Backend.

* **Response (Resposta)**
  O que o Backend devolve (sucesso, erro ou dados).

* **Payload**
  É o “corpo” da mensagem, ou seja, os dados reais que você está enviando.

* **CORS**
  Um erro comum que você vai encontrar.
  É uma trava de segurança que o Backend coloca para aceitar apenas requisições de sites autorizados.

---

## 2. Product Backlog (O que precisa ser feito)

Imagine que você é o **dono do produto**. Estas são as tarefas (User Stories):

* **Interface de Usuário (UI)**
  Criar as telas de **Login** e **Cadastro**.

* **Validação de Formulário**
  Garantir que o usuário não envie campos vazios (usando JS).

* **API de Autenticação**
  Criar o servidor em C# que recebe os dados.

* **Persistência Simples**
  Salvar os usuários em um arquivo `.json` ou em uma `List` na memória do C#.

* **Lógica de Redirecionamento**
  Se o login funcionar, o JS leva o usuário para a **Tela da Imagem**.

* **Gerador de Memes**
  A tela final que sorteia a imagem e exibe o nome.

---

## 3. Etapas de Desenvolvimento e Dicas de Estudo

### Fase 1: O Rosto (HTML e CSS)

**O que fazer:**

* Criar dois arquivos HTML:

  * `index.html` → Login
  * `dashboard.html` → Resultado
* Usar CSS para centralizar os formulários.

**Dica de estudo:**

* Estude **Flexbox** no CSS.
  É a ferramenta mágica para centralizar coisas e deixar o layout bonito sem sofrer.

**Dica extra:**

* Use o **Google Fonts** para escolher uma fonte moderna.
  Isso sobe o nível do design instantaneamente.

---

### Fase 2: O Mensageiro (JavaScript)

**O que fazer:**

* Capturar os valores digitados nos `<input>` quando o usuário clicar no botão **Entrar**.

**O que estudar:**

* `document.querySelector()` → pegar elementos da tela
* `addEventListener('click', ...)` → reagir ao clique
* **Fetch API** → enviar dados para o C# (a mágica acontece aqui)

---

### Fase 3: O Cérebro (C# / ASP.NET Core Web API)

**O que fazer:**

* Criar um projeto do tipo **Web API**
* Criar um **Controller** com:

  * Um método `POST` para **Cadastro**
  * Um método `POST` para **Login**

**O que estudar:**

* **Classes e Objetos**
  Criar uma classe `Usuario` com:

  * Nome
  * Login
  * Senha

* **Listas (`List<T>`)**
  Guardar os usuários enquanto o programa estiver rodando.

* **System.IO (Opcional)**
  Para salvar dados em `.txt` ou `.json` e não perder tudo ao fechar o VS Code.

---

## 4. Como o Front interage com o Back (O Fluxo)

1. O usuário digita no HTML
2. O JS empacota isso em um objeto **JSON**
3. O JS faz um `fetch` (`POST`) para a API em C#
4. O C# recebe e verifica se o usuário existe
5. O C# responde com **OK** ou **Erro**
6. O JS decide:

   * Mostrar erro na tela
   * Ou abrir a página do meme

---

## 5. Dicas de Ouro para o Desafio

* **Imagens Engraçadas**
  Crie um `Array` no JavaScript com links de imagens.
  Use `Math.random()` para sortear uma imagem aleatória.

* **LocalStorage (Dica extra)**
  Se o C# parecer pesado agora, o JS tem o `localStorage`, que salva dados no navegador.
  **Mas**, como seu objetivo é treinar a ponte Front ↔ Back, vale insistir no C#.

* **Ferramenta de Teste**
  Use **Postman** ou **Insomnia** para testar a API em C# antes mesmo de ter o HTML pronto.

---


