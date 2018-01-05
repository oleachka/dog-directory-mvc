# Dog Directory Project 

## Running The code

You can either open this solution in Visual Studio and Run it or use the commandline.

To use the commandline you will have to have the dotnetcore cli tools installed (https://download.microsoft.com/download/2/9/3/293BC432-348C-4D1C-B628-5AC8AB7FA162/dotnet-sdk-2.1.3-win-gs-x64.exe)

* Clone repository
* Run the following from the root folder

```powershell
dotnet restore
dotnet build
dotnet run

```

The server will start running and show you the port e.g. ` http://localhost:57787`


## Answers to Questions

#### Is there an elegant way we can handle deserializing the JSON so we don't have to repeat some boilerplate for each call to get at the message property?

I addressed this by making a generic DogBreed response class

```c#
public abstract class DogBreedResponse<TMessage>
{
	public string Status { get; set; }
	public bool IsSuccess => Status == "success";
	public TMessage Message { get; set; }
}
```

All other response classes will inherit from it and specify the type of the `TMessage` generic. An example is the
`DogListBreedResponse` class and the `DogBreedRandomImageResponse` class

```c#
public class DogBreedListResponse : DogBreedResponse<IEnumerable<string>>
{ }

public class DogBreedRandomImageResponse : DogBreedResponse<string>
{ }
```


### Is there a better way the API could have been implemented to obviate the need for the status property?

Yes. It would be better if the Responses from the API only had the Payloads (e.g. Message property). Statuses could be the HTTP codes such as `404` or `500` if something went wrong


