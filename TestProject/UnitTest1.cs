using Ferma;
namespace TestProject;

[TestFixture]
public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CheckFermat_ThrowsException_WithLowN()
    {
        int a = 3, b = 4, c = 5, n = 2;
        Assert.Throws<ArgumentException>(() => FermaFunc.CheckFerma(a, b, c, n));
    }

    [Test]
    public void CheckFermat_ThrowsException_WithLowA()
    {
        int a = 0, b = 4, c = 5, n = 2;
        Assert.Throws<ArgumentException>(() => FermaFunc.CheckFerma(a, b, c, n));
    }
    [Test]
    public void CheckFermat_ThrowsException_WithLowB()
    {
        int a = 4, b = -6, c = 5, n = 2;
        Assert.Throws<ArgumentException>(() => FermaFunc.CheckFerma(a, b, c, n));
    }

    [Test]
    public void CheckFermat_ThrowsException_WithLowAAndB()
    {
        int a = 0, b = -6, c = 5, n = 15;
        Assert.Throws<ArgumentException>(() => FermaFunc.CheckFerma(a, b, c, n));
    }

    [Test]
    public void CheckFermat_ThrowsException_WithLowAAndBAndC()
    {
        int a = 0, b = 0, c = 0, n = 15;
        Assert.Throws<ArgumentException>(() => FermaFunc.CheckFerma(a, b, c, n));
    }

    [Test]
    public void CheckFermat_ReturnsFalse_WithCorrectButFalsyData1()
    {
        int a = 3, b = 4, c = 5, n = 3;
        bool result = FermaFunc.CheckFerma(a, b, c, n);
        Assert.IsFalse(result);
    }

    [Test]
    public void CheckFermat_ReturnsFalse_WithCorrectButFalsyData2()
    {
        int a = 1, b = 2, c = 3, n = 4;
        bool result = FermaFunc.CheckFerma(a, b, c, n);
        Assert.IsFalse(result);
    }

    [Test]
    public void CheckFermat_ReturnsFalse_WithCorrectButFalsyData3()
    {
        int a = 15, b = 5, c = 5, n = 3;
        bool result = FermaFunc.CheckFerma(a, b, c, n);
        Assert.IsFalse(result);
    }
}