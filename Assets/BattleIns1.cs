using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleIns1 : MonoBehaviour
{
    public static GameObject bat_ins1;
    // Start is called before the first frame update
    void Start()
    {
        bat_ins1 = GameObject.Find("ins1");
        bat_ins1.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
