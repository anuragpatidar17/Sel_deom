using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Reflection;
using System.Text;



namespace SeleniumDemo
{
    [TestClass]
    public class SearchGoogle
    {
        [TestMethod]
        public void SearchForWord()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--headless");
            var driver = new ChromeDriver(options); 
           
            {
                //Notice navigation is slightly different than the Java version
                //This is because 'get' is a keyword in C#
                driver.Navigate().GoToUrl("http://www.google.com/");

                // Find the text input element by its name
                IWebElement query = driver.FindElement(By.Name("q"));
                
                string text = System.IO.File.ReadAllText(@"D:\a\1\s\SeleniumDemo\Test.txt");
                
               


                
                

                  query.SendKeys(text);
                // Enter something to search for
                

                // Now submit the form. WebDriver will find the form for us from the element
                 query.Submit();
                
                Console.WriteLine(text);

                // Google's search is rendered dynamically with JavaScript.
                // Wait for the page to load, timeout after 10 seconds
              

                driver.Quit();
            }

        }


    }
}
