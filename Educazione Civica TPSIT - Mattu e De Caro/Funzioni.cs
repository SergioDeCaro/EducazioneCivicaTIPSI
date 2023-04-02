using System;

public class Program
{
    private static string alf = "abcdefghijklmnopqrstuvwxyz";
    private static int contatore = 0;

    public static string PrimaFunzione(string s, int n)
    {
        string result = "";
        for(int i=0; i<s.Length; i++)
        {
            for(int j=0; j<alf.Length; j++)
            {
                if(s[i] == alf[j])
                {
                    int index = j+n;
                    if(index > 25)
                    {
                        index -= 26;
                    }
                    result += alf[index];
                }
            }
        }
        return result;
    }

    public static string SecondaFunzione(string s, int n)
    {
        string result = "";
        for(int i=0; i<s.Length; i++)
        {
            for(int j=0; j<alf.Length; j++)
            {
                if(s[i] == alf[j])
                {
                    int index = j-n;
                    if (index < 0)
                    {
                        index += 26;
                    }
                    result += alf[index];
                }
            }
        }
        return result;
    }

    public static int TerzaFunzione(string s, int n)
    {
        int result = 0;
        for (int i=0; i<s.Length; i++)
        {
            for (int j=0; j<alf.Length; j++)
            {
                if (s[i] == alf[j])
                {
                    result += j + 1;
                }
            }
        }
        return result * n;
    }

    public static int QuartaFunzione(string s, int n)
    {
        int result = 0;
        for (int i=0; i<s.Length; i++)
        {
            for (int j=0; j<alf.Length; j++)
            {
                if (s[i] == alf[j])
                {
                    result *= j + 1;
                }
            }
        }
        return Math.Ceiling(result / n);
    }

    public static int QuintaFunzione(string s, int n)
    {
        if(n%2 == 0)
        {
            return TerzaFunzione(s, n);
        }
        else
        {
            return QuartaFunzione(s, n);
        }
        contatore++;
    }

    public static int SettimaFunzione(string s, int n)
    {
        return QuintaFunzione(s, contatore);
    }
}