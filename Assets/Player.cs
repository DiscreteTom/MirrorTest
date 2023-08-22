using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Player : NetworkBehaviour
{
    void Start()
    {
        var nt = this.GetComponent<NetworkTransformReliable>();
        if (this.isOwned)
            nt.CmdTeleport(new Vector3(0, 1.5f, 0));
    }
}
