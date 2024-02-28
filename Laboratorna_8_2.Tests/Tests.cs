using NUnit.Framework;

[TestFixture]
public class Tests
{
    [Test]
    public void CountWordsStartingWithB()
    {
        string input = "Batman banana Cat dog";
        
        int result = Program.CountWordsStartingWithB(input);

        Assert.AreEqual(2, result);
    }
}