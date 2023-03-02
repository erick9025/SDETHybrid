using CoreFramework.AllFeatures.Web.ParentClasses;
using CoreFramework.Driver;
using CoreFramework.Logger;
using CoreFramework.Utilities;
using OpenQA.Selenium;
using System;
using System.Linq;

namespace CoreFramework.AllFeatures.Web.Interactions
{
    public class FacebookInteractions : Features
    {
        private DDLSelectionMethod method = DDLSelectionMethod.LINQAttributeString;

        public FacebookInteractions(Browser browser) : base(browser)
        {

        }

        public FacebookInteractions GoTo()
        {
            Browser.GoToURL(FacebookAbilities.FacebookURL);

            return this;
        }

        public FacebookInteractions CreateAccount(FacebookUser user)
        {
            //Open Facebook main page
            GoTo();

            //Enter basic user info
            StandardMethods
                .Click(FacebookElements.ButtonCreateAccount, "Create New Account [Button]")
                .EnterText(FacebookElements.InputName, "Name [Input]", user.FirstName)
                .EnterText(FacebookElements.InputLastName, "Last name [Input]", user.LastName)
                .EnterText(FacebookElements.InputRegEmail, "Email [Input]", user.Email)
                .EnterText(FacebookElements.InputRegEmailConfirm, "Re-enter Email [Input]", user.Email)
                .EnterText(FacebookElements.InputRegPass, "Password [Input]", user.Password)
                .Wait(1);

            //Enter DOB: Month
            StandardMethods
                .Click(FacebookElements.DdlOptionsBirthdayMonth[user.DateOfBirth.Month - 1], "Month [Option]")
                .Wait(1);

            //Enter DOB: Day
            StandardMethods
                .Click(FacebookElements.DdlOptionsBirthdayDay[user.DateOfBirth.Day - 1], "Day [Option]")
                .Wait(1);

            //Enter DOB: Year (Old code left for reference ONLY -> Index is not reliable when selecting Year?
            switch (method)
            {
                case DDLSelectionMethod.ByIndex:
                    StandardMethods
                        .Click(FacebookElements.DdlOptionsBirthdayYear[24], "Year [Option]");
                    break;

                case DDLSelectionMethod.Lambda:
                    //Sample loop using lambda function with 'for each' statement
                    FacebookElements.DdlOptionsBirthdayYear.ToList().ForEach(ddlOption =>
                    {
                        string attributeValue = ddlOption.GetAttribute("value");
                        if (Convert.ToInt32(attributeValue) == user.DateOfBirth.Year)
                        {
                            StandardMethods
                                .Click(ddlOption, "Year [Option] using Lambda");
                            return; //Terminate foreach when condition is met
                        }
                    });
                    break;

                case DDLSelectionMethod.ForEach:
                    //Sample foreach regular loop
                    foreach (IWebElement ddlOption in FacebookElements.DdlOptionsBirthdayYear.ToList())
                    {
                        string attributeValue = ddlOption.GetAttribute("value");
                        if (Convert.ToInt32(attributeValue) == user.DateOfBirth.Year)
                        {
                            StandardMethods
                                .Click(ddlOption, "Year [Option] using Loop");
                            break; //Break foreach when condition is met
                        }
                    }
                    break;

                case DDLSelectionMethod.LINQAttributeString:
                    StandardMethods
                        .Click(FacebookElements.DdlOptionsBirthdayYear.ToList().Where(option => option.GetAttribute("value") == user.DateOfBirth.Year.ToString()).FirstOrDefault()
                                , "Year [Option] using LINQ with String");
                    break;

                case DDLSelectionMethod.LINQAttributeInt:
                    StandardMethods
                        .Click(FacebookElements.DdlOptionsBirthdayYear.ToList().Where(option => Convert.ToInt32(option.GetAttribute("value")) == user.DateOfBirth.Year).FirstOrDefault()
                                , "Year [Option] using LINQ with Int");
                    break;
            }

            //Finally select gender/sex
            switch (user.Gender)
            {
                case Gender.Female:
                    StandardMethods
                        .Click(FacebookElements.RadioButtonGenderFemale, "Female [Radio Button]");
                    break;

                case Gender.Male:
                    StandardMethods
                        .Click(FacebookElements.RadioButtonGenderMale, "Male [Radio Button]");
                    break;

                case Gender.NonBinary:
                    StandardMethods
                        .Click(FacebookElements.RadioButtonGenderCustom, "Custom [Radio Button]");

                    Log.Info("Selecting Pronoun");
                    foreach (IWebElement ddlOption in FacebookElements.DdlOptionsPronoun.ToList())
                    {
                        string attributeValue = ddlOption.GetAttribute("value");
                        if (Convert.ToInt32(attributeValue) == user.PronounId)
                        {
                            StandardMethods
                                .Click(ddlOption, "Pronoun [Option] using Loop");
                            break; //Break foreach when condition is met
                        }
                    }

                    break;

                default:
                    Log.AssertFail("Not handled scenario yet: " + user.Gender);
                    break;
            }

            Log.Info("End of method");
            return this;
        }
    }
}
