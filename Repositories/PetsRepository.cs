
namespace gregslist_api_dotnet.Repositories;




public class PetsRepository
{
  private readonly IDbConnection _db;

  public PetsRepository(IDbConnection db)
  {
    _db = db;
  }

  internal List<Pet> getPets()
  {
    string sql = "SELECT * FROM pets;";

    List<Pet> pets = _db.Query<Pet>(sql).ToList();

    return pets;
  }
}