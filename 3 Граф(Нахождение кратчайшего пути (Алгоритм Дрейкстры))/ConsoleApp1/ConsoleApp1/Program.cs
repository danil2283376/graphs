using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static Hashtable graph = new Hashtable();
        public static Hashtable costs = new Hashtable();
        public static Hashtable parrents = new Hashtable();
        static void Main(string[] args)
        {
            Deicstra[] deicstras = new Deicstra[3];
            deicstras[0] = new Deicstra("Start", "A", 6);
            deicstras[1] = new Deicstra("Start", "B", 2);
            deicstras[2] = new Deicstra("", "End", 0);

            //costs.Add("A", 6);
            //costs.Add("B", 2);
            //costs.Add("End", 0);

            graph.Add("A", deicstras[0]);
            graph.Add("B", deicstras[1]);
            graph.Add("End", deicstras[2]);

            graph["A"] = 0;

            for (int i = 0; i < graph.Count; i++) 
            {
                Deicstra milestone = graph[deicstras[i].nameMileStone] as Deicstra;


            }

            Console.ReadKey();
        }

        class Deicstra 
        {
            public string nameMileStone;
            public string parrentArray;
            public int costs;
            public 
            

            public Deicstra(string parrentArray, string nameMileStone, int costs)
            {
                this.parrentArray = parrentArray;
                this.nameMileStone = nameMileStone;
                this.costs = costs;
            }
        }

        //struct

        public static void AddInGraph() 
        {

        }
    }

    //struct Neighbors 
    //{
    //    public string milestone;
    //    public int massEdge;

    //    public Neighbors(string milestone, int massEdge)
    //    {
    //        this.milestone = milestone;
    //        this.massEdge = massEdge;
    //    }

    //    public void InputInfoNeighbor() 
    //    {
    //        Console.WriteLine("Веха: {0}, Вес ребра: {1}", milestone, massEdge);
    //    }
    //}
}
