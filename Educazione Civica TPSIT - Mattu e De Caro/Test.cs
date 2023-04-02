using System;
using Funzioni;

public class test
{
    public void TestPrimaFunzione() 
    {  
        string result = Funzioni.PrimaFunzione("ciao", 10);

        Assert.Equal(result, "msky");
    }

    public void TestSecondaFunzione() 
    { 
        string result = Funzioni.SecondaFunzione("msky", 10);

        Assert.Equal(result, "ciao");
    }

    public void TestTerzaFunzione() 
    { 
        string result = Funzioni.TerzaFunzione("ciao", 10);

        Assert.Equal(result, 280);
    }

    public void TestQuartaFunzione() 
    { 
        string result = Funzioni.QuartaFunzione("ciao", 10);

        Assert.Equal(result, 41);
    }

    public void TestQuintaFunzione() 
    { 
        string result = Funzioni.QuintaFunzione("ciao", 10);

        Assert.Equal(result, 280);
    }

    public void TestSettimaFunzione() 
    { 
        string result = Funzioni.SettimaFunzione("ciao", 1);

        Assert.Equal(result, 41);
    }
}