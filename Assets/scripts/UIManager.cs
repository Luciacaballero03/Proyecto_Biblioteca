using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
     public TextMeshProUGUI txt_Score; 
     public TextMeshProUGUI txt_Temporizador;
     public GameObject panelWin;
     public GameObject panelGameOver;

    // Start is called before the first frame update
    void Start()
    {
        UpdateTimer();
    }

    public void UpdateScore (int score) {
        txt_Score.text = "Score: " + score;
        }

    public void UpdateTimer () {
    if (GameManager.timer < 0)
        {
            GameManager.timer = 0;
        }
        txt_Temporizador.text = "Temporizador: " + GameManager.timer.ToString("F2");
    } 

    public void MostrarPantallaWin(){
        panelWin.SetActive(true);
    }

    public void MostrarPantallaGameOver(){
        panelGameOver.SetActive(true);
    }
}
