using Raylib_cs;
using Game.Casting;



namespace Game.Aesthetics{

    public class KeyBoard{
        private int cellSize = 15;


        public KeyBoard(int cellSize){
            
            this.cellSize = cellSize;
        }


        public Point getDirection(){

            int dx = 0;
            int dy = 0;

            if ( Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
            {
                dx = -1;
            }

            if ( Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
            {
                dx = 1;
            }

            Point direction = new Point(dx, dy);
            direction = direction.Scale(cellSize);
            
            return direction;
        }

        public Point moveArtifact(){
            int dx = 0;
            int dy = 1;

            Point direction = new Point(dx,dy);
            direction = direction.Scale(cellSize);

            return direction;
        }

    }



}