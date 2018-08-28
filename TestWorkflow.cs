using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestWorkflow : MonoBehaviour {

    WorkflowEngine engine = new WorkflowEngine();

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp(KeyCode.I))
        {
            Workflow workflow = new Workflow();

            workflow.Add(new VideoUploader());
            workflow.Add(new CallWebService());
            workflow.Add(new SendEmail());
            workflow.Add(new ChangeStatus());

            engine.Run(workflow);
        }
	}
}
