using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace test;
[JsonArray]
public class Locations
{
    public string? Name { get; set; }
    public string? Street { get; set; }
    public string? Region { get; set; }
    public string? City { get; set; }
    public string? Country { get; set; }
    public string? Hotline { get; set; }
    public string? Type { get; set; }
    public string? Location { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        string Json = File.ReadAllText(@"/Users/engysaad/Projects/Locations/Locations/Json.json");
        Locations? ElEzabyPharmacies = JsonConvert.DeserializeObject<Locations>(Json);
        Console.WriteLine(ElEzabyPharmacies?.Country);
        Console.ReadLine();
    }
}