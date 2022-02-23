using UnityEngine;

public class PoolController : MonoBehaviour
{
    public static ObjectsPool<string, GameObject> ObjectPool;
    
    private void Start()
    {
        CreatePool();
    }

    private void CreatePool()
    {
        ObjectPool = new ObjectsPool<string, GameObject>();
        var resources = Resources.LoadAll<GameObject>("CachedPrefabs/");

        foreach (var item in resources)
        {
            CacheResources(item);
        }
    }


    private void CacheResources(GameObject obj)
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject objectGame = Instantiate(obj);
            objectGame.name = obj.name;
            objectGame.SetActive(false);
            ObjectPool.Push(objectGame.name, objectGame);
        }
    }


    public static GameObject Pop(string key)
    {
        GameObject objectGame = ObjectPool.Pop(key);

        if (objectGame == null)
        {
            objectGame = ObjectPool.GetInstance(key);
            objectGame = Instantiate(objectGame);
        }

        objectGame.SetActive(true);

        return objectGame;
    }

    public static void Push(string key, GameObject obj)
    {
        ObjectPool.Push(key, obj);
        obj.SetActive(false);
    }
  
}


