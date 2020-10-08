using OpenQA.Selenium.Remote;
using SQAT.web.core;

namespace SQAT_demo.web.pages
{
    public class LoginPage : AbstractPage
    {
        private WebElement Email { get; set; }
        private WebElement Password { get; set; }
        private WebElement SignInButton { get; set; }
        private WebElement RememberMe { get; set; }

        public LoginPage(RemoteWebDriver driver) : base(driver)
        {
        }

        public MainPage Login()
        {
            Email = WebElement.FindById("email");
            Email.Input("testo18@te.st");

            Password = WebElement.FindById("password");
            Password.Input("test3");

            RememberMe = WebElement.FindById("rememberMe");
            RememberMe.Uncheck();

            SignInButton = WebElement.FindByXpath("//button[@class='btn btn-primary ng-scope']");
            SignInButton.Click();

            return new MainPage(GetDriver());
        }
    }
}
