using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2 : MonoBehaviour
{
    private float MoveSpeed = 0f;//定义移动速度
    private Ray ray;//声明射线
    private RaycastHit hit;//射线检测的碰撞体的位置
    private Vector2 endPosition;//移动结束（鼠标点击）的位置
                                // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))//当点击鼠标左键时（左键为0，右键为1）
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);//由摄像机向鼠标位置发射射线，Input.mousePosition为鼠标点击的位置 
            if (Physics.Raycast(ray, out hit))//Physics.Raycast()表示当射线（ray）与任何碰撞体发生接触时返回true，否则返回false
            {
                if (hit.collider.gameObject.name == "001")//当射线碰撞到的是Plane（此if语句限制鼠标点击位置在Plane上有效）
                {
                    endPosition = hit.point;//鼠标点击位置赋给endPosition
                    endPosition.y = transform.position.y;//保持移动中的高度（y）不变
                    transform.LookAt(endPosition);//看向鼠标点击的方向
                    MoveSpeed = 10f;//速度赋为10,
                }
            }
        }
        if (Vector2.Distance(transform.position, hit.point) < 0.1f)//到达目标地址，自身位置和鼠标点击位置小于0时，近似于停止
        {
            MoveSpeed = 0;//到达鼠标位置，速度为0
        }
        transform.Translate(transform.forward * MoveSpeed * Time.deltaTime, Space.World);//朝鼠标点击方向移动
    }
}
