## Questao 05

#### Explique por que esses métodos (getters e setters) podem ser úteis, mesmo que não esteja usando encapsulamento total ainda.


R: Os getters e setters permitem controlar o acesso e modificação dos atributos da classe sem expô-los diretamente, a validação de dados (por ex: no SetPreco(), impedimos valores negativos)

Também promovem a facilidade de manutenção, pois se a lógica de leitura/modificação mudar no futuro, basta alterar os métodos sem impactar o código que usa a classe.
