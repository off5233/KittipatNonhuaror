using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Moveto1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision MoveSc2)
    {
        if (MoveSc2.gameObject.name == "player")
        {
            SceneManager.LoadScene("s1");
        }
    }
}
