namespace AddressService.GraphQL;

public class Query
{
    public IEnumerable<Address> Addresses()
    {
        return new List<Address>
        {
            new() {City = "København", Street = "Kongensgade"},
            new() {City = "Ålborg", Street = "Dronningegade"},
            new() {City = "Esbjerg", Street = "Kronprinsgade"}
        };
    }
}

public class Address
{
    public string Street { get; set; }
    public string City { get; set; }
}