using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static float timer = 60f;
    public UIManager uiManag;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        uiManag = Object.FindObjectOfType<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
            timer -= Time.deltaTime;
            uiManag.UpdateTimer();

             if (timer <= 0){
                timer = 0;
                uiManag.MostrarPantallaGameOver();
                Time.timeScale = 0;
            }

            if (Input.GetKeyDown(KeyCode.R)){
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }

    }
}
