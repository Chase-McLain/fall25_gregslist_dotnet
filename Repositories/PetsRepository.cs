

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
    string sql = "SELECT * FROM pets WHERE id = @PetID;";

    object paramOBJ = new { PetID = petId };

    Pet pet = _db.Query<Pet>(sql, paramOBJ).SingleOrDefault();

    return pet;
  }

  internal List<Pet> getPets()
  {
    string sql = "SELECT * FROM pets;";

    List<Pet> pets = _db.Query<Pet>(sql).ToList();

    return pets;
  }
}