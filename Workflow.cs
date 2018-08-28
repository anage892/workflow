using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Workflow : IWorkflow {

    readonly List<ITask> _tasks = new List<ITask>();

    public void Add(ITask task)
    {
        _tasks.Add(task);
    }

    public void Remove(ITask task)
    {
        _tasks.Remove(task);
    }

    public IEnumerable<ITask> GetTasks()
    {
        return _tasks;
    }
}
