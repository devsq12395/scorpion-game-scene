using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class InGameEffect : MonoBehaviour
{
    public string mode; 
    // 'anim' - kill on anim end
    // 'timed' - kill after time
    // 'doodad' - stays forever

    public float timeLimit;

    private Renderer renderer;
    
    void Start() {
        // _start ();

        renderer = GetComponent <Renderer> ();
    }

    void Update() {
        if (mode == "time"){
            timeLimit -= Time.deltaTime;
            if (timeLimit <= 0) {
                Destroy (gameObject);
            }
        }

        update_render ();
    }

    public void destroy_game_object () {
        // Used by Unity animator
        Destroy (gameObject);
    }

    private void update_render (){
        if (Vector2.Distance(transform.position, Camera.main.transform.position) > GameConstants.RENDER_DIST) {
            renderer.enabled = false;
        } else {
            renderer.enabled = true;
        }
    }
}
