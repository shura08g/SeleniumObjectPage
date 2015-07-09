using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumObjectPage
{
    enum PropertyType
    {
        Id,
        Name,
        LinkText,
        CssName,
        ClassName
    }

    class PropertiesCollection
    {
        // Auto-implemented Property
        public static IWebDriver Driver { get; set; }
    }
}
