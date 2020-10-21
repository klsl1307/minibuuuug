using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MirOp_Show : MonoBehaviour
{
    public static GameObject show;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(OnClick);
        show = GameObject.Find("Show");
        show.SetActive(false); //保持txt的隐藏状态
        //this.SetActive(false);
    }

    void OnClick()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
