using System;
using System.Collections.Generic;
using System.Text;

namespace Busca_Em_Profundidade.Entities
{
    class Principal
    {
        static void Main(string[] args)
        {
            Grafo G = new Grafo();
            
            //Para o Grafo 01:
            Vertice n0 = new Vertice("Grupo de Risco");
            Vertice n1 = new Vertice("Sintomas Risco");
            Vertice n2 = new Vertice("Sintomas Sem Risco");
            Vertice n3 = new Vertice("Necessário Isolamento");
            Vertice n4 = new Vertice("Aguardar Disponibilidade em Fila");
            Vertice n5 = new Vertice("Fazer Exame de COVID");
            Vertice n6 = new Vertice("Enviar Para Casa");
            Vertice n7 = new Vertice("Isolar Paciente");
            Vertice n8 = new Vertice("Realizar Exames");

            
            G.AdicionarVertice(n0);
            G.AdicionarVertice(n1);
            G.AdicionarVertice(n2);
            G.AdicionarVertice(n3);
            G.AdicionarVertice(n4);
            G.AdicionarVertice(n5);
            G.AdicionarVertice(n6);
            G.AdicionarVertice(n7);
            G.AdicionarVertice(n8);
            

            n0.AdicionarVizinho(n1);
            n0.AdicionarVizinho(n2);

            n1.AdicionarVizinho(n3);
            n1.AdicionarVizinho(n4);

            n2.AdicionarVizinho(n5);
            n2.AdicionarVizinho(n6);

            n3.AdicionarVizinho(n7);
            n3.AdicionarVizinho(n8);
            
           

            /*Para o Grafo 02:
            Vertice n00 = new Vertice("Atendimento Recepção");
            Vertice n01 = new Vertice("Triagem");
            Vertice n02 = new Vertice("Atendimento");
            Vertice n03 = new Vertice("Espera");
            Vertice n04 = new Vertice("Coleta");
            Vertice n05 = new Vertice("Medicação");
            Vertice n06 = new Vertice("Finalização");

            G.AdicionarVertice(n00);
            G.AdicionarVertice(n01);
            G.AdicionarVertice(n02);
            G.AdicionarVertice(n03);
            G.AdicionarVertice(n04);
            G.AdicionarVertice(n05);
            G.AdicionarVertice(n06);

            n00.AdicionarVizinho(n01);
            n00.AdicionarVizinho(n02);

            n01.AdicionarVizinho(n03);

            n02.AdicionarVizinho(n04);
            n02.AdicionarVizinho(n05);
            n02.AdicionarVizinho(n06);

            n03.AdicionarVizinho(n02);

            n04.AdicionarVizinho(n05);
            n04.AdicionarVizinho(n03);
            n04.AdicionarVizinho(n02);

            n05.AdicionarVizinho(n04);
            n05.AdicionarVizinho(n02);          
            n05.AdicionarVizinho(n06);
            */

            
            DFS dfs = new DFS(G);

            dfs.DFS_Marcacao_Fresh();
          
        }
    }
}
