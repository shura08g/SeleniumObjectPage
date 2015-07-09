using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumObjectPage
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        [SetUp]
        public void Initialize()
        {
            // Create WebDriver
            PropertiesCollection.Driver = new FirefoxDriver();

            // Navigate to google page
            PropertiesCollection.Driver.Navigate().GoToUrl("https://www.google.com.ua");

            Console.WriteLine("Opened URL");
        }

        [Test]
        public void SearchTest()
        {
            // Initialize the page by calling its reference
            SearchPagePO page = new SearchPagePO();

          //  page.SearchFieldId.SendKeys("Testing search page");
          //  page.SearchBtnName.Click();

            page.Search("Testing search page");

        }

        [Test]
        public void SearchTestExcel()
        {
            ExcelLib.PopulateInCollection(@"Test.xlsx");

            // Initialize the page by calling its reference
            SearchPagePO page = new SearchPagePO();
            page.Search(ExcelLib.ReadData(1, "SearchText"));

        }

        [Test]
        public void SearchTestExcelCicle()
        {
            ExcelLib.PopulateInCollection(@"Test.xlsx");

            // Initialize the page by calling its reference
            for (int i = 1; i <= 3; i++)
            {
                PropertiesCollection.Driver.Close();
                PropertiesCollection.Driver = new FirefoxDriver();
                PropertiesCollection.Driver.Navigate().GoToUrl("https://www.google.com.ua");
                SearchPagePO page = new SearchPagePO();
                page.Search(ExcelLib.ReadData(i, "SearchText"));
                PropertiesCollection.Driver.Close();
            }

        }

        [TearDown]
        public void CleanUp()
        {
            // Close browser
            PropertiesCollection.Driver.Close();

            Console.WriteLine("Close browser");
        }
    }
}
