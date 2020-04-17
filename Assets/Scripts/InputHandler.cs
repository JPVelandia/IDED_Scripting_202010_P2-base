using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler 
{
    private Command CmdScoreChanged, CmdrDied, CmdHit;

    public Command HandleInput()
    {
        if (Target/*.*/ )
        {
            return CmdScoreChanged;
        }
        if (/*Player != null*/  )
        {
            return CmdrDied;
        }
        if (/*Player != null*/  )
        {
            return CmdHit;
        }
        return null;
    }

}
