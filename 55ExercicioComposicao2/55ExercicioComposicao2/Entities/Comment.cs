namespace _55ExercicioComposicao2.Entities
{
    class Comment
    {
        public string Text { get; private set; }

        public Comment()
        {

        }

        public Comment(string text)
        {
            Text = text;
        }

        public override string ToString()
        { 
            return Text;
        }
    }
}
