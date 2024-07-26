using System;

namespace parking_dapper.Models;

public class HourlyRate
{
    public int Id { get; set; } = default!;
    public int Minutes { get; set; } =  default!;
    public float Value { get; set; } = default!;
}
