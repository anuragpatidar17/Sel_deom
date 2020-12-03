using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Reflection;
using System.Text;
using NPOI.SS.UserModel;
using System.Threading;
using NPOI.Util;
using NPOI.XSSF.UserModel;



namespace SeleniumDemo
{
    [TestClass]
    public class SearchGoogle
    {
        [TestMethod]
        public void SearchForWord()
        {
            //ChromeOptions options = new ChromeOptions();
            //options.AddArgument("--headless");
            var driver = new ChromeDriver(); 
           
            {
                FileStream file = new FileStream(@"D:\a\1\s\SeleniumDemo\Book1.xlsx", FileMode.Open, FileAccess.Read);
                XSSFWorkbook workbook = new XSSFWorkbook(file);
                ISheet sheet = workbook.GetSheet("Sheet1");

                var value = string.Format(sheet.GetRow(0).GetCell(0).StringCellValue);
                //Notice navigation is slightly different than the Java version
                //This is because 'get' is a keyword in C#
                driver.Navigate().GoToUrl("http://www.google.com/");

                // Find the text input element by its name
                IWebElement query = driver.FindElement(By.Name("q"));
                
                query.SendKeys(value);
                
                string check_value = query.GetAttribute("value");
                
                //string text = System.IO.File.ReadAllText(@"D:\a\1\s\SeleniumDemo\Test.txt");
                
                
               


                
                

                
                Console.WriteLine(check_value);

                // Google's search is rendered dynamically with JavaScript.
                // Wait for the page to load, timeout after 10 seconds
              

                driver.Quit();
            }

        }


    }
}
