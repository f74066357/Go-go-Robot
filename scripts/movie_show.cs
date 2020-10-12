using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Video;

[RequireComponent(typeof(AudioSource))]//必須要有AudioSource，任何加上此腳本的物件將自動加入AudioSource
public class movie_show : MonoBehaviour
{

    public VideoPlayer v;


    void Start()
    {
        v.Play();
    }

}