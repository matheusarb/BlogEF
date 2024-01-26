using BlogEF.Data;
using BlogEF.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        using(var context = new BlogEFDataContext())
        {
            Tag tag = new Tag { Name="ASP.NET", Slug="asp-net" };
            context.Tags.Add(tag);
            context.SaveChanges();
        };
    }
}