namespace PersonService.GraphQL;

public class Query
{
    public IEnumerable<Person> Persons()
    {
        return new List<Person>
        {
            new() {Id = Guid.NewGuid(), Name = "Lorem Ipsum"},
            new() {Id = Guid.NewGuid(), Name = "Foor Bar"},
            new() {Id = Guid.NewGuid(), Name = "Bob Ross"}
        };
    }
}

public class Person
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}