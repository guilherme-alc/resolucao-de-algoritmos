## Computador
Uma grande empresa está construindo uma nova arquitetura de computadores que permita a execução eficiente de duas instruções especiais de soma. O computador possui N posições de memória, endereçadas de 1 a N, e cada posição pode guardar um inteiro maior ou igual a zero. Inicialmente, todas as posições contêm o valor zero. As instruções especiais de soma são:

FRENTE i V: Dado o endereço i, 1 ≤ i ≤ N, e um valor positivo V, o computador deve somar V na posição i, V-1 em i+1, V-2 em i+2, etc, enquanto o valor a ser somando for maior do que zero e a posição for menor ou igual a N;
TRÁS i V: Dado o endereço i, 1 ≤ i ≤ N, e um valor positivo V, o computador deve somar V na posição i, V-1 em i-1, V-2 em i-2, etc, enquanto o valor a ser somando for maior do que zero e a posição for maior ou igual a 1.
Por exemplo, para N=16, uma possível sequência de instruções é dada abaixo:

![exemplo](exemplo.png)

Além disso, o computador possui a instrução IMPRIME i, que deve imprimir na saída o valor atual armazenado na posição i da memória.

Dados N e uma sequência de M instruções, seu programa deve imprimir, para cada instrução do tipo IMPRIME i, uma linha contendo o valor armazenado na posição de memória i no instante da execução da instrução.

## Entrada
A primeira linha da entrada contém dois inteiros N e M, representando o número de posições de memória e o número de instruções, respectivamente. As M linhas seguintes contêm, cada uma, a descrição de uma instrução em uma de três formas possíveis: 1 I V, representando FRENTE I V; 2 I V, representando TRÁS I V; e 3 I, representando IMPRIME I.

## Saída
Para cada instrução do tipo IMPRIME i, seu programa deve imprimir uma linha contendo um inteiro representando o valor armazenado na posição de memória i no instante da execução da instrução.