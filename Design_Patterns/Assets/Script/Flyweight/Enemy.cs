using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private EnemyType enemyType;
    void Start()
    {
        gameObject.GetComponent<Renderer>().material.color = enemyType.enemyColor;
        gameObject.transform.localScale = enemyType.enemyScale;
        int hp = enemyType.enemyMaxHp;
        float speed = enemyType.enemySpeed;
        Debug.Log(enemyType.typeName+"--" +hp+ "--"+speed);
    } 
    
}
