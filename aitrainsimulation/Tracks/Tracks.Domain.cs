using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

class Track
{
    public Node[] nodes { get; set; }
    public Edge[] edges { get; set; }
    public class Node
    {
        public Guid Id { get; init; }
        public string name { get; init; }

        public Node(string givenName) {
            name = givenName;
            Id = Guid.NewGuid();
        }
    }

    public class Edge
    {
        
        public string Source { get; init; }
        public string Destination { get; init; }
        public int Distance { get; set; }

        public Edge(string sourceNode, string destinationNode, int distance)
        {
            Source = sourceNode;
            Destination = destinationNode;
            Distance = distance;
        }
    }
}






