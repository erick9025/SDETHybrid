﻿using CoreFramework.Logger;
using CoreFramework.Utilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestCasesNUnit.TestCases
{
    internal class UnitTests
    {
        [Test, Category("Unit Test")]
        public void TestOrdinal()
        {
            for(int i=1;i<=150;i++ )
            {                
                Log.Info(TestUtilities.ToOrdinal(i));
            }
        }

        [Test, Category("Unit Test")]
        public void TestOrdinalWithExtensions()
        {
            for (int i = 1; i <= 25; i++)
            {
                Log.Info(i.ToOrdinal());
            }
        }
    }
}
