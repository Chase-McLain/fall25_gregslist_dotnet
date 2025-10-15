



namespace gregslist_api_dotnet.Services;



public class PetsService
{
  private readonly PetsRepository _petsRepository;

  public PetsService(PetsRepository petsRepository)
  {
    _petsRepository = petsRepository;
  }

  internal Pet createPet(Pet petData)
  {
    Pet pet = _petsRepository.createPet(petData);
    return pet;
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

  internal Pet updatePet(int petId, Account userInfo, Pet petData)
  {
    Pet pet = getPetById(petId);

    if (pet.CreatorId != userInfo.Id)
    {
      throw new Exception("I know what you are");
    }

    pet.Name = petData.Name ?? pet.Name;
    pet.Age = petData.Age ?? pet.Age;
    pet.Type = petData.Type ?? pet.Type;
    pet.Color = petData.Color ?? pet.Color;
    pet.Price = petData.Price ?? pet.Price;
    pet.IsRat = petData.IsRat ?? pet.IsRat;

    _petsRepository.updatePet(pet);

    return pet;

  }
}