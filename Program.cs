using System.Security.Cryptography.X509Certificates;
using BlogEF.Data;
using BlogEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

internal class Program
{
    private static async Task Main(string[] args)
    {
        using var context = new BlogEFDataContext();
        
        var usersTask = await GetUsers(context);
        // var users = await usersTask;
        DisplayUsers(usersTask);
    }

    static void DisplayUsers(IList<User> users)
    {
        foreach(var user in users)
        {
            System.Console.WriteLine(user.Name);
        }
    }

    public static async Task<IList<User>> GetUsers(BlogEFDataContext context, int skip = 0, int take = 25)
    {
        return await context
            .Users
            .AsNoTracking()
            .Skip(skip)
            .Take(take)
            .ToListAsync();
    }
}

// var user = new User
        // {
        //     Name="teste",
        //     Email="teste@",
        //     PasswordHash="teste@",
        //     Bio="teste@",
        //     Image="teste@",
        //     Slug="teste@",
        //     Github="teste@"
        // };

        // context.Users.Add(user);
        // context.SaveChanges();
        // var posts2 = await GetPosts(context);
        // foreach (var item in posts2)
        // {
        //     System.Console.WriteLine(item.Slug);
        // }