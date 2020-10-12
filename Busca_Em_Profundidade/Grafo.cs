using System;
using System.Collections.Generic;
using Busca_Em_Profundidade.Entities;


namespace Busca_Em_Profundidade
{
    class Grafo
    {

        public List<Vertice> Lista_Nodes = new List<Vertice>();


        public void AdicionarVertice(Vertice V)
        {
            Lista_Nodes.Add(V);
        }
    }
}
