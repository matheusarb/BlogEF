using BlogEF.Data;
using BlogEF.Models;

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

            //READ
            var aspTag = context
                .Tags
                .Where(x => x.Name.Contains("asp"))
                .ToList();

            if (aspTag.Count() != 0)
            {
                foreach (var tag in aspTag)
                {
                    System.Console.WriteLine(tag.Name);
                }
                return;
            }
            else
            {
                System.Console.WriteLine("There is no match to the query in Database");
            }
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