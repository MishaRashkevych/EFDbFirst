using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfDbFirst
{
    public class TitleView
    {
        Models.pubsContext context;

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
        public void GetSalesByTitleId(string titleId)
        {
            var sales = context.Titles.Where(id => id.TitleId == titleId).FirstOrDefault();
            if(sales == null)
            {
                Console.WriteLine("There is no sales by this id");
            }
            else
            {
                Console.WriteLine("ID: " + sales.TitleId + "Price: " + sales.Price + "Sales: " + sales.Sales);
            }
        }
    }
}
