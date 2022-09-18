# SOLID

códigos do [curso feito na Udemy](https://www.udemy.com/course/curso-design-patterns-csharp/) acerda de princípios SOLID para C# e suas aplicações em situações reais.

## Single Principle Responsibility (SPR):

 1.  princípio da responsabilidade única. Cada método e classe deve ter um único objetivo. Evitar as *God classes*.
 2.  Essa classe viola o SRP, pois realiza ações que não responsabilidade exclusivamente dela:
<img 
src="https://dotnettutorials.net/wp-content/uploads/2018/06/Voilatiing-Single-Responsibility-Principle.png" 
width="400" >
3. Corrigindo a violação do SRP e dividindo em suas corretas classes: 
<img 
src="https://dotnettutorials.net/wp-content/uploads/2018/06/Single-Responsibility-Principle-in-C.png" 
width="400" >
4. Uma classe não pode ter mais de um motivo para existir!


## Open-closed Principle (OCP):

1.  Esse princípio fala sobre como agir em situações em que **se precisa alterar regras de negócio na aplicação sem quebrar o que já funciona**.
2.  **aberto**: podemos **estender** a classe, mas **fechado** para **alteração** do que já foi implementado
3.  princípio relativo a mudanças
4.  primeira maneira de aplicar ocp: estendendo ou criando interfaces
5.  a ideia central é: criar uma versão para coisas novas. Digamos: precisamos implementar mudanças significativas: cria-se uma nova versão, bem como novas classes.
6.  Para estudar **padrões de projeto que aplicam o ocp: [FACTORY E STRATEGY](https://betterprogramming.pub/design-patterns-factory-vs-strategy-f45db68f0088)**
7.  Se necessário mais recursos na classe, extenda.

## Liskov Substitution Principle (LSP):

 1. Objetos da subclasse se comportem da mesma maneira das superclasse;
 2. Se substituirmos o contrato utilizado na classe mãe (interface) e usasse diretamente nas classes filhas, o comportamente deve ser o mesmo.
   
<img 
src="https://se-education.org/se-book/principles/liskovSubstitutionPrinciple/images/payroll.png" 
width="400">

## Interface Segregation Principle (ISP):

 1. Identificar interfaces "infladas", isto é, cheias de métodos que não são necessários em todos os contratos;
 2. Esse princípio pode se aplicar, também, à **classes abstratas**;
 3. Interfaces com muitos métodos;
 4. Interfaces com baixa coesão ou com métodos vazios;
 5. Interfaces menores são mais fáceis de trabalhar e desenvolver;
 6. Código limpo tem a ver com a objetividade das classes;
 7. Reduz acoplamento no código;
 8. Se possível, melhor depender de duas interfaces, mas não é interessante inflar as interfaces.


## Dependency Inversion Principle:
1. Módulos de alto e baixo nível não devem depender um do outro, mas sim de abstrações;
2. Um caso em que é necessário realizar um consulta em um banco de dados, essa consulta precisa depender apenas de uma camada que conecte o tipo de banco;
3. Pagamento -> Consulta no banco -> Camada que retorna um pagamento -> camada que conecta com o banco.
4. <img 
src="https://upload.wikimedia.org/wikipedia/commons/9/96/Dependency_inversion.png" 
width="400">



# Origem do termo dos Design Patterns

Os Design Patterns, ou padrões de projetos, têm sua primeira descrição no livro *The Timeless Way of Building*, de Christopher Alexander, em 79. Ele cunhou o termo tentando descrever a ideia de construir soluções comuns para problemas comuns. Esses problemas se baseariam em:

- Encapsulamento;
- Generalidade;
- Equilíbrio;
- Abstração;
- Abertura;
- Combinatório.

# Gang of Four - GOF

São 23 padrões de projeto encontrados no livro lançado em 1995 (*Design Patterns: Elements of Reusable Object-Oriented Software*), por 4 engenheiros e desenvolvedores de software. Tentavam passar a ideia de, sobretudo, que:

*"Conhecer esses padrões é fundamental  para entender os modernos frameworks e desenvolver softwares de qualidade."*.

Padrão GOF:
- Nome do Padrão;
- Problema que Soluciona;
- Solução.

# Tipos:

## Criacional

Diz respeito da criação dos objetos, tentando mantê-los de maneira reutilizável e flexível.

## Estrutural

Orientam como lidar com objetos e classes em estruturas de grande porte, continuando de maneira flexível e eficaz.

## Comportamental

Comunicação eficiente. Determinam responsabilidades comuns aos objetos. 

# Criação


## Factory method
1. gerador de objetos de diver
2. a aplicação acessa uma factory, fábrica de produtos;
3. 