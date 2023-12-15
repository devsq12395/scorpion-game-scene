using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameAI : MonoBehaviour {

    public InGameObject inGameObj;
    public bool isReady;

    public int state = 0;
    public float stateTime = 0f;

    void Start (){
        inGameObj = gameObject.GetComponent <InGameObject> ();

        on_start ();
    }

    void Update (){
        if (!isReady) {
            on_ready ();
            isReady = true;
        }

        on_update ();
    }

    public virtual void on_start (){

    }

    public virtual void on_update (){

    }

    public virtual void on_ready (){
        
    }
}
