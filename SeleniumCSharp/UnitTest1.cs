using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;


namespace SeleniumCSharp
{
    public class Tests
    {

        IWebDriver driver;
        String test_url = "https://karlstevenmellikov.wordpress.com/";
        private readonly Random _random = new Random();

        [SetUp]
        public void start_browser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void test_pages_without_foreach()
        {
            driver.Url = test_url;
            driver.Navigate().GoToUrl("https://karlstevenmellikov.wordpress.com/");

            try
            {
                IWebElement sButton2 = driver.FindElement(By.XPath("//li[@class='page_item page-item-54']"));
                sButton2.Click();
            }
            catch (Exception) { }
            Thread.Sleep(1000);
            try { IWebElement sButton2 = driver.FindElement(By.XPath("//li[@class='page_item page-item-59']")); sButton2.Click(); } catch (Exception) { }
            Thread.Sleep(1000);
            try { IWebElement sButton2 = driver.FindElement(By.XPath("//li[@class='page_item page-item-57']")); sButton2.Click(); } catch (Exception) { }
            Thread.Sleep(1000);
            try { IWebElement sButton2 = driver.FindElement(By.XPath("//li[@class='page_item page-item-61']")); sButton2.Click(); } catch (Exception) { }
            Thread.Sleep(1000);
            try { IWebElement sButton2 = driver.FindElement(By.XPath("//li[@class='page_item page-item-52']")); sButton2.Click(); } catch (Exception) { }
            Thread.Sleep(1000);
            try { IWebElement sButton2 = driver.FindElement(By.XPath("//li[@class='page_item page-item-2']")); sButton2.Click(); } catch (Exception) { }
            Thread.Sleep(1000);
            try { IWebElement sButton2 = driver.FindElement(By.XPath("//li[@class='page_item page-item-112']")); sButton2.Click(); } catch (Exception) { }
            Thread.Sleep(1000);
            try { IWebElement sButton2 = driver.FindElement(By.XPath("//li[@class='page_item page-item-109']")); sButton2.Click(); } catch (Exception) { }
            Thread.Sleep(1000);
            try { IWebElement sButton2 = driver.FindElement(By.XPath("//li[@class='page_item page-item-24']")); sButton2.Click(); } catch (Exception) { }

            driver.Quit();
        }
        [Test]
        public void test_links_with_foreach()
        {
            driver.Url = test_url;
            driver.Navigate().GoToUrl("https://karlstevenmellikov.wordpress.com/");

            bool TestSecondaryLinks = true;
            string[] LinksArray = new string[]
            {
            "//p[@class='has-text-align-center has-large-font-size']//a[normalize-space()='Noorem tarkvaraarendaja õpitee']",
            "//p[@class='has-text-align-center has-large-font-size']//a[normalize-space()='Veebiteenused õppimiseks']",
            "//a[normalize-space()='Arvuti ja taristu osad']",
            "//p[@class='has-text-align-center has-large-font-size']//a[normalize-space()='Kontoritöö tarkvara']",
            "//a[normalize-space()='Karjääritee ja kutsealane areng']",
            "//p[@class='has-text-align-center has-large-font-size']//a[normalize-space()='Multimeedia']",
            "//a[normalize-space()='Tarkvara arendusprotsess:']",
            "//p[@class='has-text-align-center has-large-font-size']//a[normalize-space()='Programmeerimise alused:']"
            };
            try
            {
                foreach (string xpath in LinksArray)
                {
                    IWebElement dropDown = driver.FindElement(By.XPath(xpath));
                    dropDown.Click();
                    Thread.Sleep(1000);
                    driver.Navigate().GoToUrl("https://karlstevenmellikov.wordpress.com/");
                    Thread.Sleep(1000);
                }
            }

            catch (Exception)
            {
                TestSecondaryLinks = false;
            }

            if (TestSecondaryLinks)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail("Link not working!");
            }
            driver.Quit();
        }

        [Test]
        public void test_bottom_images()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            driver.Navigate().GoToUrl("https://karlstevenmellikov.wordpress.com");
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");

            try { IWebElement sButton2 = driver.FindElement(By.XPath("//article[@id='post-2']/div/figure/figure[1]/img[@class='wp-image-65']")); sButton2.Click(); } catch (Exception) { }
            Thread.Sleep(2000);
            try { IWebElement sButton2 = driver.FindElement(By.XPath("//html/body/div[5]/div/div[2]/svg/g/rect x")); sButton2.Click(); } catch (Exception) { }
            Thread.Sleep(2000);
            driver.Quit();

        }
    }
}



