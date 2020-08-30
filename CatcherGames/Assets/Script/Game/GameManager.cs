using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    public int lives;
    [SerializeField]
    protected GameObject candy;
    [SerializeField]
    protected GameObject candyPos;
    [SerializeField]
    protected GameObject scoreBoard;
    [SerializeField]
    protected GameObject GameOverPanel;
    public GameObject liveObject;
    public bool gameOver = false;
    public int score = 0;

    public static GameManager MAID;
    

    private void Awake()
    {
        MAID = this;
    }
    void Start()
    {
        MAID.lives = lives;
        MAID.score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        liveObject.GetComponent<Text>().text = string.Format("{0}", MAID.lives);
        scoreBoard.GetComponent<Text>().text = string.Format("{0}", MAID.score);
        if(MAID.lives < 1)
        {
            gameOverFun();
        }
            
    }

    void gameOverFun()
    {
        MAID.gameOver = true;
        GameOverPanel.SetActive(true);
    }

    [System.Obsolete]
    public void Restart()
    {
        Application.LoadLevel(Application.loadedLevel);
        //GameObject playerScene = GameObject.Find("Player/Player");
        //playerScene.transform.position = new Vector3(0, playerScene.transform.position.y, playerScene.transform.position.z);
        //MAID.lives = 3;
        //MAID.score = 0;
        //GameOverPanel.SetActive(false);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
