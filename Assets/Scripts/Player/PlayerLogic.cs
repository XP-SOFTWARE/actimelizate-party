using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLogic : MonoBehaviour
{
    private int casillaActual = 0;

    private int casillaDestino;

    private int casillasLeft;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Posición inicial: " + transform.position);
        casillasLeft = CasillasManager.casillasManager.GetTotalCasillas();
    }

    // Update is called once per frame
    void Update()
    {
        if(casillasLeft != 0) {
            if(Input.GetKeyDown(KeyCode.Space)) {;
                Debug.Log("Casilla actual: " + casillaActual);
                moveToCasilla(Mathf.Min(Random.Range(1, 7), casillasLeft));
            } 
        }
    }

    public void moveToCasilla(int numCasillas) {
        CasillasManager casillasManager = CasillasManager.casillasManager;
        int totalCasillas = casillasManager.GetTotalCasillas();
        casillasLeft = totalCasillas - numCasillas;
        casillaActual += numCasillas;
        transform.position = new Vector3(casillasManager.GetCasilla(casillaActual).transform.position.x,
                                        casillasManager.GetCasilla(casillaActual).transform.position.y + 1,
                                        casillasManager.GetCasilla(casillaActual).transform.position.z);
        Debug.Log("Casilla actual: " + casillaActual);
    }
}
