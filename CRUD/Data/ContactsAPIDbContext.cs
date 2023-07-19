using Microsoft.EntityFrameworkCore;
using CRUD.Models;
namespace CRUD.Data;

public class ContactsAPIDbContext : DbContext
{
    public ContactsAPIDbContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<Contact> Contacts { get; set; }
}
