using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class dropdownforfinish : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject.Find("Dropdown").GetComponent<Dropdown>().onValueChanged.AddListener(ConsoleResult);
    }
    public void ConsoleResult(int value)
    {
        switch (value)
        {
            case 0:
                break;
            case 1:
                Destroy(GameObject.FindWithTag("today"));
                Debug.Log("2 today");
                SceneManager.LoadScene(2);
                break;
            case 2:
                SceneManager.LoadScene(3);
                Debug.Log("3");
                break;
            case 3:
                SceneManager.LoadScene(4);
                Debug.Log("4");
                break;
        }
    }		
}

