using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rope2 : MonoBehaviour
{
    public static GameObject r2;
    // Start is called before the first frame update
    void Start()
    {
        r2 = GameObject.Find("断绳");
        r2.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
