using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEngine;

public class ClickMirror : MonoBehaviour
{
    // Start is called before the first frame update
    int count1 = 0;
    public static int flag = 0;

    void OnMouseDown()
    {
        
        count1++;
        //print(count1);
        if (count1 >= 3)
        {
            Script2.txt.SetActive(true);
            flag = 1;
        }
    }
}
