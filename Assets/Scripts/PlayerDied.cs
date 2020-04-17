using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDied : Command
{
    public void execute(GameObject player)
    {
        Debug.Log("Actor--->" + player.name + "Cmd ---> Died");
        //throw new System.NotImplementedException();
    }
}
