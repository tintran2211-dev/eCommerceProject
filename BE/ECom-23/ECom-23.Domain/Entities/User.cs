using System.Text.Json.Serialization;

namespace ECom_23.Domain.Entities;



public class User
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Username {get; set; }
    public RoleType RoleType {get; set; }
    
    [JsonIgnore]
    public string? PasswordHash {get; set; }
}