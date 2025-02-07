using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CasillasManager : MonoBehaviour
{
    private const int TOTAL_CASILLAS = 4;

    public static CasillasManager casillasManager;

    private GameObject[] Casillas;

    // Start is called before the first frame update
    void Start()
    {
        Casillas = new GameObject[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            Casillas[i] = transform.GetChild(i).gameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        casillasManager = this;
    }

    public int GetTotalCasillas()
    {
        return TOTAL_CASILLAS;
    }

    public GameObject GetCasilla(int numCasilla)
    {
        return Casillas.FirstOrDefault(casilla => casilla.GetComponent<CasillaLogic>().GetNumCasilla() == numCasilla);
    }
}
