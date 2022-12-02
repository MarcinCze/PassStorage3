namespace PassStorage3.Base.Models
{
    public class Password
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Login { get; set; }

        public string Pass { get; set; }

        public string AdditionalInformation { get; set; }

        public DateTime Created { get; set; }

        public DateTime LastUpdated { get; set; }
    }
}
