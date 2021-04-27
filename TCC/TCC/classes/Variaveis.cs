using System.Collections.Generic;

public class Variaveis
{
    private string nome;
    private List<string> valoresPossiveis = new List<string>();
    private int qtdeValores;

    public string Nome
    {
        get
        {
            return nome;
        }
        set
        {
            nome = value;
        }
    }

    public List<string> ValoresPossiveis
    {
        get
        {
            return valoresPossiveis;
        }
        set
        {
            valoresPossiveis = value;
        }
    }

    public int QtdeValores
    {
        get
        {
            return qtdeValores;
        }
        set
        {
            qtdeValores = value;
        }
    }
}
