using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CameraSwap : NetworkBehaviour {

    public Camera FpsCam;
    public Camera TpsCam;
    bool tpsCam = true;

	// Use this for initialization
	void Start () {
        FpsCam.enabled = !tpsCam;
        TpsCam.enabled = tpsCam;
	}
	
	// Update is called once per frame
    [ClientCallback]
	void Update () {
        if (isLocalPlayer == true)
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                tpsCam = !tpsCam;
                FpsCam.enabled = tpsCam;
                TpsCam.enabled = !tpsCam;
            }
        }
            
	}
}
