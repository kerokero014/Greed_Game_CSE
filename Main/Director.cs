using System.Collections.Generic;
using Game.Services;
using Game.Casting;
using System;

using System.IO;
using Game.Directing;

namespace Game.Directing{

    public class Director{
        public int score = 0;
        private KeyBoardService keyboard = null;
        private WindowService window = null;

        public Director( KeyBoardService keyboard, WindowService window){
            this.keyboard = keyboard;
            this.window = window;
        }

        public void startGame(Cast cast){
            
            window.OpenWindow();
            while(window.isWindowOpen()){
                
                GetInputs(cast);
                DoUpdates(cast);
                DoOutputs(cast);
            }
            window.closeWindow();
        }

        private void GetInputs(Cast cast){
            List<Actor> artifacts = cast.getActors("artifacts");
            foreach(Actor actor in artifacts){
                Point artifactvelocity = keyboard.moveArtifact();
                actor.setVelocity(artifactvelocity);
                int maxX = window.getWidth();
                int maxY = window.getHeight();
                actor.NextMove(maxX, maxY);
            }
            Actor robot = cast.GetFiAct("robot");
            Point velocity = keyboard.getDirection();
            robot.setVelocity(velocity);
        }
        private void DoUpdates(Cast cast){

            Actor banner = cast.GetFiAct("banner");
            Actor robot = cast.GetFiAct("robot");
            List<Actor> artifacts = cast.getActors("arifacts");

            banner.setText($"Score: {score.ToString()}");
            int maxX = window.getWidth();
            int maxY = window.getHeight();

            robot.NextMove(maxX, maxY);

            Random random = new Random();
            foreach (Actor actor in artifacts)
            {
                if (robot.GPosition().Equals(actor.GPosition())){
                    
                    Artifact artifact = (Artifact) actor;
                    score += artifact.GetScore();
                    banner.setText($"Score: {score.ToString()}");

                    int x = random.Next(1,60);
                    int y = 0;
                    Point position = new Point(x,y);
                    position = position.Scale(15);

                    artifact.setPosition(position);
                }
            }
        }
        public void DoOutputs(Cast cast){

            List<Actor> actors = cast.GeAll();
            window.ClBffr();
            window.DrawActrs(actors);
            window.flushBuffr();
        }
    }
    
}
