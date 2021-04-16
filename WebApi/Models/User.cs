namespace WebApi.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public int Age { get; set; }

        public string ToString()
        {
            return Username + " " + Role + " " + Age;
        }
    }
}