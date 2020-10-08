using OpenQA.Selenium.Remote;
using SQAT.web.core;

namespace SQAT_demo.web.pages
{
    public class MainPage : AbstractPage
    {
        private WebElement MyProfile { get; set; }

        private WebElement MyProfileChoice { get; set; }

        public MainPage(RemoteWebDriver driver) : base(driver)
        {
        }

        public MyProfilePage NavigateToMyProfile()
        {
            MyProfile = WebElement.FindByXpath("//a[@class='nav-control-link']//span[@class='ng-scope'][contains(text(),'My Profile')]");

            MyProfile.Click();

            MyProfileChoice = WebElement.FindByXpath("//a[@class='nav-subitem-link']//span[@class='ng-scope'][contains(text(),'My Profile')]");

            MyProfileChoice.Click();

            return new MyProfilePage(GetDriver());
        }
    }
}
