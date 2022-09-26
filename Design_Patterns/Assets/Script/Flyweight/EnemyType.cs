using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Enemy Type",menuName ="Enemy Type")]
public class EnemyType : ScriptableObject
{
    public string typeName = "Type";
    public Color enemyColor = Color.red;
    public Vector3 enemyScale = Vector3.one;
    public int enemyMaxHp = 100;
    public float enemySpeed = 2; 
}
