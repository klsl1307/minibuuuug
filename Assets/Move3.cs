using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Move3 : MonoBehaviour
{

    public GameObject cube;
    void Start()
    {
        cube = GameObject.Find("男主");
    }
    void fff()
    {
        if (Input.GetKey(KeyCode.A))
        {
            cube.transform.Translate(Vector2.left * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            cube.transform.Translate(Vector2.right * Time.deltaTime);
        }
    }

    void Update()
    {

    }
}