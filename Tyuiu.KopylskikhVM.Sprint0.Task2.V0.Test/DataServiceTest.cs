namespace Tyuiu.KopylskikhVM.Sprint0.Task2.V0.Test;

using Tyuiu.KopylskikhVM.Sprint0.Task2.V0.Lib;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void CheckGetMessageValid()
    {
        var name = "Виктория";
        var res = DataService.GetMessage(name);

        Assert.AreEqual("Привет, Виктория", res);
    }
}