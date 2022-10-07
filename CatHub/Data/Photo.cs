using MessagePack;
using static CatHub.Data.Enumerators;

namespace CatHub.Data
{
    public class Photo
    {
        private int id;
        private string name;
        private string path;
        private string description;
        private Category category;
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Path { get => path; set => path = value; }
        public string Description { get => description; set => description = value; }
        public Category Category { get => category; set => category = value; }

    }
}
