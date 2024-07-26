using System;

namespace parking_dapper.Models;

public class Ticket
{
    public int Id { get; set; } = default!;

    public DateTime DateStart { get; set; } = default!;

    public DateTime? DateEnd { get; set; }

    public float? Value { get; set; }

    public int VehicleId { get; set; } = default!;

    public int VacancyId { get; set; } = default!;
}
