using Entity.Concrete;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Selenium
{
    public static class TbsIslemleri
    {
        private static IWebDriver driver { get; set; }
        static IWebElement dropDownMenu;
        static IWebElement input1;
        static IWebElement input2;
        static IWebElement button;
        static IWebElement button2;
        static IWebElement text;
        public static void TbsGiris(string kullaniciAdi, string parola)
        {
                driver.Navigate().Refresh();
                driver.Url = "https://tbs.tarbil.gov.tr/Authentication.aspx";
                driver.FindElement(By.Id("username")).SendKeys(kullaniciAdi);
                driver.FindElement(By.Id("password")).SendKeys(parola);
                driver.FindElement(By.Id("btnSubmit")).Click();
        }
        public static List<Dilekce> DilekceBilgileriGetir()
        {
            try
            {
                string dilekceNumarasi;
                List<Dilekce> dilekceler = new List<Dilekce>();
                List<IWebElement> tablergRow = driver.FindElements(By.ClassName("rgRow")).ToList();
                List<IWebElement> tablergAltRow = driver.FindElements(By.ClassName("rgAltRow")).ToList();
                foreach (var item in tablergRow)
                {
                    Dilekce dilekce = new Dilekce();
                    List<IWebElement> tr = item.FindElements(By.TagName("td")).ToList();
                    dilekceNumarasi = tr[1].Text;
                    if (dilekceNumarasi != "")
                    {
                        dilekce.DilekceNumarasi = tr[1].Text;
                        dilekce.DilekceTarihi = tr[2].Text;
                        dilekce.UretimYili = tr[3].Text;
                        dilekce.DilekceKabulTarihi = tr[4].Text;
                        dilekce.IlAdi = tr[5].Text;
                        dilekce.IlceAdi = tr[6].Text;
                        dilekce.Durum = tr[7].Text;
                        dilekceler.Add(dilekce);
                    }
                }
                foreach (var item in tablergAltRow)
                {
                    Dilekce dilekce = new Dilekce();
                    List<IWebElement> tr = item.FindElements(By.TagName("td")).ToList();
                    dilekceNumarasi = tr[1].Text;
                    if (dilekceNumarasi != "")
                    {
                        dilekce.DilekceNumarasi = tr[1].Text;
                        dilekce.DilekceTarihi = tr[2].Text;
                        dilekce.UretimYili = tr[3].Text;
                        dilekce.DilekceKabulTarihi = tr[4].Text;
                        dilekce.IlAdi = tr[5].Text;
                        dilekce.IlceAdi = tr[6].Text;
                        dilekce.Durum = tr[7].Text;
                        dilekceler.Add(dilekce);
                    }
                }
                return dilekceler;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static void ButonTıkla(string hangiMenu)
        {
            int whichMenu = 12;
            string[] menuName = new string[whichMenu];
            for (int i = 1; i < whichMenu; i++)
            {
                try
                {
                    button = driver.FindElement(By.CssSelector("#ctl00_ctl00_bodyCPH_ContentPlaceHolder1_RadTabStrip1>div>ul>li:nth-child(" + i + ")>a>span>span>span"));
                    if (button.Displayed)
                    {
                        //Console.Write("element is found  ");
                        //Console.WriteLine(button.Text);
                        menuName[i] = button.Text;
                        if (menuName[i] == hangiMenu)
                            button.Click();
                    }
                }
                catch (Exception)
                {
                    //Console.WriteLine("element is NOT found");
                }
            }
        }
        public static void ChromeAc()
        {
            if (driver == null)
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
            }
        }
        public static void ChromeKapat()
        {
            if (driver != null)
            {
                driver.Quit();
            }
        }
        public static void GerçekKişiKayitIslemleri(string TcNumarasi)
        {
         
                driver.Url = "http://tbsapp1.tarim.gov.tr/Modules/ACM/CKSList.aspx?CorporationType=1#person";
                driver.FindElement(By.Id("ctl00_ctl00_bodyCPH_ContentPlaceHolder1_HoldingSearchControlUC_RadPanelBar1_i0_edtIdNo11")).Click();
                driver.FindElement(By.Id("ctl00_ctl00_bodyCPH_ContentPlaceHolder1_HoldingSearchControlUC_RadPanelBar1_i0_edtIdNo11")).SendKeys(TcNumarasi);
                driver.FindElement(By.Id("ctl00_ctl00_bodyCPH_ContentPlaceHolder1_HoldingSearchControlUC_RadPanelBar1_i0_btnSearch11")).Click(); Bekle();
                driver.FindElement(By.Id("ctl00_ctl00_bodyCPH_ContentPlaceHolder1_grdList_ctl00_ctl04_EditButton")).Click(); Bekle(3000);
           
        }
      
        static void Bekle(int Süre = 2000)
        {
            System.Threading.Thread.Sleep(Süre);
        }
        
    }
}
