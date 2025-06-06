using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace SeleniumWebdriver
{
    [TestClass]
    public class SearchToeicCourse
    {
        IWebDriver driver_Van = new ChromeDriver();

        [TestMethod]
        public void TC1_Search()
        {
            //Bước 1: Vào trình duyệt
            driver_Van.Url = "https://tuhocielts.dolenglish.vn/nghe-chep-chinh-ta-tieng-anh";
            driver_Van.Navigate();

            // Bước 2: Nhập khóa học vào ô tìm kiếm
            IWebElement search = driver_Van.FindElement(
                By.CssSelector("input[placeholder=\"Search\"]"));
            search.SendKeys("toeic");
            Thread.Sleep(1000);

            // Bước 3: Nhấn tìm kiếm
            IWebElement submit = driver_Van.FindElement(
                By.XPath("//*[@id=\"dictation-listing\"]/div[3]/div[1]/div/div/div[1]/div/form/div/div[3]/button"));
            submit.Click();
            Thread.Sleep(1000);

            // Bước 4: Chọn khóa học
            IWebElement toeic = driver_Van.FindElement(
                By.XPath("//*[@id=\"dictation-listing\"]/div[3]/div[2]/div[2]/div[1]/div[1]/div/div/div[2]/div[2]/div/div/a"));
            toeic.Click();
            Thread.Sleep(2000);

            // Bước 8: Thoát trình duyệt
            driver_Van.Quit();
        }


        [TestMethod]
        public void TC2_ErrorSearch()
        {
            //Bước 1: Vào trình duyệt
            driver_Van.Url = "https://tuhocielts.dolenglish.vn/nghe-chep-chinh-ta-tieng-anh";
            driver_Van.Navigate();

            // Bước 2: Nhập khóa học vào ô tìm kiếm
            IWebElement search = driver_Van.FindElement(
                By.CssSelector("input[placeholder=\"Search\"]"));
            search.SendKeys("toiec");
            Thread.Sleep(1000);

            // Bước 3: Nhấn tìm kiếm
            IWebElement submit = driver_Van.FindElement(
                By.XPath("//*[@id=\"dictation-listing\"]/div[3]/div[1]/div/div/div[1]/div/form/div/div[3]/button"));
            submit.Click();
            Thread.Sleep(1000);

            // Bước 4: Lỗi tìm kiếm khi nhập sai khóa học
            IWebElement error = driver_Van.FindElement(
                By.XPath("//*[@id=\"dictation-listing\"]/div[3]/div[2]/div[1]"));
            if (error.Displayed)
            {
                Console.WriteLine("Không tìm kiếm ra khóa học");
                Console.WriteLine(error.Text);
            }
            else
            {
                Console.WriteLine("Tìm kiếm khóa học thành công");
            }

            Thread.Sleep(2000);

            // Bước : Thoát trình duyệt
            driver_Van.Quit();
        }
    }
}
