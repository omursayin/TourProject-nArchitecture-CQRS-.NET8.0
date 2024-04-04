using NArchitecture.Core.Application.Responses;

namespace Application.Features.Contacts.Commands.Create;

public class CreatedContactResponse : IResponse
{
    public Guid Id { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Website { get; set; }
    public string MapLocation { get; set; }
    public bool Status { get; set; }
}