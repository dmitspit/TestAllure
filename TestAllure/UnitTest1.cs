using NUnit.Allure.Core;
using NUnit.Framework;
using System.Threading;

namespace TestAllure
{
    [TestFixture]
    [AllureNUnit]
    [Category("API validation Test")]
    //[Parallelizable(ParallelScope.All)]
    public class Tests : Base
    {
        [Test]
        [Category("C7552714")]
        [Category("Regrsion")]
        [Description("Verify Fee and Tax Transmission and transformation to PMP If FeeSettings = 1 and Affiliate Tax is not specified")]
        [Author("Dmytro")]
        public void _01_Test()
        {
            Driver.Navigate().GoToUrl("https://www.google.com");
            Thread.Sleep(2000);
            Assert.True(Driver.Title.Contains("Google"));
        }

        [Test]
        [Category("C7557744")]
        [Category("Regrsion")]
        [Description("Verify Fee and Tax Transmission and transformation to PMP If FeeSettings = 1 and Affiliate Tax is not specified")]
        [Author("Dmytro")]
        public void _02_Test()
        {
            Driver.Navigate().GoToUrl("https://www.google.com");
            Thread.Sleep(2000);
            Assert.True(Driver.Title.Contains("Google"));
        }

        [Test]
        [Category("C7552714"), Category("C7558432"), Category("C7557743"), Category("C7557744")]
        [Category("Regrsion")]
        [Description("Verify Fee and Tax Transmission and transformation to PMP If FeeSettings = 1 and Affiliate Tax is not specified")]
        [Author("Dmytro")]
        public void _03_Test_name()
        {
            Driver.Navigate().GoToUrl("https://www.google.com");
            Thread.Sleep(3000);
            Assert.AreEqual("AXqw", Driver.Title, "Title is not as expected");
        }
    }
}