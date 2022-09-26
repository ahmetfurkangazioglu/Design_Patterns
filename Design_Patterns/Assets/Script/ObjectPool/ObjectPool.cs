using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ObjectPool : MonoBehaviour
{
    [Serializable]
    public struct Pool
    {
        public Queue<GameObject> pooledObjects;
        public GameObject objectPrefab;
        public int poolSize;
    }
    [SerializeField] private Pool[] pools;


    private void Awake()
    {
        for (int i = 0; i < pools.Length; i++)
        {
            pools[i].pooledObjects = new Queue<GameObject>();
            for (int j = 0; j < pools[i].poolSize; j++)
            {
                GameObject obj = Instantiate(pools[i].objectPrefab);
                obj.SetActive(false);
                pools[i].pooledObjects.Enqueue(obj);
            }
        }
    }


    public GameObject GetPooledObject(int objectType)
    {
        if (objectType>= pools.Length)
        {
            return null;
        }
       GameObject obj= pools[objectType].pooledObjects.Dequeue();
        obj.transform.position = Vector3.zero;
        obj.SetActive(true);
        pools[objectType].pooledObjects.Enqueue(obj);
        return obj;
    }
}
