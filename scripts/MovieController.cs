using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Video;

[RequireComponent(typeof(AudioSource))]//必須要有AudioSource，任何加上此腳本的物件將自動加入AudioSource
public class MovieController : MonoBehaviour
{

    public VideoPlayer v;


    void Start()
    {
        v.Play();
    }


    void Update()
    {
        StartCoroutine(LoadScene());
    }

    IEnumerator LoadScene()
    {
        yield return new WaitForSeconds(6f);//括號內填入影片時間
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);//載入場景
    }
}
