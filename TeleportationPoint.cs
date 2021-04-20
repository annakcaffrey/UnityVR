using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class TeleportationPoint : MonoBehaviour

{

    public GameObject cameraRig; //creates a reference for the cameraRig - the player who wants to be teleported

    //The teleport method moves the cameraRig to the current position of whatever object the script is attached to

    public void Teleport(){

        //Here I want to alter the position of player (aka cameraRig)

        //So im changing the position of it to the position of Vector3

        cameraRig.transform.position = new Vector3(transform.position.x, 

                                                    transform.position.y + 2f,

                                                    transform.position.z);

    }

   

}
