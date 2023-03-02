using CoreFramework.Driver;
using CoreFramework.AllFeatures.Parent;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

namespace CoreFramework.AllFeatures.Web.Elements
{
    public class FacebookElements : BasePage
    {
        public FacebookElements(Browser browser) :  base(browser)
        {
            
        }

        [FindsBy(How = How.XPath, Using = "//a[@data-testid='open-registration-form-button']")]
        public IWebElement ButtonCreateAccount { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='firstname']")]
        public IWebElement InputName { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='lastname']")]
        public IWebElement InputLastName { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='reg_email__']")]
        public IWebElement InputRegEmail { get; set; }

        [FindsBy(How = How.Name, Using = "reg_email_confirmation__")]
        public IWebElement InputRegEmailConfirm { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='reg_passwd__']")]
        public IWebElement InputRegPass { get; set; }

        [FindsBy(How = How.CssSelector, Using = "select#day")]
        public IWebElement DdlBirthdayDay { get; set; }

        [FindsBy(How = How.CssSelector, Using = "select#day option")]
        public IList<IWebElement> DdlOptionsBirthdayDay { get; set; }

        [FindsBy(How = How.CssSelector, Using = "select#month")]
        public IWebElement DdlBirthdayMonth { get; set; }

        [FindsBy(How = How.CssSelector, Using = "select#month option")]
        public IList<IWebElement> DdlOptionsBirthdayMonth { get; set; }

        [FindsBy(How = How.CssSelector, Using = "select#year")]
        public IWebElement DdlBirthdayYear { get; set; }

        [FindsBy(How = How.CssSelector, Using = "select#year option")]
        public IList<IWebElement> DdlOptionsBirthdayYear { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[name='sex'][value='1']")]
        public IWebElement RadioButtonGenderFemale { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[name='sex'][value='2']")]
        public IWebElement RadioButtonGenderMale { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[name='sex'][value='-1']")]
        public IWebElement RadioButtonGenderCustom { get; set; }

        [FindsBy(How = How.CssSelector, Using = "select[name='preferred_pronoun'] option:not([selected])")]
        public IList<IWebElement> DdlOptionsPronoun { get; set; }
    }
}
