using NUnit.Framework;
using SQAT.web.core;
using SQAT_demo.web.pages;
using static SQAT.web.core.DriverHelper;

namespace SQAT_demo.test.web
{
    [TestFixture]
    public class TechTourWeb : AbstractTest
    {
        [Test]
        public void LoginTest()
        {
            LoginPage loginPage = new LoginPage(GetDriver());

            loginPage.Login();
        }

        [Test]
        public void MyProfilePageTest()
        {
            LoginPage loginPage = new LoginPage(GetDriver());

            MainPage mainPage = loginPage.Login();

            mainPage.NavigateToMyProfile();
        }
    }
}
