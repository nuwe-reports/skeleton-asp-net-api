using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.Persistence.DataModels;

[Keyless]
public class PingModel
{
    public int Ping { get; set; }
}