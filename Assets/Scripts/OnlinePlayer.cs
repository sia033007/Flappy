using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class OnlinePlayer : NetworkBehaviour
{
    [SerializeField]
    private Vector3 movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    [Client]

    // Update is called once per frame
    void Update()
    {
        if(hasAuthority){
             if(Input.GetKey(KeyCode.Space)){
                 CmdMove();           
        }

        }     
    }
    [Command]
    private void CmdMove(){
        RpcMove();
    }
    [ClientRpc]
    private void RpcMove(){
        transform.Translate(movement);

    }
}
