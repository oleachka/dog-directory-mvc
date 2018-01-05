using DogDirectory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace DogDirectory.Services
{

    public class DogBreedService : IDogBreedService, IDisposable
    {
        HttpClient _http;
        private const string SvcUrl = "";
        public DogBreedService()
        {
            _http = new HttpClient { BaseAddress = new Uri(SvcUrl) };
        }
        public void Dispose()
        {
            _http.Dispose();
        }

        public Task<IEnumerable<DogBreedListResponse>> GetBreedsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<string> GetRandomImage(string breed)
        {
            throw new NotImplementedException();
        }
    }
}
