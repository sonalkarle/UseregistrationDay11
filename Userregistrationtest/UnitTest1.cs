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
            
            string[] patternfirstname = { "Sonal", "Karle" };
            string actual = " ";
            try
            {
                //Act
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
                //Act
                actual = userRegistration.LastName(pattpatternlastName);
            }
            catch (UserregistrationcustomException exception)
            {
                //Assert
                Assert.AreEqual("Last name is not valid", exception.Message);
            }
        }
        /// <summary>
        /// UC3: Check wheather the email id is valid or not
        /// </summary>
        
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
            
            string actual = " ";
            try
            {
                //Act
                actual = userRegistration.EmailId(samplemail);
            }
            catch (UserregistrationcustomException exception)
            {
                //Assert
                Assert.AreEqual("Email is not valid", exception.Message);
            }
        }
        /// <summary>
        /// UC4: Check wheather phone number is valid or not
        /// </summary>
        [Test]
        public void Check_Wheather_Mobilenum_IsValidOrNot()
        {
            string[] patternMobileNum = { " 91 9702420754 ", "91 8806184089" };
            string actual = " ";
            try
            {
                //Act
                actual = userRegistration.Mobilenumber(patternMobileNum);
            }
            catch (UserregistrationcustomException exception)
            {
                //Assert
                Assert.AreEqual("Phone number is not valid", exception.Message);
            }

        }
        ///<summary>
        ///UC5: Check wheather password is valid or not
        ///</summary>
        public void Check_Wheather_Password_IsvalidOrNot()
        {
            string[] patternPassword = { "Kasf@123D", "SD@109YHG" };
            string actual = " ";
            try
            {
                //Act
                actual = userRegistration.Password(patternPassword);
            }
            catch (UserregistrationcustomException exception)
            {
                //Assert 
                Assert.AreEqual("Password is not valid ", exception.Message);
            }
        }

    }
}