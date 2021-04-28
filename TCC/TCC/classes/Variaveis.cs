using System.Collections.Generic;

public class Variaveis
{
    private string nome;
    private List<string> valoresPossiveis = new List<string>();
    private int qtdeValores;
    private int qtdeCombinacoes;
    private int qtdeRepeticoes;

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

    public int QtdeCombinacoes
    {
        get
        {
            return qtdeCombinacoes;
        }
        set
        {
            qtdeCombinacoes = value;
        }
    }

    public int QtdeRepeticoes
    {
        get
        {
            return qtdeRepeticoes;
        }
        set
        {
            qtdeRepeticoes = value;
        }
    }
}
