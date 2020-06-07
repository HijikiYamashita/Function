using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSelfScript : MonoBehaviour
{
    void Start()
    {
        AttackSelf(60);
    }

    void Update()
    {
        
    }

    void AttackSelf(int damage)
    {
        Debug.Log("自分に" + damage + "のダメージ!");
    }
}
