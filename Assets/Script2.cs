using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Script2 : MonoBehaviour
{
	public static GameObject txt;               //定义公共静态变量用于另外脚本的引用

	void Start()
	{
		txt = GameObject.Find("w2");
		txt.SetActive(false); //保持txt的隐藏状态
		
	}

	void Update()
	{

	}
}

