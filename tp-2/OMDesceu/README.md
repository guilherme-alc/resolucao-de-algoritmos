## O M Desceu ?
Você recebeu uma tarefa para realizar com urgência, onde o seu programa receberá vários pares de números de entrada e deverá exibir na saída o MDC deles.

O problema é que a linguagem final será o C#Marromenos. Essa linguagem, recém criada, é bem parecida com o C# só que, pra economizar no compilador, ela não tem nenhum comando de repetição (proibido usar while, for, do-while). A única forma de executar repetições é por recursividade. 

O máximo divisor comum (MDC) de dois números inteiros x e y pode ser calculado usando-se uma definição recursiva:

MDC(x, y) = MDC(x − y, y), se x > y

MDC(x,y) = MDC(y,x)

MDC(x,x) = x

Caso base? x == y
Passo da recursão? Os dois outros casos acima.


### Entrada
A primeira linha da entrada contém um inteiro N indicando quantidade de linhas contendo números. As próximas N linhas contém dois números do conjunto dos inteiros separados por um espaço em branco.


### Saída
Para cada uma das N linhas lidas exibir uma linha com MDC deles.