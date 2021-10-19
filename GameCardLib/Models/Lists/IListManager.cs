using System.Collections.Generic;

namespace GameCardLib.Models.Lists
{
    interface IListManager<T>
    {
        int Count { get; }

        public bool Add(T newEntry);

        public bool CheckIndex(int position);

        public bool Remove(int position);

        public void RemoveAll();

        public bool Replace(int position, T newEntry);

        public T ReturnAt(int position);

        public string[] ToStringArray();

        public List<string> ToStringList();
    }
}
