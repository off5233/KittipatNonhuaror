using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class qITEMC : MonoBehaviour
{
    public GameObject ITEM1;
    public GameObject ITEM1_2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown()
    {
        Qitem.checkQuit = 0;
        ITEM1.SetActive(false); 
        ITEM1_2.SetActive(false);
    }
}
