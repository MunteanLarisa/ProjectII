using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proiect.Presenters;
using Proiect.Views;
using System;

namespace UnitTestProjectII
{
    [TestClass]
    public class UnitTestLogin
    {
        [TestMethod]
        public void UsernameIsNotEmpty()
        {
            var user = new DummyUserLogin();
            var presenterLogin = new LoginPresenter(user);
            user.LoginPassword = "123";

            user.Login();
            Assert.AreEqual(expected: null, actual: user.LoginUsername, message: "The Username field should be initialized");
            Assert.IsTrue(user.ShowErrorMessageLogin, "Null username should trigger validation error");
            Assert.AreEqual(expected: "Username field cannot be empty", actual: user.ErrorMessageLogin, "Empty first name should have correct error message");

            user.LoginUsername = "lari";
            user.Login();
            Assert.AreEqual(expected: "lari", actual: user.LoginUsername, message: "The Username field should be initialized");
            Assert.IsFalse(condition: user.ShowErrorMessageLogin, message: "A filled in username should not trigger any errors");
            Assert.AreEqual(expected: null, actual: user.ErrorMessageLogin, "Filled in username should have no error message");
        }
        [TestMethod]
        public void PasswordIsNotEmpty()
        {
            var user = new DummyUserLogin();
            var presenterLogin = new LoginPresenter(user);
            user.LoginUsername = "lari";

            user.Login();
            Assert.AreEqual(expected: null, actual: user.LoginPassword, message: "The Password field should be initialized");
            Assert.IsTrue(user.ShowErrorMessageLogin, "Null password should trigger validation error");
            Assert.AreEqual(expected: "Password field cannot be empty", actual: user.ErrorMessageLogin, "Empty password should have correct error message");

            user.LoginPassword = "123";
            user.Login();
            Assert.AreEqual(expected: "123", actual: user.LoginPassword, message: "The Password field should be initialized");
            Assert.IsFalse(condition: user.ShowErrorMessageLogin, message: "A filled in password should not trigger any errors");
            Assert.AreEqual(expected: null, actual: user.ErrorMessageLogin, "Filled in password should have no error message");

        }
    }
    [TestClass]
    public class UnitTestSignup
    {
        [TestMethod]
        public void UsernameIsNotEmpty()
        {
            var user = new DummyUserSignup();
            var presenterSignup = new RegisterPresenter(user);
            user.Password = "123";
            user.ConfPassword = "123";

            user.Signup();
            Assert.AreEqual(expected: null, actual: user.Username, message: "The Username field should be initialized");
            Assert.IsTrue(user.ShowErrorMessageSignup, "Null username should trigger validation error");
            Assert.AreEqual(expected: "Username field cannot be empty", actual: user.ErrorMessageSignup, "Empty first name should have correct error message");

            user.Username = "lari";
            user.Signup();
            Assert.AreEqual(expected: "lari", actual: user.Username, message: "The Username field should be initialized");
            Assert.IsFalse(condition: user.ShowErrorMessageSignup, message: "A filled in username should not trigger any errors");
            Assert.AreEqual(expected: null, actual: user.ErrorMessageSignup, "Filled in username should have no error message");
        }
        [TestMethod]
        public void PasswordIsNotEmpty()
        {
            var user = new DummyUserSignup();
            var presenterSignup = new RegisterPresenter(user);
            user.Username = "lari";
            user.ConfPassword = "123";

            user.Signup();
            Assert.AreEqual(expected: null, actual: user.Password, message: "The Password field should be initialized");
            Assert.IsTrue(user.ShowErrorMessageSignup, "Null password should trigger validation error");
            Assert.AreEqual(expected: "Password field cannot be empty", actual: user.ErrorMessageSignup, "Empty password should have correct error message");

            user.Password = "123";
            user.Signup();
            Assert.AreEqual(expected: "123", actual: user.Password, message: "The Password field should be initialized");
            Assert.IsFalse(condition: user.ShowErrorMessageSignup, message: "A filled in password should not trigger any errors");
            Assert.AreEqual(expected: null, actual: user.ErrorMessageSignup, "Filled in password should have no error message");
        }
        [TestMethod]
        public void ConfPasswordIsNotEmpty()
        {
            var user = new DummyUserSignup();
            var presenterSignup = new RegisterPresenter(user);
            user.Username = "lari";
            user.Password = "123";

            user.Signup();
            Assert.AreEqual(expected: null, actual: user.ConfPassword, message: "The Confirmation Password field should be initialized");
            Assert.IsTrue(user.ShowErrorMessageSignup, "Null confirmation password should trigger validation error");
            Assert.AreEqual(expected: "Confirmation Password field cannot be empty", actual: user.ErrorMessageSignup, "Empty confirmation password should have correct error message");

            user.ConfPassword = "123";
            user.Signup();
            Assert.AreEqual(expected: "123", actual: user.ConfPassword, message: "The Confirmation Password field should be initialized");
            Assert.IsFalse(condition: user.ShowErrorMessageSignup, message: "A filled in confirmation password should not trigger any errors");
            Assert.AreEqual(expected: null, actual: user.ErrorMessageSignup, "Filled in confirmation password should have no error message");
        }


    }
    [TestClass]
    public class UnitTestCheckout
    {
        [TestMethod]
        public void FirstNameIsNotEmpty()
        {
            var user = new DummyUserCheckout();
            var presenterCheckout = new CheckoutPresenter(user);
            user.LastName = "Muntean";
            user.Email = "@lari";
            user.PhoneNumber = "12345678";
            user.CountryOfResidence = "Romania";
            user.Day = "14";
            user.Month = "01";
            user.Year = "2002";
            user.Checkout();
            Assert.AreEqual(expected: null, actual: user.FirstName, message: "The First Name field should be initialized");
            Assert.IsTrue(user.ShowErrorMessageCheckout, "Null first name should trigger validation error");
            Assert.AreEqual(expected: "First Name field cannot be empty", actual: user.ErrorMessageCheckout, "Empty first name should have correct error message");
            user.FirstName = "Larisa";
            user.Checkout();
            Assert.AreEqual(expected: "Larisa", actual: user.FirstName, message: "The First Name field should be initialized");
            Assert.IsFalse(condition: user.ShowErrorMessageCheckout, message: "A filled in First Name should not trigger any errors");
            Assert.AreEqual(expected: null, actual: user.ErrorMessageCheckout, "Filled in First Name should have no error message");

        }
        [TestMethod]
        public void LastNameIsNotEmpty()
        {
            var user = new DummyUserCheckout();
            var presenterCheckout = new CheckoutPresenter(user);
            user.FirstName = "Larisa";
            user.Email = "@lari";
            user.PhoneNumber = "12345678";
            user.CountryOfResidence = "Romania";
            user.Day = "14";
            user.Month = "01";
            user.Year = "2002";
            user.Checkout();
            Assert.AreEqual(expected: null, actual: user.LastName, message: "The Last Name field should be initialized");
            Assert.IsTrue(user.ShowErrorMessageCheckout, "Null last name should trigger validation error");
            Assert.AreEqual(expected: "Last Name field cannot be empty", actual: user.ErrorMessageCheckout, "Empty last name should have correct error message");

            user.LastName = "Muntean";
            user.Checkout();
            Assert.AreEqual(expected: "Muntean", actual: user.LastName, message: "The Last Name field should be initialized");
            Assert.IsFalse(condition: user.ShowErrorMessageCheckout, message: "A filled in Last Name should not trigger any errors");
            Assert.AreEqual(expected: null, actual: user.ErrorMessageCheckout, "Filled in Last Name should have no error message");

        }
        [TestMethod]
        public void EmailIsNotEmpty()
        {
            var user = new DummyUserCheckout();
            var presenterCheckout = new CheckoutPresenter(user);
            user.FirstName = "Larisa";
            user.LastName = "Muntean";
            user.PhoneNumber = "12345678";
            user.CountryOfResidence = "Romania";
            user.Day = "14";
            user.Month = "01";
            user.Year = "2002";
            user.Checkout();
            Assert.AreEqual(expected: null, actual: user.Email, message: "The Email field should be initialized");
            Assert.IsTrue(user.ShowErrorMessageCheckout, "Null email should trigger validation error");
            Assert.AreEqual(expected: "Email field cannot be empty", actual: user.ErrorMessageCheckout, "Empty email should have correct error message");

            user.Email = "@Lari";
            user.Checkout();
            Assert.AreEqual(expected: "@Lari", actual: user.Email, message: "The Email field should be initialized");
            Assert.IsFalse(condition: user.ShowErrorMessageCheckout, message: "A filled in Email should not trigger any errors");
            Assert.AreEqual(expected: null, actual: user.ErrorMessageCheckout, "Filled in Email should have no error message");


        }
        [TestMethod]
        public void PhoneNumberIsNotEmpty()
        {
            var user = new DummyUserCheckout();
            var presenterCheckout = new CheckoutPresenter(user);
            user.FirstName = "Larisa";
            user.LastName = "Muntean";
            user.Email = "@Lari";
            user.CountryOfResidence = "Romania";
            user.Day = "14";
            user.Month = "01";
            user.Year = "2002";
            user.Checkout();
            Assert.AreEqual(expected: null, actual: user.PhoneNumber, message: "The Phone Number field should be initialized");
            Assert.IsTrue(user.ShowErrorMessageCheckout, "Null phone number should trigger validation error");
            Assert.AreEqual(expected: "Phone Number field cannot be empty", actual: user.ErrorMessageCheckout, "Empty phone number should have correct error message");

            user.PhoneNumber = "12345678";
            user.Checkout();
            Assert.AreEqual(expected: "12345678", actual: user.PhoneNumber, message: "The PhoneNumber field should be initialized");
            Assert.IsFalse(condition: user.ShowErrorMessageCheckout, message: "A filled in PhoneNumber should not trigger any errors");
            Assert.AreEqual(expected: null, actual: user.ErrorMessageCheckout, "Filled in PhoneNumber should have no error message");
        }
        [TestMethod]
        public void DayIsNotEmpty()
        {
            var user = new DummyUserCheckout();
            var presenterCheckout = new CheckoutPresenter(user);
            user.FirstName = "Larisa";
            user.LastName = "Muntean";
            user.Email = "@Lari";
            user.CountryOfResidence = "Romania";
            user.PhoneNumber = "1234567";
            user.Month = "01";
            user.Year = "2002";
            user.Checkout();
            Assert.AreEqual(expected: null, actual: user.Day, message: "The Day field should be initialized");
            Assert.IsTrue(user.ShowErrorMessageCheckout, "Null day should trigger validation error");
            Assert.AreEqual(expected: "Day field cannot be empty", actual: user.ErrorMessageCheckout, "Empty day should have correct error message");

            user.Day = "14";
            user.Checkout();
            Assert.AreEqual(expected: "14", actual: user.Day, message: "The Day field should be initialized");
            Assert.IsFalse(condition: user.ShowErrorMessageCheckout, message: "A filled in Day should not trigger any errors");
            Assert.AreEqual(expected: null, actual: user.ErrorMessageCheckout, "Filled in Day should have no error message");
        }
        [TestMethod]
        public void MonthIsNotEmpty()
        {
            var user = new DummyUserCheckout();
            var presenterCheckout = new CheckoutPresenter(user);
            user.FirstName = "Larisa";
            user.LastName = "Muntean";
            user.Email = "@Lari";
            user.CountryOfResidence = "Romania";
            user.PhoneNumber = "1234567";
            user.Day = "14";
            user.Year = "2002";
            user.Checkout();
            Assert.AreEqual(expected: null, actual: user.Month, message: "The Month field should be initialized");
            Assert.IsTrue(user.ShowErrorMessageCheckout, "Null month should trigger validation error");
            Assert.AreEqual(expected: "Month field cannot be empty", actual: user.ErrorMessageCheckout, "Empty month should have correct error message");

            user.Month = "01";
            user.Checkout();
            Assert.AreEqual(expected: "01", actual: user.Month, message: "The Month field should be initialized");
            Assert.IsFalse(condition: user.ShowErrorMessageCheckout, message: "A filled in Month should not trigger any errors");
            Assert.AreEqual(expected: null, actual: user.ErrorMessageCheckout, "Filled in Month should have no error message");
        }
        [TestMethod]
        public void YearIsNotEmpty()
        {
            var user = new DummyUserCheckout();
            var presenterCheckout = new CheckoutPresenter(user);
            user.FirstName = "Larisa";
            user.LastName = "Muntean";
            user.Email = "@Lari";
            user.CountryOfResidence = "Romania";
            user.PhoneNumber = "1234567";
            user.Day = "14";
            user.Month = "01";
            user.Checkout();
            Assert.AreEqual(expected: null, actual: user.Year, message: "The Year field should be initialized");
            Assert.IsTrue(user.ShowErrorMessageCheckout, "Null year should trigger validation error");
            Assert.AreEqual(expected: "Year field cannot be empty", actual: user.ErrorMessageCheckout, "Empty year should have correct error message");

            user.Year = "2002";
            user.Checkout();
            Assert.AreEqual(expected: "2002", actual: user.Year, message: "The Year field should be initialized");
            Assert.IsFalse(condition: user.ShowErrorMessageCheckout, message: "A filled in Year should not trigger any errors");
            Assert.AreEqual(expected: null, actual: user.ErrorMessageCheckout, "Filled in Year should have no error message");
        }
        [TestMethod]
        public void EmailIsValid()
        {
            var user = new DummyUserCheckout();
            var presenterCheckout = new CheckoutPresenter(user);

            user.FirstName = "Larisa";
            user.LastName = "Muntean";
            user.Email = "Lari";
            user.PhoneNumber = "12345678";
            user.CountryOfResidence = "Romania";
            user.Day = "14";
            user.Month = "01";
            user.Year = "2002";
            user.Checkout();
            Assert.AreEqual(expected: "Lari", actual: user.Email, message: "The Email field should be initialized as 'Lari'");
            Assert.IsTrue(user.ShowErrorMessageCheckout, "Invalid email should trigger validation error");
            Assert.AreEqual(expected: "Email field must contain @ character", actual: user.ErrorMessageCheckout, "Invalid email should have correct error message");

            user.Email = "@Lari";
            user.Checkout();
            Assert.AreEqual(expected: "@Lari", actual: user.Email, message: "The Email field should be initialized");
            Assert.IsFalse(condition: user.ShowErrorMessageCheckout, message: "A valid Email should not trigger any errors");
            Assert.AreEqual(expected: null, actual: user.ErrorMessageCheckout, "Valid Email should have no error message");


        }
        [TestMethod]
        public void PhoneNumberIsValid()
        {
            var user = new DummyUserCheckout();
            var presenterCheckout = new CheckoutPresenter(user);
            user.FirstName = "Larisa";
            user.LastName = "Muntean";
            user.Email = "@Lari";
            user.CountryOfResidence = "Romania";
            user.PhoneNumber = "1234567890123";
            user.Day = "14";
            user.Month = "01";
            user.Year = "2002";
            user.Checkout();
            Assert.AreEqual(expected: "1234567890123", actual: user.PhoneNumber, message: "The PhoneNumber field should be initialized as '1234567890123'");
            Assert.IsTrue(user.ShowErrorMessageCheckout, "Invalid phone number should trigger validation error");
            Assert.AreEqual(expected: "Phone number must not contain more than 10 digits", actual: user.ErrorMessageCheckout, "Invalid phone number should have correct error message");

            user.PhoneNumber = "12345678";
            user.Checkout();
            Assert.AreEqual(expected: "12345678", actual: user.PhoneNumber, message: "The PhoneNumber field should be initialized");
            Assert.IsFalse(condition: user.ShowErrorMessageCheckout, message: "A valid PhoneNumber should not trigger any errors");
            Assert.AreEqual(expected: null, actual: user.ErrorMessageCheckout, "Valid PhoneNumber should have no error message");
        }

