using System; 
using System.Collections.Generic;


namespace Game{
    public class Cast{
        private Dictionary<string, List<Actor>> actors = new Dictionary<string, List<Actor>>();
        public Cast(){}

        public void AddActor(string group, Actor actor){

            if (!actors.ContainsKey(group))
            {
                actors[group] = new List<Actor>();
            }

            if (!actors[group].Contains(actor)){
                actors[group].Add(actor);
            }   
        }

        public List<Actor> getActor(string group){

            List<Actor> results = new List<Actor>();
            if (actors.ContainsKey(group)){

                results.AddRange(actors[group]);
            }
            return results;
        }

        public List<Actor> GeAll(){
            List<Actor> results = new List<Actor>();
            foreach (List<Actor> resul in actors.Values)
            {
                results.AddRange(results);
            }
            
            return results;

        }

        public Actor getFiActor(string group)
        {    
            Actor result = null;
            if (actors.ContainsKey(group))
            {
                if (actors[group].Count > 0)
                {
                    result = actors[group][0];
                }
            }
        }

        public Actor GetFiact(string group){

            Actor result = null;
            if (actors.ContainsKey(group)){
                if (actors[group].Count > 0 ){
                    result = actors[group][0];
                }
            }
            return result;
        }

        public void RemoveAct(string group, Actor actor){
            if (actors.ContainsKey(group)){
                actors[group].Remove(actor);
            }
        }

    }
}