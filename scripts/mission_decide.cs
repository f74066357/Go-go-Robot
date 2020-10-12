using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
public class mission_decide : MonoBehaviour {
    public int day =3;
    // Use this for initialization
    public int mission_num;
    public int mission1;
    public int mission2;
    public int mission3;
    public int mission4;
    public int mission5;
    public int mission6;
    public int time1;
    public int time2;
    public int time3;
    public int time4;
    public int time5;
    public int time6;
    public int time_for_plane;//平板
    public int x = 0;
    public int y = 0;
    public int z = 0;
    public int k = 0;
    public int m = 0;
    public int n = 0;
    public Text t;
    public int[] GetRandomSequence(int total, int n)
    {
        int[] sequence = new int[total];
        int[] output = new int[n];
        for (int i = 0; i < total; i++)
        {
            sequence[i] = i;
        }
        int end = total - 1;
        for (int i = 0; i < n; i++)
        {
            int num = Random.Range(0, end + 1);
            output[i] = sequence[num];
            sequence[num] = sequence[end];
            end--;
        }
        return output;
    }

    void Start()
    {
        
            if (day <= 5)
            {
                mission_num = 4;
                //1.中強度運動隨機兩項， 各做5下
                int[] seq = new int[6];
                seq = GetRandomSequence(6, 2);
                x = seq[0];
                y = seq[1];
                mission1 = x;
                mission2 = y;
                time1 = 5;
                time2 = 5;
                //2.高強度運動隨機一項
                z = Random.Range(0, 4);
                mission3 = z;
                switch (z)
                {
                    case 0://伏地挺身
                        time3 = 4;
                        break;
                    case 1://開合跳 
                        time3 = 20;
                        break;
                    case 2://仰臥起坐
                        time3 = 15;
                        break;
                    case 3://波比
                        time3 = 8;
                        break;
                    case 4://反向卷腹
                        time3 = 15;
                        break;
                }
                time_for_plane = 25;
            }
            else if (day > 5 && day <= 10)
            {
                Debug.Log("5~10");
                mission_num = 5;
                //1.中強度運動隨機兩項， 各做5下
                int[] seq = new int[6];
                seq = GetRandomSequence(6, 2);
                x = seq[0];
                y = seq[1];
                mission1 = x;
                mission2 = y;
                time1 = 5;
                time2 = 5;
                //2.高強度運動隨機兩項
                int[] seq2 = new int[5];
                seq2 = GetRandomSequence(5, 2);
                x = seq2[0];
                y = seq2[1];
                z = Random.Range(0, 4);
                k = Random.Range(0, 4);
                mission3 = z;
                mission4 = k;
                switch (z)
                {
                    case 0://伏地挺身
                        time3 = 6;
                        break;
                    case 1://開合跳 
                        time3 = 30;
                        break;
                    case 2://仰臥起坐
                        time3 = 25;
                        break;
                    case 3://波比
                        time3 = 8;
                        break;
                    case 4://反向卷腹
                        time3 = 25;
                        break;
                }
                switch (k)
                {
                    case 0://伏地挺身
                        time4 = 6;
                        break;
                    case 1://開合跳 
                        time4 = 30;
                        break;
                    case 2://仰臥起坐
                        time4 = 25;
                        break;
                    case 3://波比
                        time4 = 8;
                        break;
                    case 4://反向卷腹
                        time4 = 25;
                        break;
                }
                time_for_plane = 30;
            }

            else if (day > 10 && day <= 15)
            {
                Debug.Log("10~15");
                mission_num = 6;
                //1.中強度運動隨機三項， 各做10下
                int[] seq = new int[6];
                seq = GetRandomSequence(6, 3);
                x = seq[0];
                y = seq[1];
                z = seq[2];
                mission1 = x;
                mission2 = y;
                mission3 = z;
                time1 = 10;
                time2 = 10;
                time3 = 10;
                //2.高強度運動隨機兩項
                int[] seq2 = new int[5];
                seq2 = GetRandomSequence(5, 2);
                m = seq2[0];
                n = seq2[1];
                mission4 = m;
                mission5 = n;
                switch (m)
                {
                    case 0://伏地挺身
                        time4 = 6;
                        break;
                    case 1://開合跳 
                        time4 = 35;
                        break;
                    case 2://仰臥起坐
                        time4 = 30;
                        break;
                    case 3://波比
                        time4 = 10;
                        break;
                    case 4://反向卷腹
                        time4 = 30;
                        break;
                }
                switch (n)
                {
                    case 0://伏地挺身
                        time5 = 6;
                        break;
                    case 1://開合跳 
                        time5 = 35;
                        break;
                    case 2://仰臥起坐
                        time5 = 30;
                        break;
                    case 3://波比
                        time5 = 10;
                        break;
                    case 4://反向卷腹
                        time5 = 30;
                        break;
                }
                time_for_plane = 35;

            }
            else if (day > 15 && day <= 20)
            {
                Debug.Log("15~20");
                mission_num = 6;
                //1.中強度運動隨機三項， 各做15下
                int[] seq = new int[6];
                seq = GetRandomSequence(6, 3);
                x = seq[0];
                y = seq[1];
                z = seq[2];
                mission1 = x;
                mission2 = y;
                mission3 = z;
                time1 = 15;
                time2 = 15;
                time3 = 15;
                //2.高強度運動隨機兩項
                int[] seq2 = new int[5];
                seq2 = GetRandomSequence(5, 2);
                m = seq2[0];
                n = seq2[1];
                mission4 = m;
                mission5 = n;
                switch (m)
                {
                    case 0://伏地挺身
                        time4 = 8;
                        break;
                    case 1://開合跳 
                        time4 = 40;
                        break;
                    case 2://仰臥起坐
                        time4 = 35;
                        break;
                    case 3://波比
                        time4 = 10;
                        break;
                    case 4://反向卷腹
                        time4 = 35;
                        break;
                }
                switch (n)
                {
                    case 0://伏地挺身
                        time5 = 8;
                        break;
                    case 1://開合跳 
                        time5 = 40;
                        break;
                    case 2://仰臥起坐
                        time5 = 35;
                        break;
                    case 3://波比
                        time5 = 10;
                        break;
                    case 4://反向卷腹
                        time5 = 35;
                        break;
                }
                time_for_plane = 40;

            }
            else if (day > 20 && day <= 25)
            {
                Debug.Log("21~25");
                mission_num = 7;
                //1.中強度運動隨機三項， 各做20下
                int[] seq = new int[6];
                seq = GetRandomSequence(6, 3);
                x = seq[0];
                y = seq[1];
                z = seq[2];
                mission1 = x;
                mission2 = y;
                mission3 = z;
                time1 = 20;
                time2 = 20;
                time3 = 20;
                //2.高強度運動隨機三項
                int[] seq2 = new int[5];
                seq2 = GetRandomSequence(5, 3);
                m = seq2[0];
                n = seq2[1];
                k = seq2[2];
                mission4 = m;
                mission5 = n;
                mission6 = k;
                switch (m)
                {
                    case 0://伏地挺身
                        time4 = 8;
                        break;
                    case 1://開合跳 
                        time4 = 50;
                        break;
                    case 2://仰臥起坐
                        time4 = 35;
                        break;
                    case 3://波比
                        time4 = 10;
                        break;
                    case 4://反向卷腹
                        time4 = 35;
                        break;
                }
                switch (n)
                {
                    case 0://伏地挺身
                        time5 = 8;
                        break;
                    case 1://開合跳 
                        time5 = 50;
                        break;
                    case 2://仰臥起坐
                        time5 = 35;
                        break;
                    case 3://波比
                        time5 = 10;
                        break;
                    case 4://反向卷腹
                        time5 = 35;
                        break;
                }
                switch (k)
                {
                    case 0://伏地挺身
                        time6 = 8;
                        break;
                    case 1://開合跳 
                        time6 = 50;
                        break;
                    case 2://仰臥起坐
                        time6 = 35;
                        break;
                    case 3://波比
                        time6 = 10;
                        break;
                    case 4://反向卷腹
                        time6 = 35;
                        break;
                }
                time_for_plane = 50;
            }
            else if (day > 25 && day <= 30)
            {
                Debug.Log("25~30");
                mission_num = 7;
                //1.中強度運動隨機三項， 各做30下
                int[] seq = new int[6];
                seq = GetRandomSequence(6, 3);
                x = seq[0];
                y = seq[1];
                z = seq[2];
                mission1 = x;
                mission2 = y;
                mission3 = z;
                time1 = 30;
                time2 = 30;
                time3 = 30;
                //2.高強度運動隨機三項
                int[] seq2 = new int[5];
                seq2 = GetRandomSequence(5, 3);
                m = seq2[0];
                n = seq2[1];
                k = seq2[2];
                mission4 = m;
                mission5 = n;
                mission6 = k;
                switch (m)
                {
                    case 0://伏地挺身
                        time4 = 10;
                        break;
                    case 1://開合跳 
                        time4 = 50;
                        break;
                    case 2://仰臥起坐
                        time4 = 40;
                        break;
                    case 3://波比
                        time4 = 10;
                        break;
                    case 4://反向卷腹
                        time4 = 40;
                        break;
                }
                switch (n)
                {
                    case 0://伏地挺身
                        time5 = 10;
                        break;
                    case 1://開合跳 
                        time5 = 50;
                        break;
                    case 2://仰臥起坐
                        time5 = 40;
                        break;
                    case 3://波比
                        time5 = 10;
                        break;
                    case 4://反向卷腹
                        time5 = 40;
                        break;
                }
                switch (k)
                {
                    case 0://伏地挺身
                        time6 = 10;
                        break;
                    case 1://開合跳 
                        time6 = 50;
                        break;
                    case 2://仰臥起坐
                        time6 = 40;
                        break;
                    case 3://波比
                        time6 = 10;
                        break;
                    case 4://反向卷腹
                        time6 = 40;
                        break;
                }
                time_for_plane = 60;
            }
        }
    
 
	// Update is called once per frame
	void Update () {
        if (finish.f == true)
        {
            t.text = "已完成";
        }
    }
}
