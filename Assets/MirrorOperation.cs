using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEngine;

public class MirrorOperation : MonoBehaviour
{
    // Start is called before the first frame update
    //int count1 = 0;
    public static int flag_assemble = 1; //聚
    public static int flag_reflect = 0; //折
    public static int flag_show = 0; //映
    public static int flag_open = 1; //决定是打开镜子操作（1）还是关闭镜子操作（0）

    void OnMouseDown()
    {
        if (flag_open == 1)
        {
            if (flag_assemble == 1)
            {
                MirOp_Assemble.ass.SetActive(true);
            }
            if (flag_reflect == 1)
            {
                MirOp_Reflect.refl.SetActive(true);
            }
            if (flag_show == 1)
            {
                MirOp_Show.show.SetActive(true);
            }
            flag_open = 0;
        }
        else if (flag_open == 0)
        {
            MirOp_Assemble.ass.SetActive(false);
            MirOp_Reflect.refl.SetActive(false);
            MirOp_Show.show.SetActive(false);
            flag_open = 1;
        }
    }
}
