using System.Collections.Generic;
using UnityEngine;

public class ObjectsPool<K,O> where O : Object
{
    public Dictionary<K, List<O>> objects;

    public ObjectsPool()
    {
        objects = new Dictionary<K, List<O>>();
    }

    public void Push(K key, O obj)
    {
        if (!objects.ContainsKey(key))
        {
            objects.Add(key, new List<O>());
            objects[key].Add(obj);
        }
        else if(!objects[key].Contains(obj))
        {
            objects[key].Add(obj);
        }
    }

    public O Pop(K key)
    {
        O obj = default;
        if (objects.ContainsKey(key) && objects[key].Count > 1)
        {
            obj = objects[key][0];
            objects[key].RemoveAt(0);
        }
        return obj;
    }

    public O GetInstance(K key)
    {
        O obj = default;
        if (objects.ContainsKey(key))
        {
            obj = objects[key][0];
        }
        return obj;
    }
}
