using System;
using System.Collections.Generic;
namespace TipoGenericoCSharpeIniciante
{
    public class ListaGenerica<T>{
        public void Adicionar(T input) { }
    }
    class Program
    {
        private class ExampleClass { }
        static void Main(string[] args)
        {
            ListaGenerica<int> lista1 = new ListaGenerica<int>();
            lista1.Adicionar(1);

            ListaGenerica<ExampleClass> lista3 = new ListaGenerica<ExampleClass>();
            lista3.Adicionar(new ExampleClass());
        }
    }
}
