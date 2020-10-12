using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class totoday : MonoBehaviour, IPointerClickHandler
{

    public void OnPointerClick(PointerEventData e)
    {
        Debug.Log("totoday");
        Destroy(GameObject.FindWithTag("today"));
        SceneManager.LoadScene(2);
        
    }
}