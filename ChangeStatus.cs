using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class ChangeStatus : ITask {

	public void Execute()
    {
        Debug.Log("Status changed...");
    }
}
