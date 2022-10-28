using System;
using System.Collections.Generic;

namespace Game.Casting
{
    public class Point{
        private int x = 0;
        private int y = 0;
        public Point(int x, int y){
            this.x = x;
            this.y = y;
        }

        public Point Sum(Point other){
            int x = this.x + other.GetX();
            int y = this.y + other.GetY();

            return new Point(x, y);
        }

        public bool Results(Point other){
            return this.x == other.GetX() && this.y == other.GetY();
        }

        public int GetX(){
            return x;
        }

        public int GetY(){
            return y;
        }

        public Point Scale(int factor){
            
            int x = this.x * factor;
            int y =  this.y * factor;

            return new Point(x,y);
        }
    }

}