using DogDirectory.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace DogDirectory.Services
{
    public class DogBreedService : IDogBreedService, IDisposable
    {
        HttpClient _http;
        private const string SvcUrl = "https://dog.ceo";
        public DogBreedService()
        {
            _http = new HttpClient { BaseAddress = new Uri(SvcUrl) };
        }
        public void Dispose()
        {
            _http.Dispose();
        }

        public async Task<IEnumerable<string>> GetBreedsAsync()
        {
            var response = await _http.GetAsAsync<DogBreedListResponse>("/api/breeds/list");
            if (response.IsSuccess)
            {
                return response.Message;
            }
            throw new DogBreedServiceException("failed to retrieve dogbreeds");
        }

        public async Task<string> GetRandomImage(string breed)
        {
            var response = await _http.GetAsAsync<DogBreedRandomImageResponse>($"/api/breed/{breed}/images/random");
            if (response.IsSuccess)
            {
                return response.Message;
            }
            throw new DogBreedServiceException("failed to retrieve dogbreeds");
        }
    }
}
