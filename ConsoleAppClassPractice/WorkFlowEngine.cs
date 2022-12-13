namespace ConsoleAppClassPractice;

public class WorkFlowEngine
{
    private IWorkflow _workflow;

    public interface IWorkflow
    {
        void AddActivity(IActivity activity);
        IEnumerable<IActivity> GetActivities();
    }

    public class WorkFlow : IWorkflow
    {
        private readonly IList<IActivity> _workflowObject;

        public WorkFlow()
        {
            _workflowObject = new List<IActivity>();
        }
        public void AddActivity(IActivity activity)
        {
            _workflowObject.Add(activity);
        }

        public IEnumerable<IActivity> GetActivities()
        {
            return _workflowObject;
        }
    }
    
    public void Run(IWorkflow workflow)
    {
        foreach (var activity in workflow.GetActivities())
        {
            activity.Execute();
        }
    }
}