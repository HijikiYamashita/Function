using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionWithArgScript : MonoBehaviour
{
    void Start()
    {
        ShowRectangleArea(4,6);

        /*HelloYourName("Life is Tech!");
        HelloYourName("LiT! school");
        HelloYourName("Unity Course!");
        HelloYourName("私は魔女教、大罪司教『怠惰』担当、ペテルギウス・ロマネコンティ……デス");*/
    }

    void Update()
    {
        
    }

    void ShowRectangleArea(float width, float height)
    {
        float area = width * height;
        Debug.Log("面積は " + area + " です！");
    }

    void ShowSquareArea(float width)
    {
        float area = width * width;
        Debug.Log("面積は" + area + "です！");
    }

    void HelloYourName(string yourName)
    {
        Debug.Log("Hello " + yourName + " !");
    }
}
