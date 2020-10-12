using System;
using System.Collections.Generic;
using System.Text;

namespace Busca_Em_Profundidade.Entities
{
    class DFS : Vertice
    {
       
        public int Tempo { get; set; }
        public Grafo G { get; set; }

        public DFS(Grafo g)
        {
            G = g;
        }

        public void DFS_Marcacao_Fresh()
        {          
            foreach (Vertice V in G.Lista_Nodes)
            {
                V.Estado = State.fresh;
               
            }
            Tempo = 0;          
            foreach (Vertice V in G.Lista_Nodes)
            {
                if (V.Estado == State.fresh)
                {
                    DFS_Visita(V);
                }
                
            }
        }

        public void DFS_Visita(Vertice V)
        {
            V.Estado = State.visiting;
            Tempo++;
            V.Tempo_Descoberta = Tempo;      

            foreach (Vertice s in V.Vizinhos)
            {
                
                if (s.Estado == State.visiting)
                {
                    Console.WriteLine($"{s} Voltou");
                }
                else
                {
                    Console.WriteLine($"{s} Ok");
                }
                
                if (s.Estado == State.fresh)
                {
                    s.V_Pai = V;
                    
                    DFS_Visita(s);
                    Console.WriteLine($"Pai {s.V_Pai} --> Vertice: {s.Nome} Descoberta: {s.Tempo_Descoberta} Fechamento: {s.Tempo_Fechamento}");
                   
                }    
                
            }
            V.Estado = State.visited;
            V.Tempo_Fechamento = ++Tempo;
        }

    }
}
