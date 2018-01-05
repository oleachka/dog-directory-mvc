using System.Collections.Generic;
using System.Linq;

namespace DogDirectory.Models
{


    public class DogBreed
    {
        public DogBreed()
        {

        }
        public DogBreed(string breed, params string[] subBreeds)
        {
            Breed = breed;
            SubBreeds = subBreeds ?? new string[] { };
        }
        public string Breed { get; set; }
        public IEnumerable<string> SubBreeds { get; set; }
        public bool HasSubBreeds => SubBreeds?.Any() == true;
    }
}
