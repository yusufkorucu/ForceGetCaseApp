using System.Text.Json.Serialization;

namespace ForceGet.Domain.Dtos.Response
{
  
    public class ApiResponse<T> where T : new()
    {
        public T Result { get; set; }
        public bool IsSuccess { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string ErrorMessage { get; set; }
    }
}
