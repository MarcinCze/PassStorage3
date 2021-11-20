namespace ApiService.Models
{
    public class RoughPasswordResponse
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public bool ExpirationAlert { get; set; }

        public DateTime PasswordChanged { get; set; }
    }
}
