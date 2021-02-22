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
        ///<summary>
        ///UC3:Check wheather the eamil id is valid or not
        ///</summary>
        [TestCase("abc@yahoo.com")]
        [TestCase("abc-100@yahoo.com,")]
        [TestCase("abc.100@yahoo.com")]
        [TestCase("abc111@abc.com,")]
        [TestCase("abc-100@abc.net,")]
        [TestCase("abc.100@abc.com.au")]
        [TestCase("abc@1.com,")]
        [TestCase("abc@gmail.com.com")]
        [TestCase("abc+100@gmail.com")]
        [TestCase("abc")]
        [TestCase("abc@.com.my")]
        [TestCase("abc123@gmail.a")]
        [TestCase("abc123@.com")]
        [TestCase("abc@.com.com")]
        [TestCase(".abc@abc.com")]
        [TestCase("abc()*@gmail.com")]
        [TestCase("abc@%*.com")]
        [TestCase("abc..2002@gmail.com")]
        [TestCase("abc.@gmail.com")]
        [TestCase("abc@abc@gmail.com")]
        [TestCase("abc@gmail.com.1a")]
        [TestCase("abc@gmail.com.aa.au")]
        public void Check_Wheather_EmailId_isvalidOrNot(string samplemail)
        {
            //Act
            string actual = " ";
            try
            {
                actual = userRegistration.EmailId(samplemail);
            }
            catch (UserregistrationcustomException exception)
            {
                Assert.AreEqual("Email is not valid", exception.Message);
            }
        }

        
    }
}