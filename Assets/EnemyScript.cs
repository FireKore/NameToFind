using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

    public float speed = 0.5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(new Vector3(-this.transform.position.normalized.x, this.transform.position.normalized.y) * speed * Time.deltaTime);
	}
}
