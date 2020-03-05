using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burung : MonoBehaviour {

    public float tenaga = 200f;
    public bool isDead = false;

    private Animator anim;
    private Rigidbody2D ridgy;

	// Use this for initialization
	void Start () {
        ridgy = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (isDead)
        {
            return;
        }
        if (Input.GetMouseButtonDown(0))
        {
            ridgy.velocity = Vector2.zero;
            ridgy.AddForce(new Vector2(0, tenaga));
            anim.SetTrigger("Terbang");
        }
	}
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.Instance.Die();
        anim.SetTrigger("Mati");
        isDead = true;
    }
}
