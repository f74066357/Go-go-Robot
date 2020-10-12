using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Video;
[RequireComponent(typeof(AudioSource))]//必須要有AudioSource，任何加上此腳本的物件將自動加入AudioSource

public class movieLoop : MonoBehaviour {
    public VideoPlayer v;
    // Use this for initialization
    void Start () {
        v.Play();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
