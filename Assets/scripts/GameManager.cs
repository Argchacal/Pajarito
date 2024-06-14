using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverText;
    public bool isGameOver;
    public int score;
    //referenciamos al texto de la interface. 
    [SerializeField] private TMP_Text scoreText;
    private static GameManager instance;
    
    public static GameManager Instance
    
    {
        get{return instance;}
    }

    private void Awake() 
    {
        if (instance == null){
            instance = this;
        }
        else{
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && isGameOver)
        {
            RestarGame();
        }
    }
    public void RestarGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void GameOver()
    {
        isGameOver = true;
        gameOverText.SetActive(true);
    } 

    public void incleaseScore()
    {
        score++;
        //ahora mostramos el texto. score.ToString() Convierte el int a string
        scoreText.text = score.ToString();
    }
}
