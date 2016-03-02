using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3_Intersection
{
   /* Ți se dă o listă de tronsoane verticale și orizontale consecutive de dimensiuni fixe.

Scrie o funcție care verifică dacă tronsoanele se intersectează. Dacă se intersectează întoarce
primul punct de intersecție.

Notă: având în vedere că tronsoanele îs de dimensiuni fixe, alege cel mai simplu mod de a le reprezenta,
de ex: ca și o succesiune de direcții stânga, dreapta, sus, jos. 
*/
public enum Directions
    {
        Up,
        Down,
        Left,
        Right,

    }
public struct Point
    {
        public int x,y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

    }
public struct Result
    {
        public bool isIntersection;
        public Point firstIntersection;    
    }   
    
    public class Intersection
    {
        public Directions[] route;
        public Point[] routeCoordinates;
       
        static void Main(string[] args)
        {
        }
        public static Result CheckIntersection(Directions[] list, Point startingPoint)
        {
            Result intersectionPoint= new Result();
            Point[] routeCoordinates=new Point[1];
            GenerateCoordinates(ref routeCoordinates, list, startingPoint);
            intersectionPoint.isIntersection = false;
            for (int i=0; i<routeCoordinates.Length-1; i++)
            {
                for(int j=i+1;j<routeCoordinates.Length;j++)
                {
                    if (routeCoordinates[i].x==routeCoordinates[j].x && routeCoordinates[i].y == routeCoordinates[j].y)
                    {
                        intersectionPoint.isIntersection = true;
                        intersectionPoint.firstIntersection.x = routeCoordinates[i].x;
                        intersectionPoint.firstIntersection.y = routeCoordinates[i].y;
                        break;
                    }
                    if (intersectionPoint.isIntersection) break;
                }
            }
            return intersectionPoint;
        }
        public static void GenerateCoordinates(ref Point[] routeCoordinates, Directions[] route,Point startingPoint  )
        {
            routeCoordinates = new Point[route.Length+1];
            routeCoordinates[0].x = startingPoint.x;
            routeCoordinates[0].y = startingPoint.y;
            for (int i = 0; i < route.Length; i++)
            {

                routeCoordinates[i+1].x = routeCoordinates[i].x;
                routeCoordinates[i+1].y = routeCoordinates[i].y;
                switch (route[i])
                {
                    case Directions.Up:
                        ++routeCoordinates[i+1].y;
                        break;
                    case Directions.Down:
                        --routeCoordinates[i+1].y;
                        break;
                    case Directions.Right:
                        ++routeCoordinates[i+1].x;
                        break;
                    case Directions.Left:
                        --routeCoordinates[i+1].x;
                        break;
                }
            }          

        }

    }
}
