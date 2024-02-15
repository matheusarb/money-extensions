namespace MoneyExtension.Tests;

[TestClass]
public class MoneyExtensionTests
{
    [TestMethod]
    public void ShouldConvertDecimalToInt()
    {
        decimal val = 279.98M;
        var cents = val.ToCents();

        Assert.AreEqual(27998, cents);
    }
}