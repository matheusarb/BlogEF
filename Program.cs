using System.Security.Cryptography.X509Certificates;
using BlogEF.Data;
using BlogEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

internal class Program
{
    private static void Main(string[] args)
    {
        using var context = new BlogEFDataContext();
        var user = GetUser(context, 1);
        var category = GetCategory(context, 1);

        // DateTime date = DateTime.Now.Date;
        // System.Console.WriteLine(date);

        var createPost = new Post
        {
            Title = "postTeste",
            Summary = "postTeste",
            Body = "postTeste",
            Slug = "postTeste",
            CreateDate = DateTime.Now.Date,
            Author = user,
            Category = category
        };
        context.Posts.Add(createPost);
        context.SaveChanges();
        // var usersTask = await GetUsers(context);
        // DisplayUsers(usersTask);
    }

    static void DisplayUsers(IList<User> users)
    {
        foreach (var user in users)
        {
            System.Console.WriteLine(user.Name);
        }
    }

    public static User GetUser(BlogEFDataContext context, int userId)
    {
        var user = context.Users.FirstOrDefault(x => x.Id == userId);
        return user;
    }

    public static Category GetCategory(BlogEFDataContext context, int categoryId)
    {
        var category = context.Categories.FirstOrDefault(x => x.Id == categoryId);
        return category;
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