using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class show_word : MonoBehaviour
{
    public Text t1;
    public Text t2;
    public Text t3;
    public Text t4;
    public Text t5;
    public Text t6;
    public Text t7;
    string m1;
    string m2;
    string m3;
    string m4;
    string m5;
    string m6;
    string m7;
    public mission_decide d;
    // Use this for initialization
    void Start()
    {

        if (d.day < 5)
        {
            switch (d.mission1)
            {
                case 0:
                    t1.text = "深蹲   " + d.time1 + "下";
                    missionlist.order.Add(6);
                    break;
                case 1:
                    t1.text = "橋式   " + d.time1 + "下";
                    missionlist.order.Add(7);
                    break;
                case 2:
                    t1.text = "無影凳   " + d.time1 + "下";
                    missionlist.order.Add(8);
                    break;
                case 3:
                    t1.text = "弓步   " + d.time1 + "下";
                    missionlist.order.Add(9);
                    break;
                case 4:
                    t1.text = "鳥犬式   " + d.time1 + "下";
                    missionlist.order.Add(10);
                    break;
                case 5:
                    t1.text = "剪刀式   " + d.time1 + "下";
                    missionlist.order.Add(11);
                    break;
            }
            switch (d.mission2)
            {
                case 0:
                    t2.text = "深蹲   " + d.time2 + "下";
                    missionlist.order.Add(6);
                    break;
                case 1:
                    t2.text = "橋式   " + d.time2 + "下";
                    missionlist.order.Add(7);
                    break;
                case 2:
                    t2.text = "無影凳   " + d.time2 + "下";
                    missionlist.order.Add(8);
                    break;
                case 3:
                    t2.text = "弓步   " + d.time2 + "下";
                    missionlist.order.Add(9);
                    break;
                case 4:
                    t2.text = "鳥犬式   " + d.time2 + "下";
                    missionlist.order.Add(10);
                    break;
                case 5:
                    t2.text = "剪刀式   " + d.time2 + "下";
                    missionlist.order.Add(11);
                    break;
            }
            switch (d.mission3)
            {
                case 0:
                    t3.text = "伏地挺身   " + d.time3 + "下";
                    missionlist.order.Add(1);
                    break;
                case 1:
                    t3.text = "開合跳   " + d.time3 + "下";
                    missionlist.order.Add(2);
                    break;
                case 2:
                    t3.text = "仰臥起坐   " + d.time3 + "下";
                    missionlist.order.Add(3);
                    break;
                case 3:
                    t3.text = "波比   " + d.time3 + "組";
                    missionlist.order.Add(4);
                    break;
                case 4:
                    t3.text = "反向卷腹   " + d.time3 + "下";
                    missionlist.order.Add(5);
                    break;
            }
            t4.text = "平板撐體   " + d.time_for_plane + "秒";
            missionlist.order.Add(0);
        }
        else if (d.day > 5 && d.day <= 10)
        {
            switch (d.mission1)
            {
                case 0:
                    t1.text = "深蹲   " + d.time1 + "下";
                    missionlist.order.Add(6);
                    break;
                case 1:
                    t1.text = "橋式   " + d.time1 + "下";
                    missionlist.order.Add(7);
                    break;
                case 2:
                    t1.text = "無影凳   " + d.time1 + "下";
                    missionlist.order.Add(8);
                    break;
                case 3:
                    t1.text = "弓步   " + d.time1 + "下";
                    missionlist.order.Add(9);
                    break;
                case 4:
                    t1.text = "鳥犬式   " + d.time1 + "下";
                    missionlist.order.Add(10);
                    break;
                case 5:
                    t1.text = "剪刀式   " + d.time1 + "下";
                    missionlist.order.Add(11);
                    break;
            }

            switch (d.mission2)
            {
                case 0:
                    t2.text = "深蹲   " + d.time2 + "下";
                    missionlist.order.Add(6);
                    break;
                case 1:
                    t2.text = "橋式   " + d.time2 + "下";
                    missionlist.order.Add(7);
                    break;
                case 2:
                    t2.text = "無影凳   " + d.time2 + "下";
                    missionlist.order.Add(8);
                    break;
                case 3:
                    t2.text = "弓步   " + d.time2 + "下";
                    missionlist.order.Add(9);
                    break;
                case 4:
                    t2.text = "鳥犬式   " + d.time2 + "下";
                    missionlist.order.Add(10);
                    break;
                case 5:
                    t2.text = "剪刀式   " + d.time2 + "下";
                    missionlist.order.Add(11);
                    break;
            }
            switch (d.mission3)
            {
                case 0:
                    t3.text = "伏地挺身   " + d.time3 + "下";
                    missionlist.order.Add(1);
                    break;
                case 1:
                    t3.text = "開合跳   " + d.time3 + "下";
                    missionlist.order.Add(2);
                    break;
                case 2:
                    t3.text = "仰臥起坐   " + d.time3 + "下";
                    missionlist.order.Add(3);
                    break;
                case 3:
                    t3.text = "波比   " + d.time3 + "組";
                    missionlist.order.Add(4);
                    break;
                case 4:
                    t3.text = "反向卷腹   " + d.time3 + "下";
                    missionlist.order.Add(5);
                    break;
            }
            switch (d.mission4)
            {
                case 0:
                    t4.text = "伏地挺身   " + d.time4 + "下";
                    missionlist.order.Add(1);
                    break;
                case 1:
                    t4.text = "開合跳   " + d.time4 + "下";
                    missionlist.order.Add(2);
                    break;
                case 2:
                    t4.text = "仰臥起坐   " + d.time4 + "下";
                    missionlist.order.Add(3);
                    break;
                case 3:
                    t4.text = "波比   " + d.time4 + "組";
                    missionlist.order.Add(4);
                    break;
                case 4:
                    t4.text = "反向卷腹   " + d.time4 + "下";
                    missionlist.order.Add(5);
                    break;
            }
            t5.text = "平板撐體   " + d.time_for_plane + "秒";
            missionlist.order.Add(0);
        }
        else if (d.day > 10 && d.day <= 15)
        {
            switch (d.mission1)
            {
                case 0:
                    t1.text = "深蹲   " + d.time1 + "下";
                    missionlist.order.Add(6);
                    break;
                case 1:
                    t1.text = "橋式   " + d.time1 + "下";
                    missionlist.order.Add(7);
                    break;
                case 2:
                    t1.text = "無影凳   " + d.time1 + "下";
                    missionlist.order.Add(8);
                    break;
                case 3:
                    t1.text = "弓步   " + d.time1 + "下";
                    missionlist.order.Add(9);
                    break;
                case 4:
                    t1.text = "鳥犬式   " + d.time1 + "下";
                    missionlist.order.Add(10);
                    break;
                case 5:
                    t1.text = "剪刀式   " + d.time1 + "下";
                    missionlist.order.Add(11);
                    break;
            }
            switch (d.mission2)
            {
                case 0:
                    t2.text = "深蹲   " + d.time2 + "下";
                    missionlist.order.Add(6);
                    break;
                case 1:
                    t2.text = "橋式   " + d.time2 + "下";
                    missionlist.order.Add(7);
                    break;
                case 2:
                    t2.text = "無影凳   " + d.time2 + "下";
                    missionlist.order.Add(8);
                    break;
                case 3:
                    t2.text = "弓步   " + d.time2 + "下";
                    missionlist.order.Add(9);
                    break;
                case 4:
                    t2.text = "鳥犬式   " + d.time2 + "下";
                    missionlist.order.Add(10);
                    break;
                case 5:
                    t2.text = "剪刀式   " + d.time2 + "下";
                    missionlist.order.Add(11);
                    break;
            }
            switch (d.mission3)
            {
                case 0:
                    t3.text = "深蹲   " + d.time3 + "下";
                    missionlist.order.Add(6);
                    break;
                case 1:
                    t3.text = "橋式   " + d.time3 + "下";
                    missionlist.order.Add(7);
                    break;
                case 2:
                    t3.text = "無影凳   " + d.time3 + "下";
                    missionlist.order.Add(8);
                    break;
                case 3:
                    t3.text = "弓步   " + d.time3 + "下";
                    missionlist.order.Add(9);
                    break;
                case 4:
                    t3.text = "鳥犬式   " + d.time3 + "下";
                    missionlist.order.Add(10);
                    break;
                case 5:
                    t3.text = "剪刀式   " + d.time3 + "下";
                    missionlist.order.Add(11);
                    break;
            }
            switch (d.mission4)
            {
                case 0:
                    t4.text = "伏地挺身   " + d.time4 + "下";
                    missionlist.order.Add(1);
                    break;
                case 1:
                    t4.text = "開合跳   " + d.time4 + "下";
                    missionlist.order.Add(2);
                    break;
                case 2:
                    t4.text = "仰臥起坐   " + d.time4 + "下";
                    missionlist.order.Add(3);
                    break;
                case 3:
                    t4.text = "波比   " + d.time4 + "組";
                    missionlist.order.Add(4);
                    break;
                case 4:
                    t4.text = "反向卷腹   " + d.time4 + "下";
                    missionlist.order.Add(5);
                    break;
            }
            switch (d.mission5)
            {
                case 0:
                    t5.text = "伏地挺身   " + d.time5 + "下";
                    missionlist.order.Add(1);
                    break;
                case 1:
                    t5.text = "開合跳   " + d.time5 + "下";
                    missionlist.order.Add(2);
                    break;
                case 2:
                    t5.text = "仰臥起坐   " + d.time5 + "下";
                    missionlist.order.Add(3);
                    break;
                case 3:
                    t5.text = "波比   " + d.time5 + "組";
                    missionlist.order.Add(4);
                    break;
                case 4:
                    t5.text = "反向卷腹   " + d.time5 + "下";
                    missionlist.order.Add(5);
                    break;
            }
            t6.text = "平板撐體   " + d.time_for_plane + "秒";
            missionlist.order.Add(0);
        }
        else if (d.day > 15 && d.day <= 20)
        {
            switch (d.mission1)
            {
                case 0:
                    t1.text = "深蹲   " + d.time1 + "下";
                    missionlist.order.Add(6);
                    break;
                case 1:
                    t1.text = "橋式   " + d.time1 + "下";
                    missionlist.order.Add(7);
                    break;
                case 2:
                    t1.text = "無影凳   " + d.time1 + "下";
                    missionlist.order.Add(8);
                    break;
                case 3:
                    t1.text = "弓步   " + d.time1 + "下";
                    missionlist.order.Add(9);
                    break;
                case 4:
                    t1.text = "鳥犬式   " + d.time1 + "下";
                    missionlist.order.Add(10);
                    break;
                case 5:
                    t1.text = "剪刀式   " + d.time1 + "下";
                    missionlist.order.Add(11);
                    break;
            }
            switch (d.mission2)
            {
                case 0:
                    t2.text = "深蹲   " + d.time2 + "下";
                    missionlist.order.Add(6);
                    break;
                case 1:
                    t2.text = "橋式   " + d.time2 + "下";
                    missionlist.order.Add(7);
                    break;
                case 2:
                    t2.text = "無影凳   " + d.time2 + "下";
                    missionlist.order.Add(8);
                    break;
                case 3:
                    t2.text = "弓步   " + d.time2 + "下";
                    missionlist.order.Add(9);
                    break;
                case 4:
                    t2.text = "鳥犬式   " + d.time2 + "下";
                    missionlist.order.Add(10);
                    break;
                case 5:
                    t2.text = "剪刀式   " + d.time2 + "下";
                    missionlist.order.Add(11);
                    break;
            }
            switch (d.mission3)
            {
                case 0:
                    t3.text = "深蹲   " + d.time3 + "下";
                    missionlist.order.Add(6);
                    break;
                case 1:
                    t3.text = "橋式   " + d.time3 + "下";
                    missionlist.order.Add(7);
                    break;
                case 2:
                    t3.text = "無影凳   " + d.time3 + "下";
                    missionlist.order.Add(8);
                    break;
                case 3:
                    t3.text = "弓步   " + d.time3 + "下";
                    missionlist.order.Add(9);
                    break;
                case 4:
                    t3.text = "鳥犬式   " + d.time3 + "下";
                    missionlist.order.Add(10);
                    break;
                case 5:
                    t3.text = "剪刀式   " + d.time3 + "下";
                    missionlist.order.Add(11);
                    break;
            }
            switch (d.mission4)
            {
                case 0:
                    t4.text = "伏地挺身   " + d.time4 + "下";
                    missionlist.order.Add(1);
                    break;
                case 1:
                    t4.text = "開合跳   " + d.time4 + "下";
                    missionlist.order.Add(2);
                    break;
                case 2:
                    t4.text = "仰臥起坐   " + d.time4 + "下";
                    missionlist.order.Add(3);
                    break;
                case 3:
                    t4.text = "波比   " + d.time4 + "組";
                    missionlist.order.Add(4);
                    break;
                case 4:
                    t4.text = "反向卷腹   " + d.time4 + "下";
                    missionlist.order.Add(5);
                    break;
            }
            switch (d.mission5)
            {
                case 0:
                    t5.text = "伏地挺身   " + d.time5 + "下";
                    missionlist.order.Add(1);
                    break;
                case 1:
                    t5.text = "開合跳   " + d.time5 + "下";
                    missionlist.order.Add(2);
                    break;
                case 2:
                    t5.text = "仰臥起坐   " + d.time5 + "下";
                    missionlist.order.Add(3);
                    break;
                case 3:
                    t5.text = "波比   " + d.time5 + "組";
                    missionlist.order.Add(4);
                    break;
                case 4:
                    t5.text = "反向卷腹   " + d.time5 + "下";
                    missionlist.order.Add(5);
                    break;
            }
            t6.text = "平板撐體   " + d.time_for_plane + "秒";
            missionlist.order.Add(0);
        }

        else if (d.day > 21 && d.day <= 25)
        {
            switch (d.mission1)
            {
                case 0:
                    t1.text = "深蹲   " + d.time1 + "下";
                    missionlist.order.Add(6);
                    break;
                case 1:
                    t1.text = "橋式   " + d.time1 + "下";
                    missionlist.order.Add(7);
                    break;
                case 2:
                    t1.text = "無影凳   " + d.time1 + "下";
                    missionlist.order.Add(8);
                    break;
                case 3:
                    t1.text = "弓步   " + d.time1 + "下";
                    missionlist.order.Add(9);
                    break;
                case 4:
                    t1.text = "鳥犬式   " + d.time1 + "下";
                    missionlist.order.Add(10);
                    break;
                case 5:
                    t1.text = "剪刀式   " + d.time1 + "下";
                    missionlist.order.Add(11);
                    break;
            }
            switch (d.mission2)
            {
                case 0:
                    t2.text = "深蹲   " + d.time2 + "下";
                    missionlist.order.Add(6);
                    break;
                case 1:
                    t2.text = "橋式   " + d.time2 + "下";
                    missionlist.order.Add(7);
                    break;
                case 2:
                    t2.text = "無影凳   " + d.time2 + "下";
                    missionlist.order.Add(8);
                    break;
                case 3:
                    t2.text = "弓步   " + d.time2 + "下";
                    missionlist.order.Add(9);
                    break;
                case 4:
                    t2.text = "鳥犬式   " + d.time2 + "下";
                    missionlist.order.Add(10);
                    break;
                case 5:
                    t2.text = "剪刀式   " + d.time2 + "下";
                    missionlist.order.Add(11);
                    break;
            }
            switch (d.mission3)
            {
                case 0:
                    t3.text = "深蹲   " + d.time3 + "下";
                    missionlist.order.Add(6);
                    break;
                case 1:
                    t3.text = "橋式   " + d.time3 + "下";
                    missionlist.order.Add(7);
                    break;
                case 2:
                    t3.text = "無影凳   " + d.time3 + "下";
                    missionlist.order.Add(8);
                    break;
                case 3:
                    t3.text = "弓步   " + d.time3 + "下";
                    missionlist.order.Add(9);
                    break;
                case 4:
                    t3.text = "鳥犬式   " + d.time3 + "下";
                    missionlist.order.Add(10);
                    break;
                case 5:
                    t3.text = "剪刀式   " + d.time3 + "下";
                    missionlist.order.Add(11);
                    break;
            }
            switch (d.mission4)
            {
                case 0:
                    t4.text = "伏地挺身   " + d.time4 + "下";
                    missionlist.order.Add(1);
                    break;
                case 1:
                    t4.text = "開合跳   " + d.time4 + "下";
                    missionlist.order.Add(2);
                    break;
                case 2:
                    t4.text = "仰臥起坐   " + d.time4 + "下";
                    missionlist.order.Add(3);
                    break;
                case 3:
                    t4.text = "波比   " + d.time4 + "組";
                    missionlist.order.Add(4);
                    break;
                case 4:
                    t4.text = "反向卷腹   " + d.time4 + "下";
                    missionlist.order.Add(5);
                    break;
            }
            switch (d.mission5)
            {
                case 0:
                    t5.text = "伏地挺身   " + d.time5 + "下";
                    missionlist.order.Add(1);
                    break;
                case 1:
                    t5.text = "開合跳   " + d.time5 + "下";
                    missionlist.order.Add(2);
                    break;
                case 2:
                    t5.text = "仰臥起坐   " + d.time5 + "下";
                    missionlist.order.Add(3);
                    break;
                case 3:
                    t5.text = "波比   " + d.time5 + "組";
                    missionlist.order.Add(4);
                    break;
                case 4:
                    t5.text = "反向卷腹   " + d.time5 + "下";
                    missionlist.order.Add(5);
                    break;

            }
            switch (d.mission6)
            {
                case 0:
                    t6.text = "伏地挺身   " + d.time6 + "下";
                    missionlist.order.Add(1);
                    break;
                case 1:
                    t6.text = "開合跳   " + d.time6 + "下";
                    missionlist.order.Add(2);
                    break;
                case 2:
                    t6.text = "仰臥起坐   " + d.time6 + "下";
                    missionlist.order.Add(3);
                    break;
                case 3:
                    t6.text = "波比   " + d.time6 + "組";
                    missionlist.order.Add(4);
                    break;
                case 4:
                    t6.text = "反向卷腹   " + d.time6 + "下";
                    missionlist.order.Add(5);
                    break;
            }
            t7.text = "平板撐體   " + d.time_for_plane + "秒";
            missionlist.order.Add(0);
        }
        else if (d.day > 25 && d.day <= 30)
        {
            switch (d.mission1)
            {
                case 0:
                    t1.text = "深蹲   " + d.time1 + "下";
                    missionlist.order.Add(6);
                    break;
                case 1:
                    t1.text = "橋式   " + d.time1 + "下";
                    missionlist.order.Add(7);
                    break;
                case 2:
                    t1.text = "無影凳   " + d.time1 + "下";
                    missionlist.order.Add(8);
                    break;
                case 3:
                    t1.text = "弓步   " + d.time1 + "下";
                    missionlist.order.Add(9);
                    break;
                case 4:
                    t1.text = "鳥犬式   " + d.time1 + "下";
                    missionlist.order.Add(10);
                    break;
                case 5:
                    t1.text = "剪刀式   " + d.time1 + "下";
                    missionlist.order.Add(11);
                    break;
            }
            switch (d.mission2)
            {
                case 0:
                    t2.text = "深蹲   " + d.time2 + "下";
                    missionlist.order.Add(6);
                    break;
                case 1:
                    t2.text = "橋式   " + d.time2 + "下";
                    missionlist.order.Add(7);
                    break;
                case 2:
                    t2.text = "無影凳   " + d.time2 + "下";
                    missionlist.order.Add(8);
                    break;
                case 3:
                    t2.text = "弓步   " + d.time2 + "下";
                    missionlist.order.Add(9);
                    break;
                case 4:
                    t2.text = "鳥犬式   " + d.time2 + "下";
                    missionlist.order.Add(10);
                    break;
                case 5:
                    t2.text = "剪刀式   " + d.time2 + "下";
                    missionlist.order.Add(11);
                    break;
            }
            switch (d.mission3)
            {
                case 0:
                    t3.text = "深蹲   " + d.time3 + "下";
                    missionlist.order.Add(6);
                    break;
                case 1:
                    t3.text = "橋式   " + d.time3 + "下";
                    missionlist.order.Add(7);
                    break;
                case 2:
                    t3.text = "無影凳   " + d.time3 + "下";
                    missionlist.order.Add(8);
                    break;
                case 3:
                    t3.text = "弓步   " + d.time3 + "下";
                    missionlist.order.Add(9);
                    break;
                case 4:
                    t3.text = "鳥犬式   " + d.time3 + "下";
                    missionlist.order.Add(10);
                    break;
                case 5:
                    t3.text = "剪刀式   " + d.time3 + "下";
                    missionlist.order.Add(11);
                    break;
            }
            switch (d.mission4)
            {
                case 0:
                    t4.text = "伏地挺身   " + d.time4 + "下";
                    missionlist.order.Add(1);
                    break;
                case 1:
                    t4.text = "開合跳   " + d.time4 + "下";
                    missionlist.order.Add(2);
                    break;
                case 2:
                    t4.text = "仰臥起坐   " + d.time4 + "下";
                    missionlist.order.Add(3);
                    break;
                case 3:
                    t4.text = "波比   " + d.time4 + "組";
                    missionlist.order.Add(4);
                    break;
                case 4:
                    t4.text = "反向卷腹   " + d.time4 + "下";
                    missionlist.order.Add(5);
                    break;
            }
            switch (d.mission5)
            {
                case 0:
                    t5.text = "伏地挺身   " + d.time5 + "下";
                    missionlist.order.Add(1);
                    break;
                case 1:
                    t5.text = "開合跳   " + d.time5 + "下";
                    missionlist.order.Add(2);
                    break;
                case 2:
                    t5.text = "仰臥起坐   " + d.time5 + "下";
                    missionlist.order.Add(3);
                    break;
                case 3:
                    t5.text = "波比   " + d.time5 + "組";
                    missionlist.order.Add(4);
                    break;
                case 4:
                    t5.text = "反向卷腹   " + d.time5 + "下";
                    missionlist.order.Add(5);
                    break;
            }
            switch (d.mission6)
            {
                case 0:
                    t6.text = "伏地挺身   " + d.time6 + "下";
                    missionlist.order.Add(1);
                    break;
                case 1:
                    t6.text = "開合跳   " + d.time6 + "下";
                    missionlist.order.Add(2);
                    break;
                case 2:
                    t6.text = "仰臥起坐   " + d.time6 + "下";
                    missionlist.order.Add(3);
                    break;
                case 3:
                    t6.text = "波比   " + d.time6 + "組";
                    missionlist.order.Add(4);
                    break;
                case 4:
                    t6.text = "反向卷腹   " + d.time6 + "下";
                    missionlist.order.Add(5);
                    break;
            }
            t7.text = "平板撐體   " + d.time_for_plane + "秒";
            missionlist.order.Add(0);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
