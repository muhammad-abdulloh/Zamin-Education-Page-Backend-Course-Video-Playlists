using System;
using System.Linq;
using System.Collections.Generic;
namespace Zamin_Education_Page_Backend_Course_Video_Playlists
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<WebPages> list = new List<WebPages>()
            {
                new WebPages
                {
                    Id = 1,
                    Title = "Frontend",
                    Description = "Umumiy Frontend"
                },

                new WebPages
                {
                    Id = 2,
                    Title = "Backend",
                    Description = "Umumiy Backend"
                },

                new WebPages
                {
                    Id = 3,
                    Title = "Dte Base",
                    Description = "Umumiy Date Base"
                },

                new WebPages
                {
                    Id = 4,
                    Title = "XML",
                    Description = "Umumiy XML"
                },

                new WebPages
                {
                    Id = 5,
                    Title = "Data Structure",
                    Description = "Umumiy Date Structure"
                },


            };



            int pageCount = int.Parse(Console.ReadLine());
            int pageIndex = int.Parse(Console.ReadLine());

            //for (int i = pageIndex * pageCount - pageCount; i < pageIndex * pageCount ; i++ )
            //{
            //    Console.Write(nums[i] + " ");
            //}

            var items = list.Skip(pageCount*pageIndex - pageCount).Take(pageCount);

            foreach (var item in items)
            {
                Console.Write(item.Id + " ");
            }



            var a = 10;
            a = "dewfreg";


            dynamic c = 30;
            c = "ddasd";

            object b = 10;
            b = "sdfcds";
        }
    }
}
