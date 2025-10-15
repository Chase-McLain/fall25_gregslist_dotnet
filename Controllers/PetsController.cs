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
}