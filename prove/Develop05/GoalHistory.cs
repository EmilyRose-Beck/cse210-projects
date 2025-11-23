//can delete old goals so they are no longer shown, ask if user is sure when deleting an incomplet checklist, Enternal, or an incomplete simple goal
//can also delete current goals
//should be able to delete a file or rewrite the file to be reused?
//could I set it up to be renamed if so?

using System.Collections.Generic;

public class GoalHistory
{
    private List<Goal> _currentGoals = new List<Goal>();
    private List<Goal> _completedGoals = new List<Goal>();
    private List<Goal> _deletedGoals = new List<Goal>();

    public void AddGoal(Goal goal) { }
    public void CompleteGoal(Goal goal) { }
    public void DeleteGoal(Goal goal) { }
    public void RestoreGoal(Goal goal) { }
    public List<Goal> GetPinnedGoals() { return new List<Goal>(); }
}
