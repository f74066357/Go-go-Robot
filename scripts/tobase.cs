﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class tobase : MonoBehaviour, IPointerClickHandler
{

    public void OnPointerClick(PointerEventData e)
    {
        Debug.Log("to base");
        SceneManager.LoadScene(2);
    }
}
