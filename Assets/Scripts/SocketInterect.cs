using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocketInterect : MonoBehaviour
{
    public GameObject door;
    private Animator anim;
    void Start()
    {
        anim = door.GetComponent<Animator>();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision:");
        Debug.Log(other.name);
        if (other.name == "key")
        {
            anim.SetTrigger("DoorOpen");
        }
    }
    //void OnTriggerExit(Collider other)
    //{
    //    Debug.Log("Collision:");
    //    Debug.Log(other.name);
    //    if (other.name == "key")
    //    {
    //        anim.SetTrigger("DoorClosed");
    //    }
    //}
}