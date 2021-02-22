using NUnit.Framework;
using UserRegistration;
using UserRegistrationclass;

namespace Userregistrationtest
{
    public class Tests
    {
        Userregistrationclass userRegistration;
        [SetUp]
        public void Setup()
        {
            //Arrange 
            userRegistration = new Userregistrationclass();
        }

        [Test]
        public void Check_Wheather_Firstname_Is_ValidOrInvalid ()
        {
            //Act
            string[] patternfirstname = { "Sonal", "Karle" };
            string actual = " ";
            try
            {
                actual = userRegistration.FirstName(patternfirstname);
            }
            catch (UserregistrationcustomException exception)

            {
                //Assert
                Assert.AreEqual("FirstName is not valid", exception.Message);
            }
        }
    }
}