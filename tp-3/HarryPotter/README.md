## Harry Potter e o TP3 Filosofal
Harry Potter é um garoto órfão que vive infeliz com seus tios, os Dursleys. Ele recebe uma carta contendo um convite para ingressar em Hogwarts, uma famosa escola especializada em formar jovens bruxos. Inicialmente, Harry é impedido de ler a carta por seu tio, mas logo recebe a visita de Hagrid, o guarda- caça de Hogwarts, que chega para levá-lo até a escola. Harry adentra um mundo mágico que jamais imaginara, vivendo diversas aventuras com seus novos amigos, Rony Weasley e Hermione Granger.

Neste TP3/Aventura sua tarefa será ajudar nossos heróis a enfrentarem aquele cujo nome não pode ser pronunciado!

Tudo isso com muita magia e muita classe. Por isso vocês deverão definir a seguinte Classe

| Atributos           | Tipo   |
|---------------------|--------|
| idPersonagem        | string |
| nome                | string |
| nomeDaCasa          | string |
| origem              | string |
| atorAtriz           | string |
| estaVivo            | bool   |
| anoNascimento       | int    |
| corOlhos            | string |
| sexo                | string |
| corCabelo           | string |
| bruxo               | bool   |

| Métodos          | Retorno |
|------------------|---------|
| ToString()       | string  |



Agora será a sua vez de ajudar a Harry Potter com a sua habilidade mágica e sua varinha chamada C# (usando as palavras mágicas: "dotnet run")

Ah, e muito importante ! Você deverá usar o conhecimento que The foi passado por Hagrid, o guarda-caça de Hogwarts (o professor da teoria): as classes CFila, CPilha e CLista.

### Entrada
Ler um valor P de personagens. A seguir virão P linhas contendo cada os dados que serão os mesmos e na ordem dos atributos da classe, separados por ponto-e-vírgula (;)

Depois virá uma linha com um valor C de comandos dos amigos de Harry, seguido de C linhas com o seguinte formato: <cmd>;<parâmetro1>

Onde <cmd> pode ser um dos seguintes comandos:

Empi, Desempi, TemCPil, Enfi, Desenfi, TemCFil, InsFim, Insini, RemComec, RemFim (me disseram que você é um ótimo programador e já sabe o que esses comandos devem fazer. Eles estão abreviados para que aquele cujo nome não pode ser pronunciado não entenda tão fácil)

Já o <parâmetro dos comandos varia de acordo com os comandos acima:

Para os comandos: Empi, Enfi, InsFim e Insini o <parâmetro> será o anoNascimento dos personagens. Neste caso você deverá inserir todos os personagens com esse valor na estrutura correta

Exemplo: <b>Empi;1980</b>

Para os comandos: Desempi, Desenfi, RemComec e Rem Fim o <parâmetro> será um número ou a palavra "all".

Neste caso você deverá retirar a quantidade de objetos indicados no <parâmetro> da estrutura correspondente (e mostrar na saída, viu ?). Sendo a palavra "all" deverá esvaziar toda a estrutura correspondente e enviar para a saída

Exemplo: <b>Desenfi;5</b>

Para os comandos: TemCPil e TemCFil o <parâmetro> será um nome de personagem que você deverá procurar na estrutura adequada e exibir o resultado na saída (veja como abaixo). Para fazer essa pesquisa você poderá (acho melhor) criar outros métodos nas classes que recebeu para fazer a sua procura.

Exemplo: <b>TemCFil; Draco Malfoy</b>

### Saída
Para alguns dos comandos de entrada as saídas deverão ser:

Para os comandos: TemCPil e TemCFil deve ser exibido apenas o nome pesquisado seguido, na mesma linha, de "Ok" ou "Nada"


Para os comandos: Desempi, Desenfi, RemComec e RemFim deve ser exibidos todos os dados do personagem retirado, conforme mostra o arquivo de saída abaixo e de acordo com a quantidade indicada no <parâmetro>

Os comandos Empi, Enfi, InsFim e Insini não produzem nenhuma saída.


O seu código precisa ter as classes e os algoritmos exigidos pelos bruxos de Hogwarts.
O mestre Dumbledore (o professor) irá inspecionar o seu código.
E como o mestre Dumbledore diz: "Tempos difíceis nos aguardam e em breve teremos que escolher entre o TP3 que é certo e o que é fácil."