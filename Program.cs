using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Game.Casting;
using Game.Aesthetics;
using Game.Directing;


 namespace Game{

    class program{


        private static int FRAME_RATE = 7;
        private static int MAX_X = 900;
        private static int MAX_Y = 600;
        private static int CELL_SIZE = 15;
        private static int FONT_SIZE = 15;
        private static int COLUMS = 60;
        private static int ROWS = 40; 
        private static string CAPTION = "Greed";
        private static string DATA_PATH = "Data/messages.txt";
        private static Color WHITE = new Color(255, 255, 255);
        private static int DEFAULT = 20;

        static void Main(string[] args){
            
            Cast cast = new Cast();

            Actor banner = new Actor();
            banner.setText("");
            banner.setFontSize(FONT_SIZE);
            banner.setColor(WHITE);
            banner.setPosition(new Point(CELL_SIZE, 0));
            cast.AddActor("banner", banner);

            Actor robot = new Actor();
            robot.setText("#");
            robot.setFontSize(FONT_SIZE);
            robot.setColor(WHITE);
            robot.setPosition(new Point(MAX_X/2, MAX_Y - 30));
            cast.AddActor("robot", robot);

            Random random = new Random();
            for (int i =0; i < DEFAULT; i++){

                string text = ((char)(42)).ToString();

                int x = random.Next(1, COLUMS);
                int y = random.Next(1, ROWS);
                Point position = new Point(x,y);
                position = position.Scale(CELL_SIZE);

                int r = 1;
                int g = 255;
                int b = 1;
                Color color = new Color(r,g,b);

                Artifact artifact = new Artifact();
                artifact.setText(text);
                artifact.setFontSize(FONT_SIZE);
                artifact.setColor(color);
                artifact.setPosition(position);
                artifact.SetScore(1);
                cast.AddActor("artifacts", artifact);
            }

            for (int i = 0; i < DEFAULT; i++){

                string text = ((char)(111)).ToString();
                int x = random.Next(1,COLUMS);
                int y = random.Next(1, ROWS);
                Point position = new Point(x, y);
                position = position.Scale(CELL_SIZE);
                int r = 255;
                int b = 1;
                int g = 1;
                Color color = new Color(r,g,b);
                Artifact artifact = new Artifact();
                artifact.setText(text);
                artifact.setFontSize(FONT_SIZE);
                artifact.setColor(color);
                artifact.setPosition(position);
                artifact.SetScore(-1);
                cast.AddActor("artifacts", artifact);
            }

                KeyBoard keyboard = new KeyBoard(CELL_SIZE);
                Window window = new Window(CAPTION, MAX_X, MAX_Y, CELL_SIZE, FRAME_RATE, false);
                Director director = new Director(keyboard, window);
                director.startGame(cast);
            }
        }

    }
