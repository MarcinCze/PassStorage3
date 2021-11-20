namespace ApiService.Data.Entities
{
    public class PasswordEntity
    {
        //public int Id { get; set; }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string AdditionalData { get; set; }
        public int ViewsCounter { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? PasswordChanged { get; set; }
    }
}
