namespace gregslist_api_dotnet.Services;



public class PetsService
{
  private readonly PetsRepository _petsRepository;

  public PetsService(PetsRepository petsRepository)
  {
    _petsRepository = petsRepository;
  }
}