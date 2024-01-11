using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

public class GameControler : MonoBehaviour
{
    
    bool endgame;
    bool start=true;
    int point = 0;
    public Text text;
    public GameObject gameover;
    public Text txtPoint;
    public Button btnrestart;
    // Start is called before the first frame update
    void Start()
    {
        endgame = false;
        gameover.SetActive(false);
        start = true;


    }

    // Update is called once per frame
    void Update()
    {
        if (endgame)
        {
           
            
            if (Input.GetMouseButtonDown(0)&&start)
            {
                StartGame();
            }
        }
        else
        {

            if (Input.GetMouseButtonDown(0))
            {
                
                Time.timeScale = 1;
            }
        }
        
    }
    public void PlusPointPigBig()
    {
        point++;
        point++;
        text.text = "Điểm: "+point.ToString();
    }
    public void PlusPointPiig()
    {
        point++;
        text.text = "Điểm: " + point.ToString();
    }

    public void EndGame()
    {
        start=false;
        endgame = true;
        gameover.SetActive(true);
        txtPoint.text = "Điểm Của Bạn\n" + point.ToString();
        Time.timeScale = 0;
        
    }
    public void Restart()
    {
        StartGame();
    }
    void StartGame()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
