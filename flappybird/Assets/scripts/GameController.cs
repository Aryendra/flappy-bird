using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameController : MonoBehaviour
{
    public static GameController instance;
    public GameObject gameOverText;
    public Text scoretext;
    public bool gameOver = false;
    public float scrollSpeed = -1.5f;
    public int score =0;

    // Start is called before the first frame update
    void Awake()
    {
        if(instance==null)
        {
            instance = this;

        }
        else if(instance!=null)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver==true && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    public void birdscored()
    {
        if(gameOver)
        {
            return;
        }
        score++;
        scoretext.text = "score: " + score.ToString();
    }
    public void BirdDied()
    {
        gameOverText.SetActive(true);
        gameOver = true;

    }
}
