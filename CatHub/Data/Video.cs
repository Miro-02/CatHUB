using static CatHub.Data.Enumerators;

namespace CatHub.Data
{
    public class Video
    {
        private int id;
        private string title;
        private string path;
        private string description;
        private Category category;
        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Path { get => path; set => path = value; }
        public string Description { get => description; set => description = value; }
        public Category Category { get => category; set => category = value; }
    }
}
