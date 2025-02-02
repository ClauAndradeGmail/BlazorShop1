﻿using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace BlazorShop1.Api.Entities;

public class Categoria
{
    public int Id { get; set; }
    [MaxLength(100)]
    public string Nome { get; set; } = string.Empty;
    [MaxLength(100)]
    public string IconCSS { get; set; } = string.Empty;

    public Collection<Produto> Produtos { get; set; } = new Collection<Produto>();
}
