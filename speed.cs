using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speed : MonoBehaviour
{
    public float speedd = 10;
    public float point = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision Des)
    {
        if (Des.gameObject.name == "Wall")
        {
            Destroy(gameObject);
            point = point + 1;

        }
    }
}
