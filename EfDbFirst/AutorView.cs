using EfDbFirst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfDbFirst
{
    public class AutorView
    {
        pubsContext context = new pubsContext();
        public string GetAuthorId()
        {
            Author author = new Author();
            do
            {
                Console.WriteLine("Enter author name for get him titles:");
                var name = Console.ReadLine();
                author = context.Authors.Where(a => a.AuLname == name).First();
                if (author == null)
                {
                    Console.WriteLine("Author not exist in list");
                    Console.WriteLine("Try agane!");
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine();
                }
                else break;
            } while (true);
            return author.AuId;
        }

        public IEnumerable<Titleauthor> GetTitlesList(string auId)
        {
            var titles = context.Titleauthors.Where(t => t.AuId == auId).Include(e=>e.Title).ToList();
            if (titles == null)
            {
                Console.WriteLine("Author yet to start");
                auId = GetAuthorId();
                GetTitlesList(auId);
            }
            else
            {
                foreach (var item in titles)
                {
                    Console.WriteLine(item.TitleId + " - " + item.Title.Title1);
                }
            }
            return titles;
        }
    }
}
