using System;
public class Navio
{
    public static void Main()
    {
        string NavioMessage = "10010110 11110111 01010110 00000001 00010111 00100110 01010111 00000001 00010111 01110110 01010111 00110110 11110111 11010111 01010111 00000011";

        Console.WriteLine(Final(NavioMessage));
    }

    static string ModificaDoisUltimos(string blockbyteStr)
    {
        string inicio = blockbyteStr.Substring(0, 6);
        string inverterdois;
        if (blockbyteStr[6] == '0')
        {
            inverterdois = "1";
        }
        else
        {
            inverterdois = "0";
        }
        if (blockbyteStr[7] == '0')
        {
            inverterdois += "1";
        }
        else
        {
            inverterdois += "0";
        }

        return inicio + inverterdois;
    }
    static string QuatroEmQuatro(string blockbyteStr)
    {
        return blockbyteStr.Substring(4, 4) + blockbyteStr.Substring(0, 4);
    }

    static string ConvertParaTexto(string[] bin)
    {
        string mensagem = "";
        foreach (string CadaLetra in bin)
        {
            char c = (char)Convert.ToInt32(CadaLetra, 2);
            mensagem += c;
        }
        return mensagem;
    }
    static string Final(string NavioMessage)
    {
        string[] blockbyteStr = NavioMessage.Split(' ');
        for (int i = 0; i < blockbyteStr.Length; i++)
        {
            blockbyteStr[i] = ModificaDoisUltimos(blockbyteStr[i]);
            blockbyteStr[i] = QuatroEmQuatro(blockbyteStr[i]);
        }
        return ConvertParaTexto(blockbyteStr);
    }
}