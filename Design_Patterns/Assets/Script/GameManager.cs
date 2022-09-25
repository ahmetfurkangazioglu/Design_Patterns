using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private ObjectPool objectPool;
    [SerializeField] private int SpawnInterval;
    void Start()
    {
        AudioManager.Instance.AllMute();
        AudioManager.Instance.AllOpen();
        StartCoroutine(nameof(SpawnRoutine));
    }
 
    IEnumerator SpawnRoutine()
    {
        int counter=0;
        while (true)
        {
            objectPool.GetPooledObject(counter++%2);
            yield return new WaitForSeconds(SpawnInterval);
        }
    }
}
