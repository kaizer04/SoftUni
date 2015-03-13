namespace StudentSystem.Model
{
    public class Resource
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public TypeOfResource TypeOfResource { get; set; }

        public string Link { get; set; }

        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
    }
}
