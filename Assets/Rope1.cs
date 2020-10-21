using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rope1 : MonoBehaviour
{
    public static GameObject r1;
    // Start is called before the first frame update
    void Start()
    {
        r1 = GameObject.Find("绳子");
        r1.SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
