using System;
using System.Threading;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using Xunit;

namespace core_xunit_app
{
    public class ReactNavigationTests : IDisposable
    {
        private RemoteWebDriver _driver;
        private ChromeOptions _options;
        
        public ReactNavigationTests() 
        {
            var remoteDriverUrl = "http://chrome:4444/wd/hub";
            _options = new ChromeOptions();
            _driver = new RemoteWebDriver(new Uri(remoteDriverUrl), _options);

            // ChromeDriverService service = ChromeDriverService.CreateDefaultService(@"/usr/local/bin/", "chromedriver");
            // service.Port = 64444;
            // _driver = new ChromeDriver(service);
            // _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        [Fact]
        public void NavigateToHomePage()
        {
            //Thread.Sleep(5000);
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(@"http://frontend:3000/");
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            _driver.FindElementsByClassName("app-link")[0].Click();
            var title = _driver.FindElementByCssSelector("div.content > div > h1");

            Assert.Equal("Hello, world!", title.Text);
        }

        [Fact]
        public void NavigateToAboutPage()
        {
            //Thread.Sleep(5000);
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(@"http://frontend:3000/");
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            _driver.FindElementsByClassName("app-link")[1].Click();
            var title = _driver.FindElementByCssSelector("div.content > div > h1");

            Assert.Equal("About", title.Text);
        }

        [Fact]
        public void NavigateToWeatherPage()
        {
            //Thread.Sleep(5000);
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(@"http://frontend:3000/");
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            _driver.FindElementsByClassName("app-link")[2].Click();
            var title = _driver.FindElementByCssSelector("div.content > div > h1");

            Assert.Equal("Weather", title.Text);
        }  

        [Fact]
        public void WeatherPageDataLoaded()
        {
            //Thread.Sleep(5000);
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(@"http://frontend:3000/");
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            _driver.FindElementsByClassName("app-link")[2].Click();
            var title = _driver.FindElementByCssSelector("div.content > div > p");

            Assert.Equal("80F and Sunny", title.Text);
        }          

        public void Dispose()
        {
            _driver.Quit();
        }
    }
}
