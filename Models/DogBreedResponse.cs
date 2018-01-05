
namespace DogDirectory.Models
{
    public abstract class DogBreedResponse<TMessage>
    {
        public string Status { get; set; }
        public TMessage Message { get; set; }
    }
}
