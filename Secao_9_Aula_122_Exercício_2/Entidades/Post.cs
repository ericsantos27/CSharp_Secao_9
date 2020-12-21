using System;
using System.Collections.Generic;
using System.Text;
using Secao_9_Aula_122_Exercício_2.Entidades;

namespace Secao_9_Aula_122_Exercício_2.Entidades
{
    class Post
    {
        public DateTime TimeDate { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Like { get; set; }
        public List<Comments> Comment { get; set; } = new List<Comments>();
        public Post()
        {
        }

        public Post (DateTime timeDate, string title, string content, int like)
        {
            TimeDate = timeDate;
            Title = title;
            Content = content;
            Like = like;
        }
        public void AddComment(Comments comm)
        {
            Comment.Add(comm);
        }
        public void RemComment(Comments comm)
        {
            Comment.Remove(comm);
        }
        public override string ToString()
        {
            StringBuilder printPost = new StringBuilder();
            printPost.AppendLine(Title);
            printPost.Append(Like);
            printPost.Append(" Likes - ");
            printPost.AppendLine(TimeDate.ToString("dd/MM/yyyy HH:mm:ss"));
            printPost.AppendLine(Content);
            printPost.AppendLine("Commentários: ");
            foreach(Comments element in Comment)
            {
                printPost.AppendLine(element.Text);
            }
            return printPost.ToString();
        }
    }
}
