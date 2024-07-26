using System;

namespace parking_dapper.Models;

public class Vacancy
{
    public int Id { get; set; } = default!;

    public string LocalizationCode { get; set; } = default!;

    public string Busy { get; set; } = default!;
}
