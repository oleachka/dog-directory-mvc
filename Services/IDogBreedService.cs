using DogDirectory.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DogDirectory.Services
{
    public interface IDogBreedService
    {
        Task<IEnumerable<DogBreedListResponse>> GetBreedsAsync();
        Task<string> GetRandomImage(string breed);
    }
}
