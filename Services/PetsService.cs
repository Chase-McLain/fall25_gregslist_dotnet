
namespace gregslist_api_dotnet.Services;



public class PetsService
{
  private readonly PetsRepository _petsRepository;

  public PetsService(PetsRepository petsRepository)
  {
    _petsRepository = petsRepository;
  }

  internal List<Pet> getPets()
  {
    List<Pet> pets = _petsRepository.getPets();
    return pets;
  }
}