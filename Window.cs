using System.Collections.Generic;
using Raylib_cs;
using Game;


namespace Game{

    public class Window{

        private int cellSize = 15;
        private string caption = "";
        private int width = 640;
        private int height = 480;
        private int frameRate = 0;
        private bool dbg = false; 


        public Window(string caption, int width, int height, int cellSize, int frameRate, bool dbg){
            this.caption = caption; 
            this.width = width;
            this.height = height; 
            this.cellSize = cellSize;
            this.frameRate = frameRate;
            this.dbg = dbg; 
        }

        public void closeWinw(){
            Raylib.CloseWindow();
        }

        public void ClBffr(){
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Raylib_cs.Color.BLACK);
            if (dbg){
                DrawGrid();
            }
        }


        public void DrawActr(List<Actor>actors){
            foreach (Actor actor in actors){
                DrawActr(actor);
            }
        }




    }








}