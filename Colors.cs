﻿using System;
using System.Collections.Generic;

namespace Game{

    public class Color{

        private int red = 0;
        private int green = 0;
        private int blue = 0;
        private int alpha = 225;

        public Color(int red, int green, int blue)
        {
            this.red = red; 
            this.green = green;
            this.blue = blue;
        }
        
        public int GetAlpha(){
            return alpha;
        }

        public int GetBlue(){
            return blue;
        }
        public int GetRed(){
            return red;
        }
        public int GetGreen(){
            return green;
        }
    }

}