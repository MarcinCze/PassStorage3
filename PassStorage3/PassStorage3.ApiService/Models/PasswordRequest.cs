namespace PassStorage3.ApiService.Models
{
    public class PasswordRequest : BaseRequest, IRequestEntityMapper<PasswordEntity>
    {
        public Guid Id { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(100)]
        public string Login { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(100)]
        public string Password { get; set; }

        [MinLength(1)]
        [MaxLength(100)]
        public string AdditionalData { get; set; }

        public PasswordEntity ToEntityModel() =>
            new()
            {
                Id = Id,
                Title = Title,
                Login = Login,
                Password = Password,
                AdditionalData = AdditionalData
            };
    }
}
