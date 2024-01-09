using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DB_Objects : MonoBehaviour {

    public static DB_Objects I;
	public void Awake(){ I = this; }

    public GameObject dummy;

    // Units
    public GameObject hero, samurai, greenSlime, orcShaman, kitsune;

    // Missiles
    public GameObject testMissile1, beam1, kitsuneMissile, molotovMsl;

    // Effects
    public GameObject explosion1, explosion1_mini, molotovEfct, bindChainExp1, bindChainExp2;
    public GameObject damTxt;
    
    // Buffs
    public GameObject buf_burn, buf_bindingChains;

    void Start() {
        
    }

    void Update() {
        
    }

    public GameObject get_game_obj (string _name) {
        GameObject _refObj = GameObject.Instantiate(dummy, new Vector3(0, 0, 0), Quaternion.Euler(new Vector3(0, 0, 0))) as GameObject;
        Destroy (_refObj);
        
        switch (_name) {
            // Player
            case "hero":                    _refObj = hero; break;
            case "samurai":                 _refObj = samurai; break;

            // Enemies
            case "greenSlime":              _refObj = greenSlime; break;
            case "orcShaman":               _refObj = orcShaman; break;
            case "kitsune":                 _refObj = kitsune; break;

            // Missiles
            case "testMissile1":            _refObj = testMissile1; break;
            case "SampleAssist_Missile":    _refObj = testMissile1; break;
            case "beam1":                   _refObj = beam1; break;
            case "kitsuneMissile":          _refObj = kitsuneMissile; break;
            case "molotovMsl":              _refObj = molotovMsl; break;

            // Effects
            case "explosion1":              _refObj = explosion1; break;
            case "explosion1_mini":         _refObj = explosion1_mini; break;
            case "molotovEfct":             _refObj = molotovEfct; break;
            case "bindChainExp1":             _refObj = bindChainExp1; break;
            case "bindChainExp2":             _refObj = bindChainExp2; break;
                
            case "damTxt":                  _refObj = damTxt; break;
                
            // Buffs
            case "buffAtch_burn":                       _refObj = burn; break;
            case "buffAtch_binding-chains":             _refObj = buf_bindingChains; break;

            default: _refObj = dummy; break;
        }

        GameObject _retVal = GameObject.Instantiate(_refObj, new Vector3(0, 0, 0), Quaternion.Euler(new Vector3(0, 0, 0))) as GameObject; 
        return _retVal;
    }
}
