using System;
using System.Collections.Generic;
using System.Linq;

// Classe ItemBiblioteca (Classe Base)
public abstract class ItemBiblioteca
{
    // Propriedades
    public int Id { get; set; }
    public string Titulo { get; set; }

    // Propriedade protegida
    protected string DescricaoInterna { get; set; }

    // Construtor
    public ItemBiblioteca(int id, string titulo)
    {
        Id = id;
        Titulo = titulo;
        DescricaoInterna = "Descrição padrão";
    }
}