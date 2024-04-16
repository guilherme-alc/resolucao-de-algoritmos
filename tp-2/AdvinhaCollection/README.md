## Adivinha se for Capaz
Existe uma estrutura de dados do tipo caixa preta, suportando duas operações:
I x - Insere o elemento x na caixa.
R x - Retira o elemento x da caixa.

Dada uma sequencia de operações que retornam valores, você vai adivinhar a estrutura de dados. Pode ser uma pilha (LIFO), uma fila (FIFO), ou uma lista qualquer (permite retirar de qualquer posição)


### Entrada
Existem muitos casos de testes. Cada caso de teste começa com a linha contando um único inteiro n (1 <= n <= 1000). Cada uma das seguintes n linhas é um comando do tipo I, ou R, seguido de um número inteiro x. Isso significa que depois de executar um comando do tipo R, obtemos um elemento x sem erros. O valor de x é sempre um número inteiro, positivo e não maior do que 100. O final da entrada é quando n = 0.


### Saída
Para cada caso de teste, escreva uma das seguintes palavras:
stack - É uma pilha.
queue - É uma fila.
list - É uma lista.

É garantido que apenas um destes três casos poderá acontecer e não haverá sequências que ocasionem algum erro.