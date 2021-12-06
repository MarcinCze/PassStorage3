namespace PassStorage3.ApiService.Models
{
    public class BaseRequest
    {
        public bool IsValid => Validate(this, out _);

        static bool Validate<T>(T obj, out ICollection<ValidationResult> results)
        {
            results = new List<ValidationResult>();

            return obj == null 
                ? false 
                : Validator.TryValidateObject(obj, new ValidationContext(obj), results, true);
        }
    }
}
