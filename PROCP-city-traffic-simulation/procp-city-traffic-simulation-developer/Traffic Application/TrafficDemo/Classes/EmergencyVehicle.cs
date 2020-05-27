using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TrafficDemo.Classes
{
    class EmergencyVehicle
    {
        private Color color;
        private PointF location;
        private float width;
        private float height;
        private Mediator mediator;
        private  List<Node> crashNodes;
        private Queue<Point> pathPoints;
        private Grid grid; 

        private Point target;
        public bool ArrivedAtEnd { get; set; }
        public bool ArrivedAtCrash { get; set; }

        

        public Road currentRoad { get; set; }
        public Color Color { get => color; set => color = value; }
        public PointF Location { get => location; set => location = value; }
        public float Width { get => width; set => width = value; }
        public float Height { get => height; set => height = value; }
        internal Mediator Mediator { get => mediator; set => mediator = value; }
        internal  List<Node> CrashNodes { get => crashNodes; set => crashNodes = value; }
        public Queue<Point> PathPoints { get => pathPoints; set => pathPoints = value; }
        public Point Target { get => target; set => target = value; }
        internal Grid Grid { get => grid; set => grid = value; }

        public EmergencyVehicle(Color c, float X, float Y, float Height, float Width, Mediator med,  List<Node> crashNodes, Point target )
        {
            pathPoints = new Queue<Point>();

            ArrivedAtEnd = false;
            ArrivedAtCrash = false;
            this.Color = c;
            this.Location = new PointF(X, Y);
            this.Height = Height;
            this.Width = Width;
            this.mediator = med;
            this.crashNodes = crashNodes;
            foreach(Node N in this.crashNodes)
            {
                pathPoints.Enqueue(N.Location);
            }
            this.target = target;

            foreach (Road R in this.mediator.ControlledRoads)
            {
                if ((this.location.X >= R.Location.X) && (this.location.X <= R.Location.X + 200))
                {
                    if (this.location.Y >= R.Location.Y && this.location.Y <= R.Location.Y + 200)
                    {

                        this.currentRoad = R;
                    }

                }
            }

            foreach(Node N in this.crashNodes)
            {
                Console.WriteLine("the node location in the Ev is " + N.Location);
            }


        }

        public void MoveToEmergency()
        {
            Console.WriteLine("Grid called the EV");
            foreach (Cell C in this.grid.Cells)
            {
                if (C.Road != null) { 
                    if (((this.location.X > C.Road.Location.X) && (this.location.X < C.Road.Location.X + 200)) && (this.location.Y > C.Road.Location.Y && this.location.Y < C.Road.Location.Y + 200))
                    {


                        this.currentRoad = C.Road;
                        break;

                    }
                    if (this.location.X == C.Road.Location.X || this.location.Y == C.Road.Location.Y)
                    {
                        this.currentRoad = C.Road;
                    }
                }

            }


            if (pathPoints.Count > 0 && this.location == pathPoints.Peek())
            {
                pathPoints.Dequeue();
                if (pathPoints.Count > 0) this.target = pathPoints.Peek();
            }
            if (pathPoints.Count > 0)
            {
                if (pathPoints.Peek().X > this.location.X)
                {
                    this.location.X += 1;
                }
                if (pathPoints.Peek().X < this.location.X)
                {
                    this.location.X -= 1;
                }
                if (pathPoints.Peek().Y > this.location.Y)
                {
                    this.location.Y += 1;
                }
                if (pathPoints.Peek().Y < this.location.Y)
                {
                    this.location.Y -= 1;
                }
            }

 

        }

        public void Draw(Graphics gr)
        {
            SolidBrush myBrush = new SolidBrush(Color.Orange);
            gr.FillEllipse(myBrush, this.location.X, this.location.Y, this.width, this.height);
        }

    }
}


