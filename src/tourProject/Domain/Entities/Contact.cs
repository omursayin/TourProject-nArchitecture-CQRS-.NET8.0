using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Contact : Entity<Guid>
{
    public string Address { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Website { get; set; }
    public string MapLocation { get; set; }
    public bool Status { get; set; }

    public Contact()
    {
        
    }

    public Contact(Guid id, string address, string phone, string email, string website, string mapLocation, bool status) : this()
    {
        Id = id;
        Address = address;
        Phone = phone;
        Email = email;
        Website = website;
        MapLocation = mapLocation;
        Status = status;
    }
}
