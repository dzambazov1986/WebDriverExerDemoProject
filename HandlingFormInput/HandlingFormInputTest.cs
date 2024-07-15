using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Security.Claims;

namespace HandlingFormInput
{
    public class HandlingFormInputTest

    {
        WebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://practice.bpbonline.com/");
        }   
        [TearDown]
        public void TearDown()
        {
            driver.Quit();  
            driver.Dispose();
        }



        [Test]
        public void HandlingFormInputs()
        {
            //locate login
           driver.FindElement(By.CssSelector("#tdb3 > .ui-button-text")).Click();
            driver.FindElement(By.Id("tdb4")).Click();

            //select gender
            driver.FindElement(By.Name("gender")).Click();

            //fill value user name

            driver.FindElement(By.Name("firstname")).Click();
            driver.FindElement(By.Name("firstname")).SendKeys("Dimityr");

            // fill value last name

            driver.FindElement(By.Name("lastname")).Click();
            driver.FindElement(By.Name("lastname")).SendKeys("Dzhambazov");

            //fill in date element

            driver.FindElement(By.Id("dob")).Click();
            driver.FindElement(By.Id("dob")).SendKeys("12/25/1986");
            driver.FindElement(By.Id("dob")).SendKeys(Keys.Enter);

            // generate a unique  email addres

            Random rnd = new Random();

            //Generate a random number between 1000 and 9999 
            int num = rnd.Next(1000, 9999);
            String email = "fiona.apple" + num.ToString() + "@example.com";
           

            // fill street adress

            driver.FindElement(By.Name("street_address")).Click();
            driver.FindElement(By.Name("street_address")).SendKeys("Vladislavovo");
           

            // fill value 


            driver.FindElement(By.XPath("//td[@class = 'fieldValue']//input" +
                "[@name='suburb']")).SendKeys("Varna");
            // fill postcode
            

            driver.FindElement(By.Name("postcode")).Click();
            driver.FindElement(By.Name("postcode")).SendKeys("9000");
          


            // fill city

            driver.FindElement(By.Name("city")).Click();
            driver.FindElement(By.Name("city")).SendKeys("Varna");
            driver.FindElement(By.Name("state")).Click();
            driver.FindElement(By.Name("state")).SendKeys("Vladislavovo bloka");
            driver.FindElement(By.Name("country")).Click();
            {
                var dropdown = driver.FindElement(By.Name("country"));
                dropdown.FindElement(By.XPath("//option[. = 'Bulgaria']")).Click();
            }
            driver.FindElement(By.Name("telephone")).Click();
            driver.FindElement(By.Name("telephone")).SendKeys("0884003545");
            driver.FindElement(By.Name("password")).Click();
            driver.FindElement(By.Name("password")).SendKeys("mitko123");
            driver.FindElement(By.Name("confirmation")).Click();
            driver.FindElement(By.Name("confirmation")).SendKeys("mitko123");
            driver.FindElement(By.CssSelector("#tdb4 > .ui-button-text")).Click();
         


        }
    }
}