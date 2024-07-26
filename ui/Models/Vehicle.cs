using System;

namespace Parking.Models;

public class Vehicle
{
    public int Id { get; set; } = default!;

    public string? LicencePlate { get; set; } 

    public string? Model { get; set; } 

    public string? Brand { get; set; } 

    public int ClientId { get; set; } = default!;

}
  