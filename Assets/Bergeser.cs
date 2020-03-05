using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bergeser : MonoBehaviour {

    private Rigidbody2D badan;

	// Use this for initialization
	void Start () {
        badan = GetComponent<Rigidbody2D>();
        badan.velocity = new Vector2(GameManager.Instance.scroll, 0);
	}
	
	// Update is called once per frame
	void Update () {
        if (GameManager.Instance.isGameover)
        {
            badan.velocity = Vector2.zero;
        }
	}
}
