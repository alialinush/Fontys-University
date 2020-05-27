using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;
using System.IO;

namespace TrafficDemo.Classes
{
    [Serializable]
    class Pedestrian
    {
        private Color color;
        private PointF location;
        private float width;
        private float height;
        private bool keepDriving;
        private Lane currentLane;
        private Mediator mediator;
        private PointF target;
        private int edgesPassed = 0;
        private int mediatorCallsCounter = 0;
        private Random diceThrow;
        private Queue<PointF> pathPoints;
        public Color Color { get => color; set => color = value; }
        public PointF Location { get => location; set => location = value; }
        public bool KeepDriving { get => keepDriving; set => keepDriving = value; }
        public float Width { get => width; set => width = value; }
        public float Height { get => height; set => height = value; }
        internal Lane CurrentLane { get => currentLane; set => currentLane = value; }
        internal Mediator Mediator { get => mediator; set => mediator = value; }
        public PointF Target { get => target; set => target = value; }
        public int EdgesPassed { get => edgesPassed; set => edgesPassed = value; }

        public Pedestrian(Color c, float X, float Y, float Height, float Width, Lane cLane)
        {
            pathPoints = new Queue<PointF>();
            keepDriving = true;
            this.location = new PointF(X, Y);
            this.Color = c;
            this.width = Width;
            this.height = Height;
            this.currentLane = cLane;
            this.mediator = cLane.MyMediator;
            this.diceThrow = new Random();
            if (this.location != this.currentLane.StartPoint) this.pathPoints.Enqueue(currentLane.StartPoint);
            if (currentLane.Edges != null)
            {
                foreach (var edge in currentLane.Edges)
                {
                    pathPoints.Enqueue(edge);
                }
            }
            pathPoints.Enqueue(currentLane.EndPoint);
            this.target = pathPoints.Peek();
        }
        public void Draw(Graphics gr)
        {
            SolidBrush myBrush = new SolidBrush(Color.Yellow);
            gr.FillEllipse(myBrush, this.location.X, this.location.Y, this.width, this.height);
        }
        public void Stop()
        {
            keepDriving = false;
        }
        public void Walk()
        {
            string response = "Yes";
            //response = mediator.SendMessage("Should I keep driving?", this, this.target);
            //mediatorCallsCounter += 1;
            //if (mediator.SurpriseElements == true && mediatorCallsCounter % 25 == 0)
            //{
            //    int x = diceThrow.Next(1, 10);
            //    if (x <= 5)
            //    {
            //        if (response == "No") { response = "Yes"; }
            //    }
            //}
            if (response == "Yes")
            {
                keepDriving = true;
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

            else
            {
                this.Stop();
            }
        }
    }
}
