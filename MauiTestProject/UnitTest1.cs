namespace MauiTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var page = new MauiUnitTestSample.MainPage();
            var count = page.Counter();
            Assert.Equal(1, count);
        }
    }
}