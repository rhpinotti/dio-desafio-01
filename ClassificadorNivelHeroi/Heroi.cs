using System.Reflection.Metadata;

public class Heroi
{
    public string nome {get;}
    public short experiencia {get; private set;}

    public Heroi(string nome, short experiencia)
    {
        this.nome = nome;
        this.experiencia = experiencia;
    }

    public void AtualizarExperiencia(short novaExperiencia)
    {
        this.experiencia = novaExperiencia;
    }

    public string ObterClasseHeroi()
    {
        if (experiencia <= 1000)
            return Constantes.FERRO;
        else if (experiencia <= 2000)
            return Constantes.BRONZE;
        else if (experiencia <= 5000)
            return Constantes.PRATA;
        else if (experiencia <= 7000)
            return Constantes.OURO;
        else if (experiencia <= 8000)
            return Constantes.PLATINA;
        else if (experiencia <= 9000)
            return Constantes.ASCENDENTE;
        else if (experiencia <= 10000)
            return Constantes.IMORTAL;
        else
            return Constantes.RADIANTE;
    }
}