using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.SetActive(false);
    }

    public void AboutText()
    {
        if (gameObject.activeSelf)
        {
            gameObject.SetActive(false);
            
        }
        else
        {
            gameObject.SetActive(true);
            
        }
    }

}
