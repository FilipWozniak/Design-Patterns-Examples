using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodWebsite
{
    abstract class Website
    {
        public void CreateWebsite(string name)
        {
            InstallCMS();   // COMMON ELEMENT

            if(clientWantsMenu())
            {
                AddMenu();
            }

            if (clientWantsLogo())
            {
                AddLogo();
            }

            if (clientWantsBlockContentSection())
            {
                AddBlockContentSection();
            }

            if (clientWantsLatestNewsSection())
            {
                AddLatestNewsSection();
            }

            if (clientWantSlideshowSection())
            {
                AddSlideshowSection();
            }

            if (clientWantsSearchBox())
            {
                AddSearchBox();
            }

            if (clientWantsSideBar())
            {
                AddSideBar();
            }

            if (clientWantsPricingTable())
            {
                AddPricingTable();
            }

            if (clientWantsFooter())
            {
                AddFooter();
            }

            DeployWebPage(name);    // COMMON ELEMENT

        }

        public void InstallCMS()
        {
            Console.WriteLine("The CMS is Installed");
        }

        public void DeployWebPage(string name)
        {
            Console.WriteLine("Website Name: " + name);
        }

        public abstract void AddMenu();
        public abstract void AddLogo();
        public abstract void AddBlockContentSection();
        public abstract void AddLatestNewsSection();
        public abstract void AddSlideshowSection();
        public abstract void AddSearchBox();
        public abstract void AddSideBar();
        public abstract void AddPricingTable();
        public abstract void AddFooter();

        bool clientWantsMenu() { return true; }
        bool clientWantsLogo() { return true; }
        bool clientWantsBlockContentSection() { return true; }
        bool clientWantsLatestNewsSection() { return true; }
        bool clientWantSlideshowSection() { return true; }
        bool clientWantsSearchBox() { return true; }
        bool clientWantsSideBar() { return true; }
        bool clientWantsPricingTable() { return true; }
        bool clientWantsFooter() { return true; }

    }
}