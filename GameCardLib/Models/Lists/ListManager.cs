using System;
using System.Collections.Generic;

namespace GameCardLib.Models.Lists
{
    [Serializable]
    public abstract class ListManager<T> : IListManager<T>
    {
        private List<T> _list;

        public int Count => _list.Count;

        public ListManager()
        {
            _list = new List<T>();
        }

        public bool Add(T newEntry)
        {
            try
            {
                _list.Add(newEntry);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool CheckIndex(int position)
        {
            try
            {
                if (_list[position] != null)
                {
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool Remove(int position)
        {
            try
            {
                _list.RemoveAt(position);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public void RemoveAll()
        {
            try
            {
                _list = new List<T>();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public bool Replace(int position, T newEntry)
        {
            try
            {
                _list[position] = newEntry;
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public T ReturnAt(int position)
        {
            return _list[position];
        }

        public string[] ToStringArray()
        {
            string[] arr = new string[_list.Count];
            try
            {
                for(int i = 0; i < _list.Count; i++) { 
                    arr[i] = _list[i].ToString();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return arr;
        }

        public List<string> ToStringList()
        {
            List<string> list = new List<string>();
            try
            {
                for(int i = 0; i < _list.Count; i++) { 
                    list.Add(_list[i].ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return list;
        }

        public List<T> getList()
        {
            return _list;
        }
    }
}
