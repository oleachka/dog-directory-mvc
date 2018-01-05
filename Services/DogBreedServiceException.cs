using System;

namespace DogDirectory.Services
{
    public class DogBreedServiceException : Exception
    {
        public DogBreedServiceException(string message) : base(message)
        {
        }
    }
}
