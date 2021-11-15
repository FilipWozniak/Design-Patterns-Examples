using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodWebsite
{
    class BlogWebsite : Website
    {
        string[] itemsBlockContent = { "Company Description", "Team Members" };
        string[] itemsFooter = { "Logo Image", "Copyright", "Contact" };
        string[] itemsLatestNews = { "News Content", "News Date", "News Image" };
        string[] itemsLogo = { "Logo Image", "Name of the Brand" };
        string[] itemsMenu = { "Menu Items" };
        string[] itemsSearchBox = { "Search Field", "Search Button", "Checkbox Fields" };

        bool clientWantSlideshowSection() { return false; }
        bool clientWantsSideBar() { return false; }
        bool clientWantsPricingTable() { return false; }

        public override void AddBlockContentSection()
        {
            Console.Write("Adding Block Content Section: ");
            foreach (string item in itemsBlockContent)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public override void AddFooter()
        {
            Console.Write("Adding Footer: ");
            foreach (string item in itemsFooter)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public override void AddLatestNewsSection()
        {
            Console.Write("Adding Latest News Section: ");
            foreach (string item in itemsLatestNews)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public override void AddLogo()
        {
            Console.Write("Adding Logo: ");
            foreach (string item in itemsLogo)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public override void AddMenu()
        {
            Console.Write("Adding Block Content Section: ");
            foreach (string item in itemsMenu)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public override void AddPricingTable()
        {

        }

        public override void AddSearchBox()
        {
            Console.Write("Adding Search Box: ");
            foreach (string item in itemsSearchBox)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public override void AddSideBar()
        {

        }

        public override void AddSlideshowSection()
        {

        }
    }
}
