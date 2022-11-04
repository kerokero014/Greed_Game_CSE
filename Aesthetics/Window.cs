using System.Collections.Generic;
using Game.Casting;
using Raylib_cs;



namespace Game.Aesthetics{

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

        public void closeWindow(){

            Raylib.CloseWindow();
        }

        public void ClBffr()
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Raylib_cs.Color.BLACK);
            if (dbg){
                DrawGrid();
            }
        }

        public void DrawActr(Actor actor){

            string text = actor.GText();

            int x = actor.GPosition().GetX();

            int y = actor.GPosition().GetY();

            int fontSize = actor.GFontSize();

            Casting.Color c = actor.GetColor();
            Raylib_cs.Color color = ToRaylibColor(c);

            Raylib.DrawText(text, x, y, fontSize, color);
        }

        public void DrawActrs(List<Actor>actors){
            foreach (Actor actor in actors){
                DrawActr(actor);
            }
        }

        public void flushBuffr(){
            Raylib.EndDrawing();
        }

        public int getCellSize(){
            return cellSize;
        }

        public int getHeight(){
            return height;
        }

        public int getWidth(){
            return width;
        }

        public bool isWindowOpen(){
            return !Raylib.WindowShouldClose();
        }

        public void OpenWindow(){
            Raylib.InitWindow(width, height, caption);
            Raylib.SetTargetFPS(frameRate);
        }

        private void DrawGrid(){

            for(int x = 0;  x < width; x += cellSize){
                Raylib.DrawLine(x, 0, x, height, Raylib_cs.Color.GRAY);
            }
            for (int y = 0; y < height; y += cellSize){
                Raylib.DrawLine(0, y, width, y, Raylib_cs.Color.GRAY); 
            }
        }

        private Raylib_cs.Color ToRaylibColor(Casting.Color color){

            int r = color.GetRed();
            int g = color.GetGreen();
            int b = color.GetBlue();
            int a = color.GetAlpha();
            return new Raylib_cs.Color(r,g,b,a);
        }
    }
}