namespace gregslist_api_dotnet.Controllers;

[ApiController]
[Route("api/pets")]

public class PetsController : ControllerBase
{
  private readonly PetsService _petsService;

  public PetsController(PetsService petsService)
  {
    _petsService = petsService;
  }


  [HttpGet]
  public ActionResult<List<Pet>> getPets()
  {
    try
    {
      List<Pet> pets = _petsService.getPets();
      return pets;
    }
    catch (Exception exception)
    {
      return BadRequest(exception.Message);
    }
  }

  [HttpGet("{petId}")]
  public ActionResult<Pet> getPetById(int petId)
  {
    try
    {
      Pet pet = _petsService.getPetById(petId);
      return pet;
    }
    catch (Exception exception)
    {
      return BadRequest(exception.Message);
    }
  }






}