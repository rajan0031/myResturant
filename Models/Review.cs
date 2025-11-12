namespace GraphQLProject.Models
{
    public class Review
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public int MenuId { get; set; }

        public string? Description { get; set; }

        public int Ratting { get; set; }


        // navigation property :  each reviw belongs to one user 
        public User? User { get; set; }
    }
}
