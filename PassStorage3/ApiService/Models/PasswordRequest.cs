namespace ApiService.Models
{
    public class PasswordRequest
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }
        public string AdditionalData { get; set; }
    }
}
