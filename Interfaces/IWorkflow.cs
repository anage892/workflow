using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWorkflow
{
    void Add(ITask task);
    void Remove(ITask task);
    IEnumerable<ITask> GetTasks();
}
