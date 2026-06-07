using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static float timer = 60f;
    public UIManager uiManag;

    // Start is called before the first frame update
    void Start()
    {
        uiManag = Object.FindObjectOfType<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
            timer -= Time.deltaTime;
            uiManag.UpdateTimer();

    }
}
