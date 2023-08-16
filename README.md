<h1 align="center"> Guids </h1>

## 🚀 Tecnologias

Esse projeto foi desenvolvido com as seguintes tecnologias:

- C# .Net
- GitHub

## 💻 Projeto

Aprendizado sobre Guids.

- Em algum momento será necessário fazer a identificação de algo (pessoas, funcionário, venda, pedido, etc), temos um campo chamado Id.
- Id vem de identificador.
- Em bando de dados, nao podemos ter coisas repetidas, entao geralemnte salvamos as coisas com Id.
- Diversas vezes o Id é gerado pelo bando de dados, pois a ocorrência das informações é tratada lá.
- No C#, conseguimos criar um Guid (Globally Unique Identifier). Irá gerar um número que tem uma chance bem baixa de se repetir.
- Sempre que executa o Guid, ele gera um novo número.
- Se quiser transformar esse id em string usar => id.ToString();
- Se quiser apenas os 8 primeiros caracteres => id.ToString().Substring(0,8);
- - Comparação => if (id == Guid.NewGuid())
- Se fizer new Guid (); sem passar nada para ele => Resultado será tudo 0.
- Para criar um Guid precisa colocar => Guid.NewGuid();

