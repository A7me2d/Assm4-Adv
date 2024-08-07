using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assm4_Adv
{
    public class MyList<T>
    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public bool Exists(Predicate<T> match)
        {
            foreach (T item in items)
            {
                if (match(item))
                    return true;
            }
            return false;
        }

        public T Find(Predicate<T> match)
        {
            foreach (T item in items)
            {
                if (match(item))
                    return item;
            }
            return default(T);
        }

        public List<T> FindAll(Predicate<T> match)
        {
            List<T> results = new List<T>();
            foreach (T item in items)
            {
                if (match(item))
                    results.Add(item);
            }
            return results;
        }

        public int FindIndex(Predicate<T> match)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (match(items[i]))
                    return i;
            }
            return -1;
        }

        public int FindLastIndex(Predicate<T> match)
        {
            for (int i = items.Count - 1; i >= 0; i--)
            {
                if (match(items[i]))
                    return i;
            }
            return -1;
        }

        public void ForEach(Action<T> action)
        {
            foreach (T item in items)
            {
                action(item);
            }
        }

        public bool TrueForAll(Predicate<T> match)
        {
            foreach (T item in items)
            {
                if (!match(item))
                    return false;
            }
            return true;
        }
    }
}
