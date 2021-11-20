using ApiService.Data.Entities;

namespace ApiService.Models
{
    public class PasswordRequest : IRequestEntityMapper<PasswordEntity>
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

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
