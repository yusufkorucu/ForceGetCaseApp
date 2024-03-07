namespace ForceGet.Domain.Dtos.Base
{
    public class AddOrUpdateResponseDto
    {
        public bool? IsSuccess { get; set; }
        public virtual bool HasError { get { return ModelErrors.Any(); } }
        public string ErrorText { get; set; }

        public List<KeyValuePair<string, string>> ModelErrors { get; set; }

        public AddOrUpdateResponseDto()
        {
            ModelErrors = new List<KeyValuePair<string, string>>();
        }
    }
}
