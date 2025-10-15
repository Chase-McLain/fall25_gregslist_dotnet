

namespace gregslist_api_dotnet.Services;



public class PetsService
{
  private readonly PetsRepository _petsRepository;

  public PetsService(PetsRepository petsRepository)
  {
    _petsRepository = petsRepository;
  }

  internal Pet getPetById(int petId)
  {
    Pet pet = _petsRepository.getPetById(petId);
    return pet;
  }

  internal List<Pet> getPets()
  {
    List<Pet> pets = _petsRepository.getPets();
    return pets;
  }
}