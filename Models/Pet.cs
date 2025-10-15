using System.ComponentModel.DataAnnotations;

namespace gregslist_api_dotnet.Models;




public class Pet
{
  public int Id { get; set; }
  [MinLength(1), MaxLength(50)] public string Name { get; set; }
  [Range(0, 1000)] public int Age { get; set; }
  [MinLength(1), MaxLength(50)] public string Type { get; set; }
  [MinLength(1), MaxLength(50)] public string Color { get; set; }
  [Range(0, 10000000)] public int Price { get; set; }
  public bool IsRat { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime UpdatedAt { get; set; }
  public string CreatorId { get; set; }
  public Profile Creator { get; set; }

}