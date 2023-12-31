﻿using _55ExercicioComposicao2.Entities;

namespace _55ExerciciosComposicao2
{
    class Program
    {
        static void Main()
        {
            List<Post> posts = new();

            Console.Write("Quantos posts você quer fazer? ");
            int n = int.Parse(Console.ReadLine());

            // criar um novo post e add comentarios
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();

                Console.Write($"Qual o título do post #{i + 1}? ");
                string postTitle = Console.ReadLine();
                Console.WriteLine($"Insira o conteúdo do post #{i + 1}:");
                string postContent = Console.ReadLine();
                Console.Write($"Quantos likes você quer adicionar no post #{i + 1}? ");
                int qttLikes = int.Parse(Console.ReadLine());

                Post post = new(DateTime.Now, postTitle, postContent, qttLikes);

                posts.Add(post);

                Console.WriteLine();
                Console.Write($"Quantos comentários você quer adicionar para o post #{i + 1}? ");
                int qttComments = int.Parse(Console.ReadLine());

                for (int j = 0; j < qttComments; j++)
                {
                    Console.WriteLine($"Insira o conteúdo do comentário #{j + 1}:");
                    Comment comment = new(Console.ReadLine());
                    posts[i].AddComment(comment);
                }
            }

            //mostrar post e comments 
            for (int i = 0; i < posts.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Post #{i + 1}:");
                Console.WriteLine(posts[i]);
            }
        }
    }
}