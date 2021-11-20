namespace ApiService.Data.Entities
{
    public class PasswordEntity : IEntityModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string AdditionalData { get; set; }
        public int ViewsCounter { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? PasswordChanged { get; set; }

        public const int ExpirationDays = 365;

        public bool ExpirationAlert =>
            PasswordChanged.HasValue
                    ? (DateTime.Now - PasswordChanged.Value).TotalDays >= ExpirationDays
                    : throw new ArgumentNullException(nameof(PasswordChanged));
    }
}
