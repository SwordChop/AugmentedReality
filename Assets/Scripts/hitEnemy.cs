﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hitEnemy : MonoBehaviour {


	// Use this for initialization
	void Start () {
        //...
	}//start
	
	// Update is called once per frame
	void Update () {
		//...
	}//update

    void OnTriggerEnter (Collider colBox) {
        
        //if the owner of the collider box is an enemy destroy it
        if(colBox.gameObject.tag == "Enemy") {
        
            //instantiate an explosion when a bullet hits an enemy
            GameObject explode = Instantiate(Resources.Load("FlareMobile", typeof(GameObject))) as GameObject;
            explode.transform.position = transform.position;        //spawn it at the enemies current position
            Destroy(colBox.gameObject);                             //destroy the object attached to the collision box the laser hit
            Destroy(explode, 3);                                    //remove the explosion after 3 seconds to free up memory

            Destroy(gameObject);

            
        }//if

    }//on trugger enter

}//class
