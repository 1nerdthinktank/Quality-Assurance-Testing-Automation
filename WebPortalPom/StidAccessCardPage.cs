using SeleniumDriver;

namespace PortalIntegrationTesting;

public class StidAccessCardTests
{

    private int TEST_FILE_ID = 4 { get; set; };
    private string TEST_FILE_NAME = "STID Card" { get; set; };

    private PortalDriver WebDriver { get; set; }


    // Arrange Before Every Test
    [SetUp]
    public void Setup()
    {
        WebDriver = new PortalDriver();
        WebDriver.Initialise();
    }

    // Close After Every Test
    [TearDown]
    public void TearDown()
    {
        WebDriver.Dispose();
    }

    // Stid Tests

    /*
         [Test]
        public void GivenEditUserPage_WhenStidCardDoesNotExist_ThenCreateCard()
        {
            // Act
            WebDriver.CreateCard(Stid);

            // Assert
            Assert.That(WebDriver.EditUserPage.User("Test User").IsCardCreated, Is.EqualTo("True"));
        }

        
         [Test]
        public void GivenEditUserPage_WhenStidCardExists_ThenDeleteCard()
        {
            // Act
            WebDriver.DeleteCard(Stid);

            // Assert
            Assert.That(WebDriver.EditUserPage.User("Test User").IsCardCreated, Is.EqualTo("False"));
        }
*/
        

    // What does delete card from the user list top menu do?
}

