namespace MoneyExtension.Test;

[TestClass]
public class MoneyExtensionTests
{
    [TestMethod]
    public void ShouldConvertDecimalToInt()
    {
        decimal valor = 279.98M;
        var cents = valor.ToCents();
        
        Assert.AreEqual(27998, cents);
    }
}