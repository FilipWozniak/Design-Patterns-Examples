using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodWebsite
{
    class PortfolioWebsite : Website
    { 
        string[] itemsFooter = { "Logo Image", "Copyright", "Contact" };
        string[] itemsLogo = { "Logo Image", "Name of the Brand" };
        string[] itemsMenu = { "Menu Items" };
        string[] itemsSlideshowSection = { "Image 1", "Image 2", "Image 3" };

        bool clientWantsBlockContentSection() { return false; }
        bool clientWantsLatestNewsSection() { return false; }
        bool clientWantsSearchBox() { return false; }
        bool clientWantsSideBar() { return false; }
        bool clientWantsPricingTable() { return false; }

        public override void AddBlockContentSection()
        {

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

        }

        public override void AddSideBar()
        {

        }

        public override void AddSlideshowSection()
        {
            Console.Write("Adding Slideshow Section: ");
            foreach (string item in itemsSlideshowSection)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}