namespace TestNinja.Fundamentals
{
    public class Reservation
    {
        public User MadeBy { get; set; }

        public bool CanBeCancelledBy(User user) //method I want to test
        {
            return (user.IsAdmin || MadeBy == user); // 3 different execution paths
                

  
        } 
        
    }

    public class User
    {
        public bool IsAdmin { get; set; }
    }
}