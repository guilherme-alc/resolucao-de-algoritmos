namespace HarryPotter_Classes.Models
{
    internal class Personagem
    {
        private string idPersonagem;
        private string nome;
        private string nomeDaCasa;
        private string origem;
        private string atorAtriz;
        private bool estaVivo;
        private int anoNascimento;
        private string corOlhos;
        private string sexo;
        private string corCabelo;
        private bool ehbruxo;
        public Personagem(string[] dadosPersonagem)
        {
            idPersonagem = dadosPersonagem[0];
            nome = dadosPersonagem[1];
            nomeDaCasa = dadosPersonagem[2];
            origem = dadosPersonagem[3];
            atorAtriz = dadosPersonagem[4];
            estaVivo = bool.Parse(dadosPersonagem[5]);
            anoNascimento = int.Parse(dadosPersonagem[6]);
            corOlhos = dadosPersonagem[7];
            sexo = dadosPersonagem[8];
            corCabelo = dadosPersonagem[9];
            ehbruxo = bool.Parse(dadosPersonagem[10]);
    }
        public override string ToString()
        {
            return $"{idPersonagem};{nome};{nomeDaCasa};{origem};{atorAtriz};{estaVivo};{anoNascimento};{corOlhos};{sexo};{corCabelo};{ehbruxo}";
        }
        public bool GetNome(string nome)
        {
            if(this.nome.Equals(nome))
                return true;

            return false;
        }
        public bool getAnoNascimento(string parametro) 
        {
            if(int.TryParse(parametro, out int ano))
                return anoNascimento == ano;

            return false;
        }
    }
}
