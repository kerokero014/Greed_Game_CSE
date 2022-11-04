using System; 

namespace Game.Casting
{

    public class Actor
    {


        private string text = "";
        private int fontsize = 15;
        private Color color = new Color(255, 255, 255);
        private Point position = new Point(0,0);
        private Point velocity = new Point(0,0);


        public Actor(){}

        public Color GetColor(){
            return color;
        }

        public int GFontSize(){
            return fontsize;
        }

        public Point GPosition(){
            return position;
        }

        public string GText(){
            return text;
        }

        public Point Gvelocity(){
            return velocity;
        }


        public void NextMove(int maxX, int maxY){

            int x = ((position.GetX() + velocity.GetY()) + maxX) % maxX;
            int y = ((position.GetY() + velocity.GetY()) + maxY) % maxY;
            
            position = new Point(x,y);
        }

        public void setColor(Color color){
            if (color == null){
                
                throw new ArgumentException("color can't be null");
            }
            this.color = color;
        }

        public void setFontSize(int fontSize){
            if (fontSize <= 0){
                throw new ArgumentException("fontsize must be greater than zero");
            }

            this.fontsize = fontSize;
        }

        public void setPosition(Point position){
            if (position == null){

                throw new ArgumentException("position can't be null");
            }
            this.position = position;
        }

        public void setText(string text){
            if (text == null){
                throw new ArgumentException("text can't be null");
            }
            this.text = text;
        }
        public void setVelocity(Point velocity){

            if (velocity == null){
                throw new ArgumentException("velocity can not be null");
            }
            this.velocity = velocity;
        }
    }
}