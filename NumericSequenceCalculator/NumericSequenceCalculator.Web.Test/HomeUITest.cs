using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace NumericSequenceCalculator.Web.Test
{
    /// <summary>
    /// Summary description for HomeUITest
    /// </summary>
    [CodedUITest]
    public class HomeUITest
    {
        public HomeUITest()
        {
        }

        [TestMethod]
        public void Home_GetAllNumberSequence()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            BrowserWindow.Launch("http://localhost:49393/");
            this.UIMap.GetAllNumberSequence();
            this.UIMap.GetAllNumberSequenceAssert();


        }

        [TestMethod]
        public void Home_GetOddNumberSequence()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            BrowserWindow.Launch("http://localhost:49393/");
            this.UIMap.GetOddNumberSequence();
            this.UIMap.GetOddNumberSequenceAssert();
        }

        [TestMethod]
        public void Home_GetEvenNumberSequence()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            BrowserWindow.Launch("http://localhost:49393/");
            this.UIMap.GetEvenNumberSequence();
            this.UIMap.GetEvenNumberSequenceAssert();

        }

        [TestMethod]
        public void Home_GetAllNumberOfMultipleSequence()
        {

            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            BrowserWindow.Launch("http://localhost:49393/");
            this.UIMap.GetAllNumberOfMultipleSequence();
            this.UIMap.GetAllNumberOfMultipleSequenceAssert();
            
        }

        [TestMethod]
        public void Home_GetFibonacciSequence()
        {

            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            BrowserWindow.Launch("http://localhost:49393/");
            this.UIMap.GetFibonacciSequence();
            this.UIMap.GetFibonacciSequenceAssert();


        }


        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if ((this.map == null))
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
