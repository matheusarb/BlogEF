using BlogEF.Data;
using BlogEF.Models;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        using var context = new BlogEFDataContext();
    
        var category = new Category
        {
            Name="Backend",
            Slug="backend"
        };

        var user = new User
        {
            Name="Matheus Ribeiro",
            Email="matheus@email.com",
            PasswordHash="HASH",
            Bio="IBM Senior Engineer",
            Image="https://",
            Slug="matheusribeiroa"
        };

        var post = new Post
        {
            Category=category,
            Author=user,
            Title="começando EFCore",
            Summary="efcore",
            Body="<p>HelloWorld!</p>",
            Slug="ef-core",
            CreateDate=DateTime.Now,
            LastUpdateDate=DateTime.Now
        } ;

        context.Posts.Add(post);
        
    }
    
        static void DisplayTags()
        {
            using (var context = new BlogEFDataContext())
            {
                var tags = context
                    .Tags
                    .ToList();
                foreach(var tag in tags)
                    System.Console.WriteLine($"tag1: {tag.Id}| {tag.Name}");
            }
        }
}