using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
namespace StaticClass
{
    public class Selenium
    {
        public static IWebDriver driver;
        void Stop(int milisaniye = 1000)
        {
            System.Threading.Thread.Sleep(milisaniye);
        }
        void tryCatchBlock(Action action)
        {
            try
            {
                driver = new ChromeDriver();
                action.Invoke();
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
        public IWebDriver Halkbank(string kullaniciadi, string parola)
        {
            tryCatchBlock(() =>
            {
                driver.Url = "https://sube.halkbank.com.tr/InternetBankingHost/HostLogin?CustomerType=Retail";
                driver.FindElement(By.Id("PinLoginCustomerID")).SendKeys(kullaniciadi);
                driver.FindElement(By.Name("FirstLoginPassword")).SendKeys(parola); Stop();
                driver.FindElement(By.Id("submitbtn")).Click();
                driver.Manage().Window.Maximize();
            });
            return driver;
        }
        public IWebDriver Hotmail(string kullaniciadi, string parola)
        {
            tryCatchBlock(() =>
            {
                driver.Url = "https://login.live.com/login.srf?wa=wsignin1.0&rpsnv=13&ct=1552566544&rver=7.0.6737.0&wp=MBI_SSL&wreply=https%3a%2f%2foutlook.live.com%2fowa%2f%3fRpsCsrfState%3d09d66903-0170-93ce-ec8e-d44e1bbb248c&id=292841&aadredir=1&whr=hotmail.com&CBCXT=out&lw=1&fl=dob%2cflname%2cwld&cobrandid=90015";
                driver.FindElement(By.Name("loginfmt")).SendKeys(kullaniciadi); Stop();
                driver.FindElement(By.Id("idSIButton9")).Click();
                driver.FindElement(By.Name("passwd")).SendKeys(parola); Stop();
                driver.FindElement(By.Id("idSIButton9")).Click();
                driver.Manage().Window.Maximize();
            });
            return driver;
        }
        public IWebDriver Kuveyt(string kullaniciadi, string parola)
        {
            tryCatchBlock(() =>
            {
                driver.Url = "https://isube.kuveytturk.com.tr/Login/InitialLogin";
                IWebElement BtnOK = driver.FindElement(By.Name("BtnOK"));
                BtnOK.Click();
                IWebElement IntUserName = driver.FindElement(By.Id("IntUserName"));
                IntUserName.SendKeys(kullaniciadi);
                IWebElement Password = driver.FindElement(By.Id("Password"));
                Password.SendKeys(parola);
                IWebElement btnSubmit = driver.FindElement(By.Id("btnSubmit"));
                btnSubmit.Click();
                IWebElement LoginButton = driver.FindElement(By.Id("LoginButton"));
                LoginButton.Click();
                driver.Manage().Window.Maximize();
            });
            return driver;
        }
        public IWebDriver Gmail(string kullaniciadi, string parola)
        {
            tryCatchBlock(() =>
            {
                string GirisSayfasiAdres = "https://accounts.google.com/signin/v2/identifier?continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&service=mail&sacu=1&rip=1&flowName=GlifWebSignIn&flowEntry=ServiceLogin";
                driver.Url = GirisSayfasiAdres;
                IWebElement UserName = driver.FindElement(By.Name("identifier"));
                UserName.SendKeys(kullaniciadi);
                IWebElement BtnIdentifier = driver.FindElement(By.Id("identifierNext"));
                BtnIdentifier.Click(); Stop();
                IWebElement Password = driver.FindElement(By.Name("password"));
                Password.SendKeys(parola);
                IWebElement BtnPassword = driver.FindElement(By.Id("passwordNext"));
                BtnPassword.Click();
                driver.Manage().Window.Maximize();
            });
            return driver;
        }
        public IWebDriver Belgenet(string kullaniciadi, string parola)
        {
            tryCatchBlock(() =>
            {
                driver.Url = "https://e-belge.tarim.gov.tr/edys-web/sistemeGiris.xhtml";
                IWebElement UserName = driver.FindElement(By.Id("uForm:txtUKullaniciAdi"));
                IWebElement LoginPassword = driver.FindElement(By.Id("loginUSifre"));
                IWebElement LoginButton = driver.FindElement(By.Id("uForm:girisYapButton"));
                UserName.SendKeys(kullaniciadi);
                LoginPassword.SendKeys(parola);
                LoginButton.Click();
                driver.Manage().Window.Maximize();
            });
            return driver;
        }
        public IWebDriver GarantiBank(string kullaniciadi, string parola)
        {
            tryCatchBlock(() =>
            {
                driver.Navigate().GoToUrl("https://sube.garanti.com.tr/isube/login/login/passwordentrypersonal-tr");
                IWebElement UserName = driver.FindElement(By.Id("custno"));
                UserName.SendKeys(kullaniciadi);
                IWebElement Password = driver.FindElement(By.Id("password"));
                Password.SendKeys(parola);
                IWebElement SubmitButton = driver.FindElement(By.Id("formSubmit"));
                SubmitButton.Click();
                driver.Manage().Window.Maximize();
            });
            return driver;
        }
        public IWebDriver ZiraatBankasi(string kullaniciadi, string parola)
        {
            tryCatchBlock(() =>
            {
                driver.Navigate().GoToUrl("https://bireysel.ziraatbank.com.tr/Transactions/Login/FirstLogin.aspx?customertype=rtl");
                IWebElement UserName = driver.FindElement(By.Name("ctl00$c$RetailIdentityTextBox"));
                UserName.SendKeys(kullaniciadi);
                IWebElement Password = driver.FindElement(By.Name("ctl00$c$RetailPinTextBox"));
                Password.SendKeys(parola);
                Stop();
                IWebElement SubmitButton = driver.FindElement(By.Id("ctl00_c_RetailLoginButton"));
                SubmitButton.Click();
                Stop();
                driver.Manage().Window.Maximize();
            });
            return driver;
        }
        public IWebDriver EtimesgutBelediyesi(string kullaniciadi, string parola_)
        {
            tryCatchBlock(() =>
            {
                driver.Url = "https://webserver.etimesgut.bel.tr/web/guest/2";
                driver.Manage().Window.Maximize();
                Stop();
                driver.FindElement(By.Name("_58_login")).Click();
                driver.FindElement(By.Name("_58_login")).SendKeys(kullaniciadi);
                Stop();
                driver.FindElement(By.Name("_58_password")).Click();
                driver.FindElement(By.Name("_58_password")).SendKeys(parola_);
                Stop();
                driver.FindElement(By.XPath("//img[@src='/higherground-theme/images/loginx/logbut.png']")).Click();
            });
            return driver;
        }
        public IWebDriver E_Nabiz(string kullaniciAdi, string parola)
        {
            tryCatchBlock(() =>
            {
                driver.Url = "https://enabiz.gov.tr/";
                driver.Manage().Window.Maximize();
                Stop();
                driver.FindElement(By.Id("username")).SendKeys(kullaniciAdi);
                driver.FindElement(By.Id("Sifre")).SendKeys(parola);
                Stop();
                driver.FindElement(By.Id("btnGiris")).Click();
            });
            return driver;
        }
        public IWebDriver E_Devlet(string kullaniciAdi, string parola)
        {
            tryCatchBlock(() =>
            {
                driver.Url = "https://giris.turkiye.gov.tr/Giris/gir";
                driver.Manage().Window.Maximize();
                Stop();
                driver.FindElement(By.Id("tridField")).SendKeys(kullaniciAdi);
                driver.FindElement(By.Id("egpField")).SendKeys(parola);
                Stop();
                driver.FindElement(By.Name("submitButton")).Click();
            });
            return driver;
        }
        public IWebDriver KitapYurdu(string kullaniciAdi, string parola)
        {
            tryCatchBlock(() =>
            {
                driver.Url = "https://www.kitapyurdu.com/index.php?route=account/login";
                driver.Manage().Window.Maximize();
                driver.FindElement(By.Name("email")).SendKeys(kullaniciAdi);
                driver.FindElement(By.Name("password")).SendKeys(parola);
                Stop();
                List<IWebElement> buttons = driver.FindElements(By.ClassName("button")).ToList();
                foreach (var item in buttons)
                {
                    if (item.Text == "Oturum Aç")
                    {
                        item.Click();
                    }
                }
            });
            return driver;
        }
        public IWebDriver BebeklikComTr(string kullaniciAdi, string parola)
        {
            tryCatchBlock(() =>
            {
                driver.Url = "https://www.bebeklik.com.tr/uye-girisi";
                driver.Manage().Window.Maximize();
                driver.FindElement(By.Id("email")).SendKeys(kullaniciAdi);
                driver.FindElement(By.Id("pass")).SendKeys(parola);
                driver.FindElement(By.XPath("//*[@id=\"loginform\"]/div[2]/div[3]/div[2]/input")).Click();
            });
            return driver;
        }
        public IWebDriver N11(string kullaniciAdi, string parola)
        {
            tryCatchBlock(() =>
            {
                driver.Url = "https://www.n11.com/giris-yap";
                driver.Manage().Window.Maximize();
                Stop();
                driver.FindElement(By.Id("email")).SendKeys(kullaniciAdi);
                driver.FindElement(By.Id("password")).SendKeys(parola);
                Stop();
                driver.FindElement(By.Id("loginButton")).Click();
            });
            return driver;
        }
        public IWebDriver TbsGiris(string kullaniciAdi, string parola)
        {
            tryCatchBlock(() =>
            {
                driver.Url = "https://www.google.com.tr";
                driver.Url = "https://tbs.tarbil.gov.tr/Authentication.aspx";
                driver.Manage().Window.Maximize();
                Stop(3000);
                driver.FindElement(By.Id("username")).SendKeys(kullaniciAdi);
                driver.FindElement(By.Id("password")).SendKeys(parola);
                Stop();
                driver.FindElement(By.Id("btnSubmit")).Click();
            });
            return driver;
        }
        public IWebDriver PBYS(string kullaniciAdi, string parola)
        {
            tryCatchBlock(() =>
            {
                driver.Url = "https://yetki.tarim.gov.tr/Login.aspx?UygulamaUN=0e1061a3-fed6-466f-bd69-0a2ca3857713";
                driver.Manage().Window.Maximize();
                Stop(3000);
                driver.FindElement(By.Name("txtKullaniciAdi")).SendKeys(kullaniciAdi);
                driver.FindElement(By.Name("txtSifre")).SendKeys(parola);
                Stop();
                driver.FindElement(By.Id("btnGiris")).Click();
            });
            return driver;
        }
        public IWebDriver facebook(string kullaniciAdi, string parola)
        {
            tryCatchBlock(() =>
            {
                string facebookUrl = "https://www.facebook.com/login/";
                driver.Url = facebookUrl;
                driver.Manage().Window.Maximize();
                Stop(2000);
                driver.FindElement(By.Id("email")).SendKeys(kullaniciAdi);
                driver.FindElement(By.Id("pass")).SendKeys(parola);
                Stop();
                driver.FindElement(By.Id("loginbutton")).Click();
            });
            return driver;
        }
        public IWebDriver Github(string kullaniciAdi, string parola)
        {
            tryCatchBlock(() =>
            {
                string GithubUrl = "https://github.com/login";
                driver.Url = GithubUrl;
                driver.Manage().Window.Maximize();
                Stop(2000);
                driver.FindElement(By.Id("login_field")).SendKeys(kullaniciAdi);
                driver.FindElement(By.Id("password")).SendKeys(parola);
                Stop();
                driver.FindElement(By.Name("commit")).Click();
            });
            return driver;
        }
        public IWebDriver GittiGidiyor(string kullaniciAdi, string parola)
        {
            tryCatchBlock(() =>
            {
                string GittiGidiyorUrl = "https://www.gittigidiyor.com/uye-girisi";
                driver.Url = GittiGidiyorUrl;
                driver.Manage().Window.Maximize();
                Stop(2000);
                driver.FindElement(By.Id("L-UserNameField")).SendKeys(kullaniciAdi);
                driver.FindElement(By.Id("L-PasswordField")).SendKeys(parola);
                Stop();
                driver.FindElement(By.Id("gg-login-enter")).Click();
            });
            return driver;
        }
        public IWebDriver GeneralMobile(string kullaniciAdi, string parola)
        {
            tryCatchBlock(() =>
            {
                string GeneralMobileUrl = "https://www.generalmobile.com/tr/giris-yap";
                driver.Url = GeneralMobileUrl;
                driver.Manage().Window.Maximize();
                Stop(2000);
                driver.FindElement(By.Id("Login_Email")).SendKeys(kullaniciAdi);
                driver.FindElement(By.Id("Login_PassWord")).SendKeys(parola);
                Stop();
                driver.FindElement(By.Id("LoginBtn")).Click();
            });
            return driver;
        }
        public IWebDriver HappyComTr(string kullaniciAdi, string parola)
        {
            tryCatchBlock(() =>
            {
                string HappyComTrUrl = "https://www.happy.com.tr/index.php?route=account/login";
                driver.Url = HappyComTrUrl;
                driver.Manage().Window.Maximize();
                Stop(2000);
                driver.FindElement(By.Name("email")).SendKeys(kullaniciAdi);
                Stop();
                driver.FindElement(By.Name("password")).SendKeys(parola);
                Stop();
                driver.FindElement(By.XPath("//*[@id=\"login\"]/div/a")).Click();
            });
            return driver;
        }
        public IWebDriver Heibis(string kullaniciAdi, string parola)
        {
            tryCatchBlock(() =>
            {
                string HeibisUrl = "http://egitim.tarbil.gov.tr/tarbil/lms/index2.aspx?lang=0&err=-1";
                driver.Url = HeibisUrl;
                driver.Manage().Window.Maximize();
                Stop();
                driver.FindElement(By.Id("ctl00_cphMain_encLogin_userCode")).SendKeys(kullaniciAdi);
                Stop();
                driver.FindElement(By.Id("ctl00_cphMain_encLogin_userPsw")).SendKeys(parola);
                Stop();
                driver.FindElement(By.Id("ctl00_cphMain_encLogin_BtnSubmit")).Click();
            });
            return driver;
        }
        public IWebDriver Dropbox(string kullaniciAdi, string parola)
        {
            tryCatchBlock(() =>
            {
                string DropboxUrl = "https://www.dropbox.com/";
                driver.Url = DropboxUrl;
                driver.Manage().Window.Maximize();
                Stop(2000);
                driver.FindElement(By.Id("sign-up-in")).Click();
                Stop();
                driver.FindElement(By.Name("login_email")).SendKeys(kullaniciAdi);
                Stop();
                driver.FindElement(By.Name("login_password")).SendKeys(parola);
                Stop();
                driver.FindElement(By.ClassName("signin-text")).Click();
            });
            return driver;
        }
        public IWebDriver HepsiBurada(string kullaniciAdi, string parola)
        {
            tryCatchBlock(() =>
            {
                string HepsiBuradaUrl = "https://www.hepsiburada.com/uyelik/giris?ReturnUrl=%2f";
                driver.Url = HepsiBuradaUrl;
                driver.Manage().Window.Maximize();
                Stop(2000);
                driver.FindElement(By.Id("email")).SendKeys(kullaniciAdi);
                driver.FindElement(By.Id("password")).SendKeys(parola);
                Stop();
                driver.FindElement(By.CssSelector("#form-login>div.form-actions>button")).Click();
            });
            return driver;
        }
        public IWebDriver Trendyol(string kullaniciAdi, string parola)
        {
            tryCatchBlock(() =>
            {
                string TrendyolUrl = "https://www.trendyol.com/";
                driver.Url = TrendyolUrl;
                driver.Manage().Window.Maximize();
                Stop(2000);
                driver.FindElement(By.ClassName("login-container")).Click();
                Stop();
                driver.FindElement(By.Id("email")).Click();
                driver.FindElement(By.Id("email")).SendKeys(kullaniciAdi);
                driver.FindElement(By.Id("password")).Click();
                driver.FindElement(By.Id("password")).SendKeys(parola);
                Stop();
                driver.FindElement(By.ClassName("submit-button-container")).Click();
            });
            return driver;
        }
        public IWebDriver itopya(string kullaniciadi, string parola_)
        {
            tryCatchBlock(() =>
            {
                driver.Url = "https://www.itopya.com/giris-yap/";
                driver.Manage().Window.Maximize();
                Stop();
                driver.FindElement(By.Id("email")).SendKeys(kullaniciadi);
                driver.FindElement(By.Id("password")).SendKeys(parola_);
                Stop();
                driver.FindElement(By.XPath("//*[@id=\"mainPage\"]/main/div[2]/form/div/div[5]/input")).Click();
            });
            return driver;
        }
        public IWebDriver netflix(string kullaniciadi, string parola_)
        {
            tryCatchBlock(() =>
            {
                driver.Url = "https://www.netflix.com/tr/login";
                driver.Manage().Window.Maximize();
                Stop();
                driver.FindElement(By.Id("id_userLoginId")).SendKeys(kullaniciadi);
                driver.FindElement(By.Id("id_password")).SendKeys(parola_);
                Stop();
                driver.FindElement(By.XPath("//*[@id=\"appMountPoint\"]/div/div[3]/div/div/div[1]/form/button")).Click();
            });
            return driver;
        }
    }
}
