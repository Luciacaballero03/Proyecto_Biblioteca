using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionArea : MonoBehaviour
{
    public int objetosRecolectados = 0;

    void OnTriggerEnter (Collider col) {
    if (col.gameObject.CompareTag ("Coleccionable")){
        objetosRecolectados++;
        Debug.Log("Has recolectado " + objetosRecolectados + " discos");
        Destroy(col.gameObject);
    }
    }
}
