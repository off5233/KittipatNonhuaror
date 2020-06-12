using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpCode : MonoBehaviour
{
   public GameObject player;
   public float GX, GY, GZ;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "player")
        {
            if (Input.GetKeyDown("e"))
            {
                {
                    player.transform.position = new Vector3(GX, GY, GZ);
                }
            }

        }

    }
}