        [TestMethod]
        public void YearIsValid()
        {
            var user = new DummyUserCheckout();
            var presenterCheckout = new CheckoutPresenter(user);

            user.FirstName = "Larisa";
            user.LastName = "Muntean";
            user.Email = "@Lari";
            user.CountryOfResidence = "Romania";
            user.PhoneNumber = "1234567";
            user.Day = "14";
            user.Month = "01";
            user.Year = "2010";
            user.Checkout();
            Assert.AreEqual(expected: "2010", actual: user.Year, message: "The Year field should be initialized as '2010'");
            Assert.IsTrue(user.ShowErrorMessageCheckout, "Invalid year should trigger validation error");
            Assert.AreEqual(expected: "You must be over 18 years old", actual: user.ErrorMessageCheckout, "Invalid year should have correct error message");

            user.Year = "2002";
            user.Checkout();
            Assert.AreEqual(expected: "2002", actual: user.Year, message: "The Year field should be initialized");
            Assert.IsFalse(condition: user.ShowErrorMessageCheckout, message: "A valid Year should not trigger any errors");
            Assert.AreEqual(expected: null, actual: user.ErrorMessageCheckout, "Valid Year should have no error message");
        }


    }
    
    
    class DummyUserLogin : ILogin
    {
        public string LoginUsername { get ; set ; }
        public string LoginPassword { get ; set ; }
        public string ErrorMessageLogin { get ; set ; }
        public bool ShowErrorMessageLogin { get ; set ; }

        public event EventHandler? LoginAttempted;
        public void Login() => LoginAttempted?.Invoke(this, EventArgs.Empty);
    }
    class DummyUserSignup : IRegister
    {
        
        public string Username { get ; set; }
        public string Password { get; set; }
        public string ConfPassword { get; set; }
        public string ErrorMessageSignup { get; set; }
        public bool ShowErrorMessageSignup { get; set; }

        
        public event EventHandler? SignupAttempted;

        public void Signup() => SignupAttempted.Invoke(this, EventArgs.Empty);

        
    }
    class DummyUserCheckout : ICheckout
    {


        public string FirstName { get ; set ; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string CountryOfResidence { get; set; }
        public string Day { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public string ErrorMessageCheckout { get; set; }
        public bool ShowErrorMessageCheckout { get; set; }



        public event EventHandler? CheckoutAttempted;
        

        public void Checkout() => CheckoutAttempted.Invoke(this, EventArgs.Empty);


    }
}
