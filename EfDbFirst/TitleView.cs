using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfDbFirst
{
    public class TitleView
    {
        public string GetTitleId(IEnumerable<string> titleIds)
        {
            string id = string.Empty;
            do
            {
                Console.WriteLine("Enter title Id for get details:");
                id = Console.ReadLine();
                if (titleIds.Contains(id))
                {
                    break;
                }
                else Console.WriteLine("Id is not present in list. Try againe");
            } while (true);
            return id;
        }
    }
}
