using System;
using Secao_9_Aula_122_Exercício_2.Entidades;

namespace Secao_9_Aula_122_Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantidade de posts: ");
            int postQty = int.Parse(Console.ReadLine());

            for(int i = 0; i < postQty; i++)
            {
                Console.Write("Título: ");
                string postTitle = Console.ReadLine();
                Console.Write("Post: ");
                string postContent = Console.ReadLine();
                Random rand = new Random();
                int postLikes = rand.Next(100);
                Post postData = new Post(DateTime.Now, postTitle, postContent, postLikes);
                Console.WriteLine();

                Console.Write("Número de comentários: ");
                int comments = int.Parse(Console.ReadLine());
                for (int j = 0; j < comments; j++)
                {
                    Console.WriteLine("Comentário {0}: ", j + 1);
                    string text = Console.ReadLine();
                    Comments postComm = new Comments(text);
                    postData.AddComment(postComm);
                    Console.WriteLine();
                }
                Console.WriteLine(postData);
            }
        }
    }
}
