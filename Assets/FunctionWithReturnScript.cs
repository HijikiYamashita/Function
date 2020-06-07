using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionWithReturnScript : MonoBehaviour
{
    void Start()
    {
        /*float area1 = CalculateRectangleArea(4.0f, 6.0f);
        float area2 = CalculateRectangleArea(5.0f, 5.0f);

        if (area1 > area2)
        {
            Debug.Log("area1のほうが広い");
        }
        else if (area1 < area2)
        {
            Debug.Log("area2のほうが広い");
        }
        else
        {
            Debug.Log("同じ広さ");
        }*/

        float area3 = TriangleRectangleArea(10.0f,10.0f);
        {
            if (area3 >= 25)
            {
                Debug.Log("無駄に広いね！必要以上に！");
            }
        }
    }

    void Update()
    {
        
    }

    float CalculateRectangleArea(float width, float height)
    {
        float result = width * height;
        return result;
    }

    float TriangleRectangleArea(float bottom,float height)
    {
        float result = bottom * height / 2;
        return result;
    }
}
