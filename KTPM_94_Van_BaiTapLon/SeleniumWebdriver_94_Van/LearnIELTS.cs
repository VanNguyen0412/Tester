using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace SeleniumWebdriver
{
    [TestClass]
    public class LearnIELTS
    {
        IWebDriver driver_Van = new ChromeDriver();

        [TestMethod]
        public void TC1_Practise()
        {
            // Bước 1: Vào trình duyệt
            driver_Van.Url = "https://tuhocielts.dolenglish.vn/luyen-thi-ielts/free-ielts-online-test";
            driver_Van.Navigate();

            // Bước 2: Chọn bài test
            Thread.Sleep(3000);
            IWebElement reading = driver_Van.FindElement(By.XPath("//*[@id=\"layout-landing-content\"]/article/div[3]/div/div[3]/article[1]/div/section/div[3]/div[2]/div/div/a"));
            reading.Click();
            // Bước 3: Chọn làm bài
            Thread.Sleep(3000);
            IWebElement lambai = driver_Van.FindElement(By.XPath("//*[@id=\"layout-landing-content\"]/article/div[4]/div/div[2]/div[1]/div/div[2]/div/div[2]/div[1]/div[2]/div[2]/div/a"));
            lambai.Click();

            // Bước 4: Đóng trình duyệt
            Thread.Sleep(3000);
            driver_Van.Quit();
        }

        [TestMethod]
        public void TC2_Vocabulary()
        {
            // Bước 1: Vào trình duyệt
            driver_Van.Url = "https://tuhocielts.dolenglish.vn/luyen-thi-ielts/free-ielts-online-test";
            driver_Van.Navigate();

            // Bước 2: Chọn bài test
            Thread.Sleep(3000);
            IWebElement reading = driver_Van.FindElement(By.XPath("//*[@id=\"layout-landing-content\"]/article/div[3]/div/div[3]/article[1]/div/section/div[3]/div[2]/div/div/a"));
            reading.Click();

            // Bước 3: Chọn nút lựa chọn
            Thread.Sleep(3000);
            IWebElement choose = driver_Van.FindElement(
                By.XPath("//*[@id=\"layout-landing-content\"]/article/div[4]/div/div[2]/div[1]/div/div[2]/div/div[2]/div[1]/div[2]/div[2]/div/div"));
            choose.Click();

            Thread.Sleep(3000);
            // Bước 4: Chọn Từ vựng
            IWebElement vocab = driver_Van.FindElement(
                By.LinkText("Từ vựng"));
            vocab.Click();

            // Bước 5: Đóng trình duyệt
            Thread.Sleep(3000);
            driver_Van.Quit();
        }


        [TestMethod]
        public void TC3_Scripts()
        {
            // Bước 1: Vào trình duyệt
            driver_Van.Url = "https://tuhocielts.dolenglish.vn/luyen-thi-ielts/free-ielts-online-test";
            driver_Van.Navigate();

            // Bước 2: Chọn bài test
            Thread.Sleep(3000);
            IWebElement reading = driver_Van.FindElement(By.XPath("//*[@id=\"layout-landing-content\"]/article/div[3]/div/div[3]/article[1]/div/section/div[3]/div[2]/div/div/a"));
            reading.Click();

            // Bước 3: Chọn nút lựa chọn
            Thread.Sleep(3000);
            IWebElement choose = driver_Van.FindElement(
                 By.XPath("//*[@id=\"layout-landing-content\"]/article/div[4]/div/div[2]/div[1]/div/div[2]/div/div[2]/div[1]/div[2]/div[2]/div/div"));
            choose.Click();

            // Bước 4: Chọn Đề và đáp án
            IWebElement scripts = driver_Van.FindElement(
                By.LinkText("Đề và đáp án"));
            scripts.Click();

            Thread.Sleep(3000);
            // Bước 5: Đóng trình duyệt
            Thread.Sleep(3000);
            driver_Van.Quit();
        }
    }
}
