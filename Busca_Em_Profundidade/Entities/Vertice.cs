using System;
using System.Collections.Generic;
using System.Text;

namespace Busca_Em_Profundidade.Entities
{
    class Vertice 
    {
        public string Nome { get; set; }
        public int Tempo_Descoberta { get; set; }
        public int Tempo_Fechamento { get; set; }
        public Vertice V_Pai { get; set; }
        public enum State { nothing, fresh, visiting, visited };
        public List<Vertice> Vizinhos { get; set; }

        public State Estado { get; set; }

        public Vertice()
        {       
                       
        }
        public Vertice(string nome)
        {
            
            Vizinhos = new List<Vertice>();
            Nome = nome;       
        }

        
        public void AdicionarVizinho(Vertice X)
        {
            Vizinhos.Add(X);
            
        }
       
        public override string ToString()
        {
            return ($"Vertice: {Nome}");
        }
        
    }
}
