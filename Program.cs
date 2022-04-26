using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ElementsToolsQA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            IJavaScriptExecutor Js = (IJavaScriptExecutor)driver;
            
            driver.Manage().Window.Maximize();

            

             driver.Navigate().GoToUrl("https://demoqa.com/text-box");
             driver.FindElement(By.Id("userName")).SendKeys("Md Afridi");
             Thread.Sleep(2000);
             driver.FindElement(By.Id("userEmail")).SendKeys("hellboy@gmail.com");
             Thread.Sleep(2000);

             driver.FindElement(By.Id("currentAddress")).SendKeys("kolkata");
             Thread.Sleep(2000);
             driver.FindElement(By.Id("permanentAddress")).SendKeys("bihar se hai");
             Thread.Sleep(2000);

             IWebElement submit =driver.FindElement(By.XPath("//button[@id='submit']"));
             submit.Click();

             Thread.Sleep(2000);

             //This is for check box

             driver.Navigate().GoToUrl("https://demoqa.com/checkbox");
             Thread.Sleep(1000);

             driver.FindElement(By.XPath("//ol//li//span//button[@type='button']")).Click();
             Thread.Sleep(2000);
             driver.FindElement(By.XPath("//span[text()='Desktop']")).Click();
             Thread.Sleep(500);
             driver.FindElement(By.XPath("//span[text()='Documents']")).Click();
             Thread.Sleep(500);

             driver.FindElement(By.XPath("//span[text()='Home']")).Click();
             Thread.Sleep(1000);
             driver.FindElement(By.XPath("//ol//li//span//button[@type='button']")).Click();
             Thread.Sleep(2000);

             //This is for radio button

             driver.Navigate().GoToUrl("https://demoqa.com/radio-button");
             Thread.Sleep(1000);
             IWebElement YesBtn = driver.FindElement(By.Id("yesRadio"));
             Js.ExecuteScript("arguments[0].click()",YesBtn);
             Thread.Sleep(2000);

                //This is for Web table

             driver.Navigate().GoToUrl("https://demoqa.com/webtables");
             driver.FindElement(By.Id("addNewRecordButton")).Click();
             Thread.Sleep(2000);
             driver.FindElement(By.Id("firstName")).SendKeys("Md Afridi");
             Thread.Sleep(1000);

             driver.FindElement(By.Id("lastName")).SendKeys("khurshid");
             Thread.Sleep(1000);
             driver.FindElement(By.Id("userEmail")).SendKeys("hellboy@gmail.com");
             Thread.Sleep(1000);
             driver.FindElement(By.Id("age")).SendKeys("21");
             Thread.Sleep(1000);
             driver.FindElement(By.Id("salary")).SendKeys("24000");
             Thread.Sleep(1000);
             driver.FindElement(By.Id("department")).SendKeys("cse");
             IWebElement submit1 = driver.FindElement(By.Id("submit"));
             submit1.Click();
             Thread.Sleep(2000);

             driver.FindElement(By.Id("searchBox")).SendKeys("Alden");
             Thread.Sleep(2000);


             //  buttons
             //This is for double click
            
             driver.Navigate().GoToUrl("https://demoqa.com/buttons");
             Thread.Sleep(2000);
             IWebElement doubleclickLink = driver.FindElement(By.Id("doubleClickBtn"));
             Actions actions = new Actions(driver);
             actions.DoubleClick(doubleclickLink).Build().Perform();
             Thread.Sleep(1000);
            
             //This is for right click
             IWebElement rightclick = driver.FindElement(By.Id("rightClickBtn"));
                 Actions actions1 = new Actions(driver);
             actions1.ContextClick(rightclick).Build().Perform();
             Thread.Sleep(1000);

             //click 
             /*


             driver.FindElement(By.Id("B7K2I")).Click();
             Thread.Sleep(500);
             */

            //This is for links
              
            
                 driver.Navigate().GoToUrl("https://demoqa.com/links");
                 Thread.Sleep(1000);

                 driver.FindElement(By.Id("simpleLink")).Click();
                 Thread.Sleep(3000);
                 driver.SwitchTo().Window(driver.WindowHandles[1]);
                 Js.ExecuteScript("window.scrollBy(0,400)");
                 Thread.Sleep(1000);

                 driver.Close();
                 driver.SwitchTo().Window(driver.WindowHandles[0]);
                 Thread.Sleep(2000);

                 IWebElement dyn = driver.FindElement(By.XPath("//p//a[@id='dynamicLink']"));
                 dyn.Click();
                 Thread.Sleep(2000);
                 driver.SwitchTo().Window(driver.WindowHandles[1]);
                 Thread.Sleep(2000);

                 driver.Close();
                 Thread.Sleep(500);
                 driver.SwitchTo().Window(driver.WindowHandles[0]);
                 Thread.Sleep(500);
            
                /*
                 driver.FindElement(By.XPath("//p//a[text()='Created']")).Click();
                 Thread.Sleep(500);
                 driver.FindElement(By.Id("no-content")).Click();
                 Thread.Sleep(500);
                 driver.FindElement(By.Id("moved")).Click();
                 Thread.Sleep(500);
                 driver.FindElement(By.Id("unauthorized")).Click();
                 Thread.Sleep(500);
                 driver.FindElement(By.Id("forbidden")).Click();
                 Thread.Sleep(500);
                 driver.FindElement(By.Id("invalid-url")).Click();
                 Thread.Sleep(500);
                */
               
            //This is for Broken links

            driver.Navigate().GoToUrl("https://demoqa.com/broken");
            driver.Navigate().GoToUrl("https://demoqa.com/");
            Thread.Sleep(500);
            driver.Navigate().Back();
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/status_codes/500");
            Thread.Sleep(500);
            driver.Navigate().Back();
            Thread.Sleep(500);

            
            //This is for upload
            driver.Navigate().GoToUrl("https://demoqa.com/upload-download");
            Thread.Sleep(500);
            driver.FindElement(By.XPath("//a[@id='downloadButton']")).Click();
            Thread.Sleep(500);
            //  driver.FindElement(By.XPath("//input[@id='uploadFile']")).SendKeys(@"C:\Users\USER\Downloads\sampleFile");



            //This is for window
            driver.Navigate().GoToUrl("https://demoqa.com/browser-windows");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("tabButton")).Click();
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            Thread.Sleep(2000);
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            Thread.Sleep(500);

            driver.FindElement(By.Id("windowButton")).Click();
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            Thread.Sleep(2000);
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            Thread.Sleep(500);

            /*
                        driver.FindElement(By.XPath("//div//button[@id='messageWindowButton']")).Click();
                        driver.SwitchTo().Window(driver.WindowHandles[1]);
                        Thread.Sleep(2000);
                        driver.Close();
                        driver.SwitchTo().Window(driver.WindowHandles[0]);
                        Thread.Sleep(500);
                        */

                       //This is for alert
               
                      driver.Navigate().GoToUrl("https://demoqa.com/alerts");
                      driver.FindElement(By.Id("alertButton")).Click();
                      Thread.Sleep(1000);
                      driver.SwitchTo().Alert().Accept();

                   driver.FindElement(By.XPath("//div//button[@id='timerAlertButton']")).Click();
                    Thread.Sleep(6000);
                    driver.SwitchTo().Alert().Accept();
                    Thread.Sleep(2000);

                      driver.FindElement(By.Id("confirmButton")).Click();
                      Thread.Sleep(1000);
                      driver.SwitchTo().Alert().Accept();

                  driver.FindElement(By.XPath("//button[@id='promtButton']")).Click();
                   Thread.Sleep(1000);
                   driver.SwitchTo().Alert().SendKeys("kevin");
                  Thread.Sleep(2000);
                   driver.SwitchTo().Alert().Accept();

            //This is for frame
            driver.Navigate().GoToUrl("https://demoqa.com/frames");
                      Thread.Sleep(2000);

                //This is for  modal dialouge

                       driver.Navigate().GoToUrl("https://demoqa.com/modal-dialogs");
                      driver.FindElement(By.Id("showSmallModal")).Click();
                      Thread.Sleep(500);
                      driver.FindElement(By.Id("closeSmallModal")).Click();
                      Thread.Sleep(500);

                      driver.FindElement(By.Id("showLargeModal")).Click();
                      Thread.Sleep(500);
                      driver.FindElement(By.Id("closeLargeModal")).Click();
                      Thread.Sleep(1000);


                // This is for Accordian

                 driver.Navigate().GoToUrl("https://demoqa.com/accordian");
                      driver.FindElement(By.Id("section1Heading")).Click();
                      Thread.Sleep(200);
                      driver.FindElement(By.Id("section1Heading")).Click();
                      Js.ExecuteScript("window.scrollBy(0,500)");
                      Thread.Sleep(500);
                      driver.FindElement(By.Id("section2Heading")).Click();
                      Thread.Sleep(1000);
                      driver.FindElement(By.Id("section3Heading")).Click();
                      Thread.Sleep(500);

                   // This is for  auto complete

                      driver.Navigate().GoToUrl("https://demoqa.com/auto-complete");
                      Thread.Sleep(500);
                      IWebElement ab = driver.FindElement(By.CssSelector("[class='auto-complete__value-container auto-complete__value-container--is-multi css-1hwfws3']"));
                      ab.Click();
                     Thread.Sleep(500);
            
          
                // This is for date

                  driver.Navigate().GoToUrl("https://demoqa.com/date-picker");
                      Thread.Sleep(500);
            driver.FindElement(By.Id("datePickerMonthYearInput")).Click();
            Thread.Sleep(500);
            driver.FindElement(By.Id("datePickerMonthYearInput")).Clear();
            driver.FindElement(By.Id("datePickerMonthYearInput")).SendKeys("04/29/2022");


                // This is for slide

            driver.Navigate().GoToUrl("https://demoqa.com/slider");
                      Thread.Sleep(500);
           IWebElement slider= driver.FindElement(By.XPath("//input[@class='range-slider range-slider--primary']"));
            Actions action = new Actions(driver);
            action.DragAndDropToOffset(slider, 200, 0);

               // This is for progress bar
                      driver.Navigate().GoToUrl("https://demoqa.com/progress-bar");
                      Thread.Sleep(500);
                      driver.FindElement(By.Id("startStopButton")).Click();
                      Thread.Sleep(4000);
                      driver.FindElement(By.Id("startStopButton")).Click();


                 // This is for tabs
                      driver.Navigate().GoToUrl("https://demoqa.com/tabs");
                      Thread.Sleep(500);
                      driver.FindElement(By.Id("demo-tab-origin")).Click();
                      Thread.Sleep(2000);
                      driver.FindElement(By.Id("demo-tab-use")).Click();


                  //This is for tool tips
                   driver.Navigate().GoToUrl("https://demoqa.com/tool-tips");
                      Thread.Sleep(500);
                      driver.FindElement(By.Id("toolTipButton")).Click();
                      Thread.Sleep(500);
                      driver.FindElement(By.Id("toolTipTextField")).Click();
                      Thread.Sleep(500);

                   //  This is for menu

                      driver.Navigate().GoToUrl("https://demoqa.com/menu");
                      Thread.Sleep(500);
                      driver.FindElement(By.XPath("//a[text()='Main Item 1']")).Click();
                      Thread.Sleep(500);
                      driver.FindElement(By.XPath("//a[text()='Main Item 2']")).Click();
                      Thread.Sleep(500);
                      driver.FindElement(By.XPath("//a[text()='Main Item 3']")).Click();

                //This is for select menu

                      driver.Navigate().GoToUrl("https://demoqa.com/select-menu");
                      Thread.Sleep(500);
                      driver.FindElement(By.CssSelector("[class='css-19bqh2r']")).Click();
                      driver.FindElement(By.XPath("//div[text()='Group 2, option 1']")).Click();
                      Thread.Sleep(500);
                      driver.FindElement(By.Id("selectOne")).Click();
                      Thread.Sleep(500);
                      driver.FindElement(By.XPath("//div[text()='Mr.']")).Click();
                      Thread.Sleep(500);
            //driver.FindElement(By.Id("oldSelectMenu")).Click();
            //Thread.Sleep(500);
            //   driver.FindElement(By.XPath("//option[text()='Black']")).Submit();

            // driver.FindElement(By.Id("cars")).Click();


            //This is for sortable

            driver.Navigate().GoToUrl("https://demoqa.com/sortable");
                      Thread.Sleep(500);
            Actions aca = new Actions(driver);
                      aca.ClickAndHold(driver.FindElement(By.XPath("//*[@class='vertical-list-container mt-4']//child::div[2]"))).MoveToElement(driver.FindElement(By.XPath("//*[@class='vertical-list-container mt-4']//child::div[5]"))).Release().Build().Perform();
                      Thread.Sleep(500);
                      aca.ClickAndHold(driver.FindElement(By.XPath("//*[@class='vertical-list-container mt-4']//child::div[4]"))).MoveToElement(driver.FindElement(By.XPath("//*[@class='vertical-list-container mt-4']//child::div[1]"))).Release().Build().Perform();
                      Thread.Sleep(500);


            //This is for selectable

            driver.Navigate().GoToUrl("https://demoqa.com/selectable");
            Thread.Sleep(500);
            
            driver.FindElement(By.XPath("//li[text()='Cras justo odio']")).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath("//li[text()='Dapibus ac facilisis in']")).Click();
            Thread.Sleep(500);
            
            driver.FindElement(By.XPath("//li[text()='Cras justo odio']")).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath("//li[text()='Dapibus ac facilisis in']")).Click();
            Thread.Sleep(1000);
            
          /*
            driver.FindElement(By.Id("demo-tab-grid")).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath("//*[text()='One']")).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath("//*[text()='Five']")).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath("//*[text()='Nine']")).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath("//*[text()='Five']")).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath("//*[text()='Seven']")).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath("//*[text()='Three']")).Click();
            Thread.Sleep(1000);
          */
            //This is for resizeable

            driver.Navigate().GoToUrl("https://demoqa.com/resizable");
            Thread.Sleep(500);

            

            //This is for dropable

            driver.Navigate().GoToUrl("https://demoqa.com/droppable");
            Thread.Sleep(500);
            Actions ac = new Actions(driver);
            IWebElement src = driver.FindElement(By.Id("draggable"));
            IWebElement des = driver.FindElement(By.Id("droppable"));

            ac.DragAndDrop(src,des).Perform();

            

            //This is for dragable

            driver.Navigate().GoToUrl("https://demoqa.com/dragabble");
            Thread.Sleep(500);

     

            //This is for login

            driver.Navigate().GoToUrl("https://demoqa.com/login");
            Thread.Sleep(500);
            driver.FindElement(By.Id("userName")).SendKeys("kevin");
            driver.FindElement(By.Id("password")).SendKeys("12345");
            Thread.Sleep(500);
            
            driver.FindElement(By.Id("newUser")).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath("//input[@id='firstname']")).SendKeys("ke");
            Thread.Sleep(500);
            driver.FindElement(By.XPath("//input[@id='lastname']")).SendKeys("Vin");
            driver.FindElement(By.XPath("//input[@id='userName']")).SendKeys("kevin");
            Thread.Sleep(500);
            driver.FindElement(By.XPath("//input[@id='password']")).SendKeys("kevin123");
            Thread.Sleep(500);
            driver.FindElement(By.XPath("//div[@class='recaptcha-checkbox-border']")).Click();

            driver.FindElement(By.XPath("//button[@id='register']")).Click();

            
            //This is for book store 

            driver.Navigate().GoToUrl("https://demoqa.com/books");
            Thread.Sleep(500);
            driver.FindElement(By.XPath("//div[text()='Title']")).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath("//div[text()='Author']")).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath("//div[text()='Publisher']")).Click();
            Js.ExecuteScript("window.ScrollBy(0,300)");
            driver.FindElement(By.XPath("//a[text()='Git Pocket Guide']")).Click();
            //This is for profile 

            driver.Navigate().GoToUrl("https://demoqa.com/profile");
            Thread.Sleep(500);

        }
    }
}
