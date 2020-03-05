using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject pipa;
    private float timer = 2f;
    private float timeNow = 1f;
	
	// Update is called once per frame
	private void Update () {
        if (GameManager.Instance.isGameover)
        {
            return;
        }
        if(timeNow <= 0)
        {
            Spawn();
            timeNow = timer;
        }
        else
        {
            timeNow -= Time.deltaTime;
        }
	}
    void Spawn()
    {
        float gacha = Random.RandomRange(-1.5f, 2.5f);
        Instantiate(pipa, new Vector2(transform.position.x+2f, gacha), Quaternion.identity);
    }
}
