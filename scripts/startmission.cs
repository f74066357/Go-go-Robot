using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

/*
0平板撐體 MET 9.5

1伏地挺身 MET 8.0  0
2開合跳 MET 8.0    1
3仰臥起坐 MET 8.0  2
4波比 MET 8.0      3
5反向卷腹 MET 8.0  4

6深蹲 MET 7.5    0
7橋式 MET 7.0    1
8無影凳 MET 7.0  2
9弓步 MET 6.5    3
10鳥犬式 MET 6.5  4
11剪刀式 MET 6.0  5
*/

public class startmission : MonoBehaviour, IPointerClickHandler
{

    //array 紀錄做到哪裡
    public void OnPointerClick(PointerEventData e)
    {
        //int c = missionnum.mission_num;
        //判斷list是否為空
        if (finish.f == true)
        {
            Debug.Log("already finish");
            //messagebox
        }
        else
        {
            Debug.Log("not finish");
            if (missionlist.order.Count == 0)
            {
                finish.f = true;
                SceneManager.LoadScene(5);
            }
            else
            {
                switch (missionlist.order[0])
                {
                    case 0:
                        SceneManager.LoadScene(6);
                        missionlist.order.RemoveAt(0);
                        break;
                    case 1:
                        SceneManager.LoadScene(6);
                        missionlist.order.RemoveAt(0);
                        break;
                    case 2:
                        SceneManager.LoadScene(6);
                        missionlist.order.RemoveAt(0);
                        break;
                    case 3:
                        SceneManager.LoadScene(6);
                        missionlist.order.RemoveAt(0);
                        break;
                    case 4:
                        SceneManager.LoadScene(6);
                        missionlist.order.RemoveAt(0);
                        break;
                    case 5:
                        SceneManager.LoadScene(6);
                        missionlist.order.RemoveAt(0);
                        break;
                    case 6:
                        SceneManager.LoadScene(6);
                        missionlist.order.RemoveAt(0);
                        break;
                    case 7:
                        SceneManager.LoadScene(6);
                        missionlist.order.RemoveAt(0);
                        break;
                    case 8:
                        SceneManager.LoadScene(6);
                        missionlist.order.RemoveAt(0);
                        break;
                    case 9:
                        SceneManager.LoadScene(6);
                        missionlist.order.RemoveAt(0);
                        break;
                    case 10:
                        SceneManager.LoadScene(6);
                        missionlist.order.RemoveAt(0);
                        break;
                    case 11:
                        SceneManager.LoadScene(6);
                        missionlist.order.RemoveAt(0);
                        break;
                }
            }
        }

       
    }
}
