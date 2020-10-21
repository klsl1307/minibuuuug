using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleIns2 : MonoBehaviour
{
    public static GameObject bat_ins2;
    // Start is called before the first frame update
    void Start()
    {
        bat_ins2 = GameObject.Find("ins2");
        bat_ins2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
