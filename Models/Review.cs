namespace GraphQLProject.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int MenuId { get; set; }

        public string? Description { get; set; }

        public int Ratting { get; set; }
    }
}
