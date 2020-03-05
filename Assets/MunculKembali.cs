using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MunculKembali : MonoBehaviour {

    private BoxCollider2D collider;
    private float HorizontalLength;

	// Use this for initialization
	void Start () {
        collider = GetComponent<BoxCollider2D>();
        HorizontalLength = collider.size.x;
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.x < -HorizontalLength)
        {
            Pindah();
        }
	}
    void Pindah()
    {
        Vector2 offset = new Vector2(HorizontalLength * 2, 0);
        transform.position = (Vector2)transform.position + offset;
    }
}
