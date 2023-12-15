using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour {

    public static Calculator I;
	public void Awake(){ I = this; }

    public float get_ang_from_2_points_deg (Vector2 _p1, Vector2 _p2){
        Vector2 _dir = _p2 - _p1;
        return Mathf.Atan2 (_dir.y, _dir.x) * Mathf.Rad2Deg;
    }
    
    public float get_ang_from_point_and_mouse (Vector2 _p){
        Vector2 _mousePos = InGameCamera.I.get_mouse_pos (),
                _mousePos_scrn = Input.mousePosition,
                _dir = _mousePos - _p;
        
        return Mathf.Atan2 (_dir.y, _dir.x) * Mathf.Rad2Deg;
    }
    
    public bool is_mouse_left_of_object (InGameObject _go){
        Vector2 _pos = _go.transform.position,
                _mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        return (_mousePos.x <= _pos.x);
    }

    public float get_ang_from_2_points_rad (Vector2 _p1, Vector2 _p2){
        Vector2 _dir = _p2 - _p1;
        return Mathf.Atan2 (_dir.y, _dir.x);
    }

    public Vector2 get_dir_from_2_points (Vector2 _p1, Vector2 _p2){
        Vector2 _ret = _p1 - _p2;
        return _ret;
    }

    public float get_dist_from_2_points (Vector2 _p1, Vector2 _p2){
        return Vector2.Distance (_p1, _p2);
    }

    public Vector2 get_next_point_in_direction (Vector2 _pos, float _ang, float _dist){
        Vector2 _ret = new Vector2 (_pos.x + Mathf.Cos (_ang) * _dist, _pos.y + Mathf.Sin (_ang) * _dist);
        
        return _ret;
    }
}
