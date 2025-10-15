

namespace gregslist_api_dotnet.Repositories;




public class PetsRepository
{
  private readonly IDbConnection _db;

  public PetsRepository(IDbConnection db)
  {
    _db = db;
  }

  internal Pet getPetById(int petId)
  {
    string sql = @"SELECT pets.*, accounts.* FROM pets INNER JOIN accounts ON pets.creator_Id = accounts.id WHERE pets.id = @PetID;";

    object paramOBJ = new { PetID = petId };

    Pet pet = _db.Query(sql, (Pet pet, Profile account) => { pet.Creator = account; return pet; }, paramOBJ).SingleOrDefault();

    return pet;
  }

  internal List<Pet> getPets()
  {
    string sql = "SELECT pets.*, accounts.* FROM pets INNER JOIN accounts ON pets.creator_Id = accounts.id;";

    List<Pet> pets = _db.Query(sql, (Pet pet, Profile account) => { pet.Creator = account; return pet; }).ToList();

    return pets;
  }
}