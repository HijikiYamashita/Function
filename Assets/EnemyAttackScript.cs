using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackScript : MonoBehaviour
{
    void Start()
    {
        EnemyAttack("ゴーレム", 60);
        EnemyAttack("スライム", 100);
    }

    void Update()
    {
        
    }

    void EnemyAttack(string enemyName,int damage)
    {
        Debug.Log(enemyName + "に" + damage + "のダメージ!");
    }
}
