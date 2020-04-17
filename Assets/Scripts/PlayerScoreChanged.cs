using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScoreChanged : Command
{
    public void execute(GameObject player)
    {
        Debug.Log("Actor--->" + player.name + "Cmd ---> ScoreChanged");
        //throw new System.NotImplementedException();
    }
}
