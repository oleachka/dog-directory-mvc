
namespace DogDirectory.Models
{
    public abstract class DogBreedResponse<TMessage>
    {
        public string Status { get; set; }
        public bool IsSuccess => Status == "success";
        public TMessage Message { get; set; }
    }
}
