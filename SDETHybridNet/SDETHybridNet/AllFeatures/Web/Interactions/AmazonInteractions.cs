using CoreFramework.AllFeatures.Web.ParentClasses;
using CoreFramework.Driver;
using CoreFramework.Logger;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreFramework.AllFeatures.Web.Interactions
{
    public class AmazonInteractions : Features
    {
        public AmazonInteractions(Browser browser) : base (browser)
        {

        }

        public AmazonInteractions GoTo()
        {
            Browser.GoToURL(AmazonAbilities.AmazonURL);

            string textDisplayed = AmazonElements.HelloUser.Text;

            Log.AssertIsTrue(textDisplayed.Contains("Hola") || textDisplayed.Contains("Hello"), "Welcome text should say Hello/Hola. Displayed text: " + textDisplayed);
            return this;
        }

        public AmazonInteractions SearchProduct(string productWanted)
        {
            GoTo();

            StandardMethods
                .EnterText(AmazonElements.SearchBarInput, "Search [Input]", productWanted)
                .Click(AmazonElements.SearchButton, "Search [Button]");

            Log.Info("Amazon search executed successfully!");
            return this;
        }

        public AmazonInteractions SelectResultByOrdinal(int ordinal)
        {
            StandardMethods
                .Wait(4)
                .Click(AmazonElements.ResultScreenList[ordinal - 1], $"Search Result [Image {ordinal}]");
            return this;
        }
    }
}
