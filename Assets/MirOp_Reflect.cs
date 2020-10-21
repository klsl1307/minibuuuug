using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MirOp_Reflect : MonoBehaviour
{
    public static GameObject refl;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(OnClick);
        refl = GameObject.Find("Reflect");
        refl.SetActive(false); //保持txt的隐藏状态
    }

    void OnClick()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
}
