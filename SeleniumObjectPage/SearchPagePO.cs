using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumObjectPage
{
    class SearchPagePO
    {
        public SearchPagePO()
        {
            PageFactory.InitElements(PropertiesCollection.Driver, this);
        }

        [FindsBy(How = How.Id, Using = "lst-ib")]
        public IWebElement SearchFieldId { get; set; }

        [FindsBy(How = How.Name, Using = "btnG")]
        public IWebElement SearchBtnName { get; set; }

        public void Search(string text)
        {

            SearchFieldId.EnterText(text);
            SearchBtnName.Clicks();

            //SeleniumSetMethods.EnterText(SearchFieldId, text);
            //SeleniumSetMethods.Click(SearchBtnName);

            //SearchFieldId.SendKeys(text);
            //SearchBtnName.Click();
        }
    }
}
