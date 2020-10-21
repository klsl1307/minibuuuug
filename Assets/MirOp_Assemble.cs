using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MirOp_Assemble : MonoBehaviour
{
    public static GameObject ass;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(OnClick);
        ass = GameObject.Find("Assemble");
        ass.SetActive(false); //保持txt的隐藏状态
    }

    void OnClick()
    {
        Rope1.r1.SetActive(false);
        Rope2.r2.SetActive(true);
        BattleIns1.bat_ins1.SetActive(false);
        BattleIns2.bat_ins2.SetActive(true);
        Destroy(BattleIns2.bat_ins2, 2.0f);
        Destroy(Rope2.r2, 2.0f);
        //解锁“折”
        MirrorOperation.flag_reflect = 1;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
