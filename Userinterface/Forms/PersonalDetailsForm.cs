using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace UserinterfaceTests.Forms

{
    public class PersonalDetailsForm : Form
    {
        public PersonalDetailsForm() : base(By.XPath("//*[contains(@class,'page-indicator') and contains(text(),'3')]"), "Personal Details Form")
        { }
    }
}
