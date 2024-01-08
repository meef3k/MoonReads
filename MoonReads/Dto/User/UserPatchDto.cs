using System.ComponentModel.DataAnnotations;

namespace MoonReads.Dto;

public class UserPatchDto
{
    public string Description { get; set; }
    
    public string Avatar { get; set; }
    
    public string UserName { get; set; }
    
    [EmailAddress]
    public string Email { get; set; }
}