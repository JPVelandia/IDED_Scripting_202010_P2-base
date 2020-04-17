using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHit : Command
{
    public void execute(GameObject player)
    {
        Debug.Log("Actor--->" + player.name + "Cmd ---> Hit");
        //throw new System.NotImplementedException();
    }
}
