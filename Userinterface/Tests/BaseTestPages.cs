using UserinterfaceTests.Pages;

namespace UserinterfaceTests.Tests
{
    public class BaseTestPages : BaseTest
    {
        protected HomePage HomePage => new();
        protected PageWithForms PageWithForms => new();
    }
}