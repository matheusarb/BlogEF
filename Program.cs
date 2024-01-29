using System.Security.Cryptography.X509Certificates;
using BlogEF.Data;
using BlogEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

internal class Program
{
    private static void Main(string[] args)
    {
        var user = new User
        {
            Name="teste",
            Email="teste@",
            PasswordHash="teste@",
            Bio="teste@",
            Image="teste@",
            Slug="teste@",
            Github="teste@"
        };

        using var context = new BlogEFDataContext();
        context.Users.Add(user);
        context.SaveChanges();
    }
}