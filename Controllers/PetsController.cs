namespace gregslist_api_dotnet.Controllers;

[ApiController]
[Route("api/pets")]

public class PetsController : ControllerBase
{
  private readonly PetsService _petsService;
  private readonly Auth0Provider _auth;

  public PetsController(PetsService petsService, Auth0Provider auth)
  {
    _petsService = petsService;
    _auth = auth;
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

  [HttpPost]
  [Authorize]
  public async Task<ActionResult<Pet>> createPet([FromBody] Pet petData)
  {
    try
    {
      Account userInfo = await _auth.GetUserInfoAsync<Account>(HttpContext);
      petData.CreatorId = userInfo.Id;
      Pet pet = _petsService.createPet(petData);
      return pet;
    }
    catch (Exception exception)
    {
      return BadRequest(exception.Message);
    }
  }




}