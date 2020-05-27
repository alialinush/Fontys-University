using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;

namespace TrafficDemo.Classes
{
    class GPSTracker : IDijkstraAlgorithm
    {
        private Node end;
        private Node start;
        private List<Node> shortestPath;
        private List<Node> nodes;
        private Grid grid;

        public Node End { get => end; set => end = value; }
        public Node Start { get => start; set => start = value; }

        public List<Node> ShortestPath { get => shortestPath; set => shortestPath = value; }
        internal List<Node> Nodes { get => nodes; set => nodes = value; }

        public int NodeVisits { get; private set; }
        public double ShortestPathLength { get; set; }
        public double ShortestPathCost { get; private set; }

        public GPSTracker(Grid Grid, Point startPoint, Point endPoint, Lane endpointLane)
        {
            shortestPath = new List<Node>();
            this.grid = Grid;
            nodes = new List<Node>();

            this.end = new Node(endPoint);
            this.end.parentLane = endpointLane;
            nodes.Add(this.end);


            foreach (KeyValuePair<Lane, List<Point>> KVP in this.grid.GetAllPointsOnGrid())
            {
                foreach (Point P in KVP.Value) {
                    Node newNode = new Node(P);
                    newNode.parentLane = KVP.Key;
                    // Find out what type of point it is so we can adjust its weight later 

                    if (P == KVP.Key.StartPointOnScreen)
                    {
                        newNode.Name = "StartPoint";
                    }
                    foreach(KeyValuePair<int, Point> KVP2 in KVP.Key.EndPointsOnScreen)
                    {
                       if (P == KVP2.Value)
                        {
                            newNode.Name = "EndPoint";
                        }

                    }
                    foreach(Point edge in KVP.Key.EdgesOnScreen)
                    {
                        if (P == edge)
                        {
                            newNode.Name = "Edge";
                        }
                    }
                    nodes.Add(newNode);
                }
            }

            foreach (Node N in this.nodes)
            {
                if (N.Location == startPoint)
                {
                    this.start = N;
                }

            }


            // remove duplicates 

            for (int g = 0; g < nodes.Count; g++)
            {
                Node N1 = this.nodes[g];

                for (int i = 0; i < nodes.Count; i++)
                {
                    Node N2 = this.nodes[i];
                    if ((N1 != N2 && N1.Location == N2.Location) && N2 != this.start)
                    {
                        this.nodes.Remove(N2);
                    }
                }

            }



            foreach (Node Final in this.nodes)
            {
                Final.ConnectClosestNodes(nodes, 5);
            }

            foreach (Node Final in this.nodes)
            {
              Console.WriteLine("This node is " + Final.Name +  ". It's location is  " + Final.Location + ". Parent lane is :" + Final.parentLane.StartPointOnScreen);
            }



        }

        public List<Node> GetShortestPath()
        {
            DijkstraSearch();
            var shortestPath = new List<Node>();
            shortestPath.Add(end);
            BuildShortestPath(shortestPath, end);
            shortestPath.Reverse();
            return shortestPath;
        }


        public void BuildShortestPath(List<Node> list, Node node)
        {

            if (node.NearestToStart == null)
                return;
            list.Add(node.NearestToStart);
            ShortestPathLength += node.Connections.Single(x => x.ConnectedNode == node.NearestToStart).Length;
            ShortestPathCost += node.Connections.Single(x => x.ConnectedNode == node.NearestToStart).Cost;
            BuildShortestPath(list, node.NearestToStart);
        }

        public void DijkstraSearch()
        {
            NodeVisits = 0;
            Start.MinCostToStart = 0;
            var prioQueue = new List<Node>();
            prioQueue.Add(Start);
            do
            {
                NodeVisits++;
                prioQueue = prioQueue.OrderBy(x => x.MinCostToStart.Value).ToList();
                var node = prioQueue.First();
                prioQueue.Remove(node);
                foreach (var cnn in node.Connections.OrderBy(x => x.Cost))
                {
                    var childNode = cnn.ConnectedNode;
                    if (childNode.Visited)
                        continue;
                    if (childNode.MinCostToStart == null ||
                        node.MinCostToStart + cnn.Cost < childNode.MinCostToStart)
                    {
                        childNode.MinCostToStart = node.MinCostToStart + cnn.Cost;
                        childNode.NearestToStart = node;
                        if (!prioQueue.Contains(childNode))
                            prioQueue.Add(childNode);
                    }
                }
                node.Visited = true;
                if (node == End)
                    return;
            } while (prioQueue.Any());
        }

      /*  public Dictionary<Road, Point[]> AddPointstoPath(GraphicsPath MyPath)

        {
            Dictionary<Road, Point[]> road_points = new Dictionary<Road, Point[]>();
            List<Point> roadPoints = new List<Point>();
            List<Point> pathPoints = new List<Point>();
            foreach (Cell C in this.grid.Cells)
            {
                if (C.Road != null)
                {
                    for (int x = C.Road.Pb_Background.Location.X; x < C.Road.Location.X + 200; x++)
                    {
                        for (int y = C.Road.Pb_Background.Location.Y; y < C.Road.Location.Y + 200; y++)
                        {
                            Point p = new Point(x, y);
                            roadPoints.Add(p);
                        }
                    }
                }
            }

            foreach (Point P in roadPoints)
            {
                if (MyPath.IsOutlineVisible(P, (Pen)Pens.Green))
                {

                    pathPoints.Add(P);
                }

            }

            List<Point> pathHolder = new List<Point>();

            foreach (Cell C in this.grid.Cells)
            {
                Road selectedroad = null;
                if (C.Road != null)
                {
                    foreach (Point P in pathPoints)
                    {
                        if (((C.Road.Pb_Background.Location.X <= P.X) && (P.X <= C.Road.Pb_Background.Location.X + 200)) && ((P.Y >= C.Road.Pb_Background.Location.Y) && (P.Y <= C.Road.Pb_Background.Location.Y + 200)))
                        {
                            pathHolder.Add(P);
                            selectedroad = C.Road;
                        }
                    
                    }

                    Point[] pathPointsArray = pathHolder.ToArray();
                    if (selectedroad != null) { 
                    road_points.Add(selectedroad, pathPointsArray);
                    }
                    pathHolder = new List<Point>();
                    pathPointsArray = null;

                }
            }
            

            //   MyPath.AddLines(pathPointsArray);
            //   MyPath.Reverse(); // We need this otherwise the line will be upside down

            return road_points;


        }*/


    }
}
