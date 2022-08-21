# SOLID

códigos do curso feito na Udemy acerda de princípios SOLID para C# e suas aplicações em situações reais.

## Single Principle Responsibility (SPR):

 1.  princípio da responsabilidade única. Cada método e classe deve ter um único objetivo. Evitar as *God classes*.

## Open-closed Principle (OCP):

 1.  Esse princípio fala sobre como agir em situações em que **se precisa alterar regras de negócio na aplicação sem quebrar o que já funciona**.
2.  **aberto**: podemos **estender** a classe, mas **fechado** para **alteração** do que já foi implementado
3.  princípio relativo a mudanças
4.  primeira maneira de aplicar ocp: estendendo ou criando interfaces
5.  a ideia central é: criar uma versão para coisas novas. Digamos: precisamos implementar mudanças significativas: cria-se uma nova versão, bem como novas classes.
6.  Para estudar **padrões de projeto que aplicam o ocp: FACTORY E STRATEGY**

## Liskov Substitution Principle (LSP):

 1. Objetos da subclasse se comportem da mesma maneira das superclasse;
 2. Se substituirmos o contrato utilizado na classe mãe (interface) e usasse diretamente nas classes filhas, o comportamente deve ser o mesmo.
 3. <img src="https://se-education.org/se-book/principles/liskovSubstitutionPrinciple/images/payroll.png" width="400">

