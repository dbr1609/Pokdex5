﻿using Pokedex5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokedex5.ViewModels
{
    public class PokedexListViewModel
    {
        public string PageGenerated { get; set; }
        public IEnumerable<Pokemon> Pokemons { get; set; }
    }
}
