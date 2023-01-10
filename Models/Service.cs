using System;
namespace Agrifood.Models;

public class Service {

    public int Id { get; set; }
    public string? Name { get; set; }

    public int EmployeeId { get; set; }

    public virtual Employee? Employee { get; set; }

}





