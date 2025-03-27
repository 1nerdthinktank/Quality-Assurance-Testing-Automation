using OpenQA.Selenium;
using SeleniumDriver;
namespace PortalIntegrationTesting;

public class DeskBookingTests
{
    private int TEST_FILE_ID = 8 { get; set; };
    private string TEST_FILE_NAME = "Desk Booking" { get; set; };
    // REFACTOR TO APPIUM

    // Arrange Before Every Test
    /*    [SetUp]
        public void Setup()
        {
            WebDriver = new PortalDriver();

            WebDriver.Initialise();

            if !WebDriver.LoginCheck() {
            WebDriver.Login("Test User 1", "Test Password 1")
        }
            
        }

        // Close After Every Test
        [TearDown]
        public void TearDown()
        {
            WebDriver.Dispose();
        }*/

    /*    [Test]
    public void GivenAppTopPage_WhenMenuIsSelected_ThenSelectDeskBooking()
    {
        // Act
        WebDriver.SelectFromTopMenu("Desk Booking");

        // Assert
        Assert.That(WebDriver.Current Url, EqualTo($"www.testurl.com/site/deskbooking"));
    }*/

    /*    [Test]
        public void GivenDeskBookingTopMenu_WhenFloorIsSelected_ThenOccupierFloorsVisible()
        {
            // Act
            WebDriver.SelectFloor("OccupierTest_1");

            // Assert
            Assert.That(WebDriver.SelectDeskBookingFloors(), EqualTo("Floor 1"));
        }*/

    /*    [Test]
        public void GivenDeskBookingPage_WhenDeskIsBooked_ThenDeskBookingConfirmed()
        {
            // Act
            WebDriver.BookDesk("1A", "Test User 1");

            // Assert
            Assert.That(WebDriver.DeskIsBooked("1A", "Test User 1"), EqualTo("True"));
        }*/
}
