using UnityEngine;
using System.Collections;

public class EnemySpawnerScript : MonoBehaviour {

    public float delay = 1f;
    public float lastSpawn = 0f;
    public GameObject enemy;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Time.time - lastSpawn >= delay)
        {
            SpawnEnemy();
            lastSpawn = Time.time;
        }
	}

    void SpawnEnemy()
    {
        float x = 0, y = 0;
        float minX = (Screen.width - Screen.height) / 2;
        float maxX = minX + Screen.height;
        switch (Random.Range(0, 3))
        {
            case 0:
                x = Random.Range(minX, maxX);
                y = Screen.height;
                Debug.Log("Spawn at North");
                break;
            case 1:
                x = maxX;
                y = Random.Range(0, Screen.height);
                Debug.Log("Spawn at East");
                break;
            case 2:
                x = Random.Range(minX, maxX);
                y = 0;
                Debug.Log("Spawn at South");
                break;
            case 3:
                x = minX;
                y = Random.Range(0, Screen.height);
                Debug.Log("Spawn at West");
                break;
        }
        Instantiate(enemy, Camera.main.ScreenToWorldPoint(new Vector3(x, y, Camera.main.WorldToScreenPoint(Vector3.zero).z)), new Quaternion());
    }
}
