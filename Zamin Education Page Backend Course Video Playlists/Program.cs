using System;
using System.Linq;
using System.Collections.Generic;
namespace Zamin_Education_Page_Backend_Course_Video_Playlists
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int pageCount = int.Parse(Console.ReadLine());
            int pageIndex = int.Parse(Console.ReadLine());

            //for (int i = pageIndex * pageCount - pageCount; i < pageIndex * pageCount ; i++ )
            //{
            //    Console.Write(nums[i] + " ");
            //}

            var items = nums.Skip(pageCount*pageIndex - pageCount).Take(pageCount);

            foreach (var item in items)
            {
                Console.Write(item + " ");
            }


        }
    }
}
