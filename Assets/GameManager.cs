using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static GameManager Instance;
    public float scroll = -1.5f;
    public bool isGameover = false;
    private int score = 0;

    public GameObject GameoverText;
    public Text scoretext;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this) {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    public void Update() {

    }

    public void Scoree()
    {
        if (isGameover) {
            return;
        }
        score++;
        scoretext.text = "" + score;
    }
    public void Die()
    {
        isGameover = true;
        GameoverText.SetActive(true);
    }
}
