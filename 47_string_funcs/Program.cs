namespace _47_string_funcs
{
    class Program
    {
        static void Main()
        {
            string original = "abcde FGHIJ ABC abc DEFG     ";

            string s1 = original.ToUpper();
            Console.WriteLine($"- {s1} -");

            s1 = original.ToLower();
            Console.WriteLine($"- {s1} -");

            // apaga espaçoes em branco em excesso no final da string
            s1 = original.Trim();
            Console.WriteLine($"- {s1} -");

            // indice q se inicia o conteudo passado
            int n1 = s1.IndexOf("bc");
            Console.WriteLine(n1);

            // semelhante ao index of, mas inicia a busca de trás pra frente
            n1 = s1.LastIndexOf("bc");
            Console.WriteLine(n1);

            // recorta a string de uma posicao desejada, pode receber tbm um int para o length desejado
            // s1 = original.Substring(6);
            // original.Substring(6, 5)
            s1 = original[6..];
            Console.WriteLine(s1);

            // seleciona todos os caracteres, e troca pelo segundo caractere passado
            s1 = original.Replace('a', 'x');
            // strings podem ser passadas tbm
            s1 = original.Replace("abc", "xy");
            Console.WriteLine(s1);

            //testa se a string é "" ou null
            bool b1 = string.IsNullOrEmpty(original);
            Console.WriteLine(b1);

            b1 = string.IsNullOrWhiteSpace(original);
            Console.WriteLine(b1);
        }
    }
}