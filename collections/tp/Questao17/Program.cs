using System.Collections;
namespace Questao17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie a função public Hashtable ConcatenaHashtable(Hashtable HT1, Hashtable HT2), o qual retorna um novo Hashtable contendo todos os elementos de HT1 e HT2.
            Hashtable dic1 = new Hashtable() { { "MG", "Minas Gerais" }, { "PB", "Paraiba" }, { "MS", "Mato Grosso do Sul" } };
            Hashtable dic2 = new Hashtable() { { "AC", "Acre" }, { "GO", "Goiás" }, { "MA", "Maranhão" } };
            Hashtable completo = ConcatenaHashtable(dic1, dic2);
        }
        public static Hashtable ConcatenaHashtable(Hashtable dic1, Hashtable dic2)
        {
            Hashtable temp = new Hashtable();
            foreach(DictionaryEntry entry in dic1)
            {
                temp.Add(entry.Key, entry.Value);
            }
            foreach(DictionaryEntry entry in dic2)
            {
                temp.Add(entry.Key, entry.Value);
            }
            return temp;
        }
    }
}
