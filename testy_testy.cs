 

using sumy;

namespace sumy.Test;

public class Tests
{
    Suma suma;
    [SetUp]
    public void Setup()
    {
        suma = new Suma();
    }

    [Test]
    public void MniejNiz10()
    {
        //arrange
        float[] tablica = [0,1,0,1,0,1,0,1,0,1];
        float wynik = 0.5f;
        //act
        float jakisAkt = suma.Decyzja(tablica);
        //assert 
        Assert.That(jakisAkt,Is.EqualTo(wynik));
    }
    [Test]
    public void Miedzy10a20()
    {
        //arrange
        float[] tablica = [1,2,1,2,1,2,1,2,1,2];
        float wynik = 5;
        //act
        float jakisAkt = suma.Decyzja(tablica);
        //assert 
        Assert.That(jakisAkt,Is.EqualTo(wynik));
    }
    [Test]
    public void Powyzej20()
    {
        //arrange
        float[] tablica = [3,2,3,2,3,2,3,2,3,2];
        float wynik = 10;
        //act
        float jakisAkt = suma.Decyzja(tablica);
        //assert 
        Assert.That(jakisAkt,Is.EqualTo(wynik));
    }
}
