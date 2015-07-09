using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumObjectPage
{
    public static class SeleniumSetMethods
    {
        /// <summary>
        /// Extended method for entering text in the control
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        // Eneter Text
       // public static void EnterText(IWebElement element, string value)
        public static void EnterText(this IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        /// <summary>
        /// Extended method for clicking in the control
        /// </summary>
        /// <param name="element"></param>
        //Click into a button, checkBox, option ect
        //public static void Click(IWebElement element)
        public static void Clicks(this IWebElement element)
        {
            element.Click();
        }

        /// <summary>
        /// Extended method for entering selecting in the drop down control
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        // Eneter Text
        // Selecting a drop down control
        //public static void SelectDropDown(IWebElement element, string value)
        public static void SelectDropDown(this IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
        }

 /*       // Eneter Text
        public static void EnterText(string element, string value, PropertyType elementType)
        {
            // if (elementType.ToLower() == "id")
            if (elementType == PropertyType.Id)
                PropertiesCollection.Driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementType == PropertyType.Name)
                PropertiesCollection.Driver.FindElement(By.Name(element)).SendKeys(value);
        }

        //Click into a button, checkBox, option ect
        public static void Click(string element, PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
                PropertiesCollection.Driver.FindElement(By.Id(element)).Click();
            if (elementType == PropertyType.Name)
                PropertiesCollection.Driver.FindElement(By.Name(element)).Click();
        }

        // Selecting a drop down control
        public static void SelectDropDown(string element, string value, PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
                new SelectElement(PropertiesCollection.Driver.FindElement(By.Id(element))).SelectByText(value);
            if (elementType == PropertyType.Name)
                new SelectElement(PropertiesCollection.Driver.FindElement(By.Name(element))).SelectByText(value);
        }
  */

    }
}

