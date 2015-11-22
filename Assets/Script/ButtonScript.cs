using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnClickPlay()
    {
        Application.LoadLevel("Game");
    }

    public void OnClickExit()
    {
        Application.Quit();
    }
}
