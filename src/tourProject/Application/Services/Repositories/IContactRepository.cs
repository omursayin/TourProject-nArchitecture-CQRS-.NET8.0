using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface IContactRepository : IAsyncRepository<Contact, Guid>, IRepository<Contact, Guid>
{
}