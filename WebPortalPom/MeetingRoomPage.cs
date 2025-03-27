using OpenQA.Selenium;
using SeleniumDriver;
namespace PortalIntegrationTesting;

public class MeetingRoomBookingTests
{
    private int TEST_FILE_ID = 7 { get; set; };
    private string TEST_FILE_NAME = "Meeting Room Booking" { get; set; };
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
    public void GivenAppTopPage_WhenMenuIsSelected_ThenSelectMeetingRooms()
    {
        // Act
        WebDriver.SelectFromTopMenu("Meeting Rooms");

        // Assert
        Assert.That(WebDriver.Current Url, EqualTo($"www.testurl.com/site/MeetingRooms"));
    }*/

    /*    [Test]
        public void GivenMeetingRoomTopMenu_WhenMeetingRoomIsSelected_ThenSelectBookingTimeRange()
        {
            // Act
            WebDriver.BookMeetingRoom("Meeting Room Test_1", (12:00, 13:00));

            // Assert
            Assert.That(WebDriver.GetCurrentMeetingRoomBookings("0"), EqualTo("Meeting Room Test_1", (12:00, 13:00)));
        }*/

}