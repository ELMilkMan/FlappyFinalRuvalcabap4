using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public GameObject gameOverText;
    public TextMeshProUGUI scoreText;
    public bool gameOver = false;
    
    public float scrollSpeed = 1.5f;

    private int score = 0;

    // Start is called before the first frame update
    void Awake ()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver == true && Input.GetMouseButtonDown (0))
        {
            SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
        }
    }

    public void BirdScored()
    {
        if (gameOver)
        {
            return;
        }
        score++;
        scoreText.text = "score: " + score.ToString ();
    }

        public void BirdDied()
        {
        gameOverText.SetActive(true);
        gameOver = true;
        }
        
    }

