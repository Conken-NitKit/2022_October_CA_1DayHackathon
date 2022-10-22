using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurnP : MonoBehaviour
{
    [SerializeField] Renderer Flame;
    private int count;
    private bool isOn = true;
    void Update()
    {
        count ++;
        if(count % 150 == 0)
        {
            if(isOn)
            {
                Flame.enabled = false;
                isOn = false;
            }
            else if(!isOn)
            {
                Flame.enabled = true;
                isOn = true;
            }
        }
    }
}
