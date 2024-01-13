using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI_Zombie : InGameAI {


    private Vector2 randPoint;
    public override void on_start (){
        
    }
    public override void on_update (){
        InGameObject _p = ContPlayer.I.player;
        Vector2 _pPos = _p.gameObject.transform.position;

        if (CheckLineOfSight(_pPos, goPos)) {
            ContObj.I.move_walk_to_pos (inGameObj, _pPos);
        } else {
            pathfinding (_p, _pPos);
        }
        
    }

    private void pathfinding(InGameObject _p, Vector2 _pPos) {
        Vector2 playerDirection = (_pPos - goPos).normalized;

        for (float angle = -1f; angle <= 1f; angle += 1f) {
            Vector2 _dir = Quaternion.Euler(0, 0, angle) * playerDirection;
            RaycastHit2D hit = Physics2D.Raycast(goPos, _dir, 10f);

            if (hit.collider == null) {
                ContObj.I.move_walk_to_pos (inGameObj, Calculator.I.get_pos_on_dist (angle, 200));
                break;
            }
        }
    }

    private bool CheckLineOfSight(Vector2 from, Vector2 to) {
        RaycastHit2D hit = Physics2D.Linecast(from, to, LayerMask.GetMask("Collider"));
        return hit.collider == null;
    }

}
