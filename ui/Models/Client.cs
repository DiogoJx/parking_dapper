using System;

namespace parking_dapper.Models;

public class Client
{
    public int Id { get; set; } = default!;
    public string? Name { get; set; } 
    public string? CPF { get; set; }
    public string? Telefone { get; set; }
}
