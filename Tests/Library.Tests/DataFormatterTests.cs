namespace TestDateFormat;

public class DataFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
     public void FechaCorrecta()
    {
        string input = "28/07/2004";
        string expected = "2004-07-";
        string output = DateFormatter.ChangeFormat(input);
        Assert.AreEqual(output, expected);
    }
    public void StringVacio()
    {
        string input = "";
        string expected = "2004-07-28";
        string output = DateFormatter.ChangeFormat(input);
        Assert.AreEqual(output, expected);
    }

    public void Invertida()
    {
        string input = "28/07/2004";
        string expected = "2004-07-28";
        string output = DateFormatter.ChangeFormat(input);
        Assert.AreEqual(output, expected);
    }
    
}