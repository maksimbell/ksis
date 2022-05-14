using System.Collections.Generic;

namespace Common.Storage
{
    public abstract class KeyValueStorage<T>
    {
        public Dictionary<string, T> items;

        public T GetById(string id)
        {
            return items[id];
        }

        public void SetById(string id, T item)
        {
            items.Add(id, item);
        }

        public void RemoveById(string id)
        {
            items.Remove(id);
        }

        public abstract T FindByName(string name);

        public Dictionary<string, T> Items
        {
            get { return items; }
        }
    }
}
