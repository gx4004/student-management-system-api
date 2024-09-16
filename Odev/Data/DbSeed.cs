using Odev.Data.Entity;
using Bogus;

namespace Odev.Data;

public static class DbSeed
{
    public static async Task SeedAsync(AppDbContext dbContext)
    {
        if (!dbContext.StudentEntities.Any())
        {
            var studentFaker = new Faker<StudentEntity>()
                .RuleFor(s => s.Name, f => f.Name.FullName())
                .RuleFor(s => s.Class, f => f.PickRandom(new[] { "A", "B", "C" }))
                .RuleFor(s => s.Address, f => f.Address.StreetAddress());

            var students = studentFaker.Generate(20);

            dbContext.StudentEntities.AddRange(students);
            await dbContext.SaveChangesAsync();
        }
    }
        
}