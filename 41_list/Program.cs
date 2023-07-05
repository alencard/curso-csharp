using System.Collections.Generic;

namespace _41_list
{
    class Program
    {
        static void Main()
        {
            /*
            List<string> list = new();
            List<string> list2 = new() {"Maria", "Alex" };

            Console.WriteLine(list);
            Console.WriteLine(list2);
            */

            /*
            List<string> list = new();

            // adiciona itens no final da lista
            list.Add("hallo");
            list.Add("hello");
            list.Add("hollo");
            list.Add("hullo");

            // adiciona itens no indice desejado
            list.Insert(2, "hillo");

            foreach (string s in list)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();
            // retorna o tamanho da lista
            Console.WriteLine(list.Count);

            // aplica os itens a funcao passada e retorna o item quando a funcao é true
            //funcao pode ser declarada ou uma lambda
            string s1 = list.Find(x => x[1] == 'e' || x[1] == 'E');
            Console.WriteLine(s1);

            // semelhante ao Find, mas a procura começa de trás pra frente
            string s2 = list.FindLast(x => x[1] == 'e' || x[1] == 'E');
            Console.WriteLine(s2);

            // mesma finalidade do find, mas retorna o indice do item
            int pos1 = list.FindIndex(x => x[1] == 'e' || x[1] == 'E');
            Console.WriteLine(pos1);

            //mesma finalidade do find last, mas retorna o indice
            int pos2 = list.FindLastIndex(x => x[1] == 'e' || x[1] == 'E');
            Console.WriteLine(pos2);
            */

            List<string> list = new() { "Marco", "Anna", "Marcelo", "Leo", "Rafael", "Lucas" };
            /*
            // retorna todos os items da condicao desejada
            List<string> list2 = list.FindAll(x => x.Length == 5);

            foreach (string item in list2)
            {
                Console.WriteLine(item);
            }
            
            //remove o item desejado
            list.Remove("Marco");

            Console.WriteLine();
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            // remove itens passando uma condicao (lambda)
            list.RemoveAll(x => x.Length >= 6);

            Console.WriteLine();
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            //remove com base no indice
            list.RemoveAt(0);

            Console.WriteLine();
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            */

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            //remove itens de um indice até o outro
            //obs: os indice final simboliza quantidade, entao nesse caso, comeca no indice 1, remove ele e mais 2
            list.RemoveRange(1, 3);

            Console.WriteLine("---------------");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }

        static bool Test(string s)
        {
            return s[1] == 'e' || s[1] == 'E';
        }
    }
}