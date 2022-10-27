using System; 
using System.Collections.Generic;


namespace Game{
    public class Cast{
        private Dictionary<string, List<Actor>> actors = new Dictionary<string, List<Actor>>();
        public Cast(){}

        public void AddActor(string group, Actor actors){

            if (!actors.ContainsKey(group))
            {
                actors[group] = new List<Actor>();
            }

            if (!actors[group].Contains(actor)){
                actors[group].Add(actor);
            }   
        }
        public Actor getFiActor(string group){
            
            Actor result = null;
            if (activators.ContainsKey(group)){
                
                if (actor.[group].Count > 0){
                    result = actors[group][0];
                }
            }
        }

        public List<actor> GeAll(){
            List<Actor> results = new List<Actor>;
            foreach (List<Activator> resul in actors.Values){

                results.AddRange(result);
            }
            
            return results;

        }

        public Actor GetFiact(string group){

            Actor result = null;
            if (actors.ContainsKey(string group)){
                if (actors[group].Count > 0 ){
                    result = actors[group][0];
                }
            }
            return result;
        }

        public void RemoveAct(string group, Actor actor){
            if (actor.ContainsKey(group)){
                actors[group].Remove(actor);
            }
        }

    }
}