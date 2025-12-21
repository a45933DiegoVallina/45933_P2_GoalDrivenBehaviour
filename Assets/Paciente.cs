using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paciente : GAgent
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        SubGoal s1 = new SubGoal("isWalking", 1, true);
        goals.Add(s1, 3);
    }


}
