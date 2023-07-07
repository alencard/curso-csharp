namespace _55ExercicioComposicao2.Entities
{
    class Post
    {
        public DateTime Date { get; private set; }
        public string Title { get; private set; }
        public string Content { get; private set; }
        public int Likes { get; private set; }
        public List<Comment> Comments { get; set; }

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

        public void Like(int qtt = 1)
        {
            Likes += qtt;
        }

        public void Dislike(int qtt = 1)
        {
            Likes -= qtt;
        }

        public void NewComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public override string ToString()
        {
            return $"Momento da criação do post: {Date}\n" +
                $"Título do Post: {Title}\n" +
                $"Conteúdo do Post: {Content}\n" +
                $"Quantidade de Likes: {Likes}";
        }
    }
}
