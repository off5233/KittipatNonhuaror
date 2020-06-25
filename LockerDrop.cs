using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LockerDrop : MonoBehaviour
{

    public GameObject player;

   public Animator chestAnimator;



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
            chestAnimator.SetBool("chackplayer", true);

            if (Input.GetKeyDown("e"))
            {
                player.transform.position = new Vector3(250, player.transform.position.y, player.transform.position.z);

            }

        }
    }
}
