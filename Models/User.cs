namespace GraphQLProject.Models
{

    public class User()
    {

        public int Id { get; set; }

        public String? Name { get; set; }

        public String? Email { get; set; }

        public String? Password { get; set; }

        public int? Role { get; set; }

        // navigation property : one user can have many reservations 

        public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();

        // navigations property : one user can give reviews for the multiple menu items 

        public ICollection<Review> Reviews { get; set; } = new List<Review>();

    }

}