using DogDirectory.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DogDirectory.Services
{
    public interface IDogBreedService
    {
        Task<IEnumerable<string>> GetBreedsAsync();
        Task<string> GetRandomImage(string breed);
    }
}
