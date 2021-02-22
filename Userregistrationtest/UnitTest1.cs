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
        /// <summary>
        /// UC1: check wheather the first name is valid or not 
        /// </summary>

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
        ///<summary>
        ///UC2: check wheather the  last name is valid or not
        ///</summary>
        [Test]
        public void Check_Wheather_LastName_Is_ValidOrInvalid()
        {
            //Act
            string[] pattpatternlastName = { "Karle", "Sonal" };
            string actual = " ";
            try
            {
                actual = userRegistration.LastName(pattpatternlastName);
            }
            catch (UserregistrationcustomException exception)
            {
                //Assert
                Assert.AreEqual("Last name is not valid", exception.Message);
            }
        }
    }
}