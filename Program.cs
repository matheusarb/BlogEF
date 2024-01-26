using BlogEF.Data;
using BlogEF.Models;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        using (var context = new BlogEFDataContext())
        {
            //CREATE
            // Tag tag = new Tag { Name="ASP.NET", Slug="asp-net" };
            // context.Tags.Add(tag);
            // context.SaveChanges();

            //UPDATE
            // var tag = context.Tags.FirstOrDefault(x=>x.Id == 1);
            // tag.Name = ".NET";
            // tag.Slug = "dotnet";
            // context.Update(tag);
            // context.SaveChanges();

            //DELETE
            // try {
            //     var tag = context.Tags.FirstOrDefault(x=>x.Id == 1);
            //     context.Remove(tag);
            //     context.SaveChanges();
            // } catch(Exception ex) {
            //     System.Console.WriteLine("Não foi possível deletar o item.");
            //     System.Console.WriteLine(ex.Message);
            // }

            //READ ONE
            // var tag = context
            // .Tags
            // .AsNoTracking()
            // .FirstOrDefault(x => x.Id == 29);
            // System.Console.WriteLine(tag?.Name);

            //READ MANY
            //Quando em leitura, utilizar o AsNoTracking() para não puxar os metadados e tornar a consulta mais performática
            //passar o .ToList() ao final da chamada, pq é quando a consulta ao banco é executada, assim garantimos performance
            // var aspTag = context
            //     .Tags
            //     .Where(x => x.Name.Contains("asp"))
            //     .AsNoTracking()
            //     .ToList();

            // if (aspTag.Count() != 0)
            // {
            //     foreach (var item in aspTag)
            //     {
            //         System.Console.WriteLine(item.Name);
            //     }
            //     return;
            // }
            // else
            // {
            //     System.Console.WriteLine("There is no match to the query in Database");
            // }
        };

        // static void DisplayTags()
        // {
        //     using(var ctx = new BlogEFDataContext())
        //     {
        //         ctx.Tags.SelectMany();
        //     }
        // }
    }
}