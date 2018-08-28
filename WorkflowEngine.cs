using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkflowEngine : MonoBehaviour {

	public void Run(IWorkflow workflow)
    {
        foreach (ITask I in workflow.GetTasks())
        {
            I.Execute();
        }
    }
}
