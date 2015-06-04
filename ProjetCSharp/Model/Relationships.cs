using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCSharp.Model
{
    [Serializable]
    public class Relationships<U, T> : IEnumerable<KeyValuePair<U, List<T>>>
        where U : class
        where T : class
    {
        private Dictionary<U, List<T>> dictionary;


        public Relationships()
        {
            this.dictionary = new Dictionary<U, List<T>>();
        }

        //on peut retirer la liste par l'indice.
        public List<T> this[int index]
        {
            get
            {
                List<List<T>> listValues = dictionary.Values.ToList<List<T>>();
                if (index >= listValues.Count) throw new IndexOutOfRangeException("Index must be less than the capacity.");
                List<T> list = listValues[index];
                return list;
            }
        }

        public Dictionary<U, List<T>> Dictionary
        {
            get { return dictionary; }
        }


        public void add(U u, T t)
        {
            bool found_u = false;
            bool found_t = false;
            foreach (KeyValuePair<U, List<T>> kvp in dictionary)
            {
                if (kvp.Key == u)
                {
                    found_u = true;
                    foreach (T obj_t in kvp.Value)
                        if (obj_t == t)
                            found_t = true;

                    //Assurer qu'il y aura pas deux mêmes éléments dans une même dictionary
                    if (!found_t)
                        kvp.Value.Add(t);
                }
            }

            if (!found_u)
            {
                List<T> newList = new List<T>();
                newList.Add(t);
                dictionary.Add(u, newList);
            }
        }

        public List<T> get(U u)
        {
            return dictionary[u];
        }

        public void remove(U u, T t)
        {
            foreach (KeyValuePair<U, List<T>> kvp in dictionary)
            {
                if (kvp.Key == u)
                {
                    kvp.Value.Remove(t);
                }
            }
        }

        public bool find(U u, T t)
        {

            foreach (KeyValuePair<U, List<T>> kvp in dictionary)
            {
                if (kvp.Key == u)
                {
                    foreach (T tmp in kvp.Value)
                        if (t == tmp)
                            return true;
                }

            }
            return false;
        }





        public IEnumerator<KeyValuePair<U, List<T>>> GetEnumerator()
        {
            return dictionary.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return dictionary.GetEnumerator();
        }
    }
}
