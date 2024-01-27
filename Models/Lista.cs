﻿namespace ProvaPub.Models
{
    public class Lista<T> where T : class
    {
        public List<T>? Elementos { get; set; }
        public int TotalCount { get; set; }
        public bool HasNext { get; set; }
    }
}
