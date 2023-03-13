using CoreFramework.AllFeatures.Api.ParentClasses;
using CoreFramework.AllFeatures.Web.ParentClasses;
using CoreFramework.Driver;
using CoreFramework.Logger;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestCasesNUnit.TestCases.ParentClasses;

namespace TestCases.TestCases.ParentClasses
{
    public abstract class ApiTest : BaseTest
    {
        protected ServiceObjects Services { get; set; }

        protected override void InitializeFramework()
        {
            InitializeLog();
        }

        #region test annotations
        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            Log.Info("This gets executed one time per run BEFORE");

            InitializeFramework();
            InitializeServices();
        }

        [SetUp]
        public void Setup()
        {
            Log.Info("This gets executed BEFORE EVERY test");
        }

        [TearDown]
        public void TearDown()
        {
            Log.Info("This gets executed AFTER EVERY test");
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Log.Info("This gets executed one time per run AFTER");

            CloseLog();
        }
        #endregion test annotations

        public void InitializeServices()
        {
            Services = new ServiceObjects();
        }
    }
}
