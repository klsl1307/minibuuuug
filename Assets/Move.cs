using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Vector2 moveTowardPosition = Vector2.zero;
    private Vector2 moveStartPosition = Vector2.zero;
    private float totalTime = 0.0f;
    private float costTime = 0.0f;
    private float timePrecent = 0.0f;
    private int speed = 5;
    private bool _isRuning = false;

    public GameObject cube;
    void Start()
    {
        cube = GameObject.Find("男主");
    }

    /// <summary>
    /// 是否正在移动
    /// </summary>
    public bool IsRuning
    {
        get { return _isRuning; }
        set { _isRuning = value; }
    }

    private void MoveByTimeline()
    {
        /*
         * 获得移动的最终目标位置，根据移动速度获得一共需要移动的时间 totalTime
         * 每一帧，
         *   1、累加 已经逝去的时间，并得到costTime，并获得移动的百分比 precent = costTime/totalTime
         *   2、获得当前精灵的位置，根据precent 进行位置插值，得到这一帧应该移动的位置
         *   3、使用设置移动
         *   4、通过precent判断是否<1 来判断是否移动到了目标位置
         *   5、如果完成，则调用最后一次移动实现，终点移动误差，并置为一些标志位
         */
        //获得当前位置
        Vector2 curenPosition = this.transform.position;
        if (Input.GetButton("Fire1"))
        {
            moveStartPosition = curenPosition;
            //获得移动终点位置
            moveTowardPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //moveTowardPosition.z = 0;

            costTime = 0.0f;
            //计算记录
            var subVector2 = moveTowardPosition - curenPosition;
            //计算需要移动的总时间
            totalTime = subVector2.magnitude / speed;

            _isRuning = true;
        }
        //如果已经移动
        if (_isRuning)
        {
            //如果时间百分比小于1 说明还没有移动到终点
            if (timePrecent < 1)
            {
                //累加时间
                costTime += Time.deltaTime;
                timePrecent = costTime / totalTime;

                Vector2 target = Vector2.Lerp(moveStartPosition, moveTowardPosition, timePrecent);
                cube.transform.position = target;

            }
            else //大于或者等于1 了说明是最后一次移动
            {
                cube.transform.position = moveTowardPosition;
                _isRuning = false;
                moveTowardPosition = Vector2.zero;
                timePrecent = 0.0f;
                costTime = 0.0f;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
