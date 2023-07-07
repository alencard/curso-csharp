using System.Text;

namespace _55ExercicioComposicao2.Entities
{
    class Post
    {
        public DateTime Date { get; private set; }
        public string Title { get; private set; }
        public string Content { get; private set; }
        public int Likes { get; private set; }
        public List<Comment> Comments { get; set; } = new();

        public Post()
        {

        }

        public Post(DateTime date, string title, string content, int likes)
        {
            Date = date;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine();
            sb.Append("Título do Post: ");
            sb.AppendLine(Title);
            sb.AppendLine("Conteúdo do Post:");
            sb.AppendLine(Content);
            sb.Append("Quantidade de Likes: ");
            sb.AppendLine(Likes.ToString());
            sb.Append("Momento da criação do post: ");
            sb.AppendLine(Date.ToString("dd/MM/yyyy HH:mm:ss"));
            for (int i = 0; i < Comments.Count; i++)
            {
                sb.AppendLine();
                sb.AppendLine($"Comentário #{i + 1}:");
                sb.AppendLine(Comments[i].ToString());
            }

            return sb.ToString();
        }
    }
}
