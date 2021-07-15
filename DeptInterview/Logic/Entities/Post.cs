namespace Logic.Entities
{
    public enum PostType
    {
        Text = 1,
        Image,
        Video
    }

    public class Post
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public PostType Type { get; set; }

        public string Content { get; set; }
    }
}