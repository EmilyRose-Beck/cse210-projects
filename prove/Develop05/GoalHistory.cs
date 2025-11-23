//can delete old goals so they are no longer shown, ask if user is sure when deleting an incomplet checklist, Enternal, or an incomplete simple goal
//can also delete current goals
//should be able to delete a file or rewrite the file to be reused?
//could I set it up to be renamed if so?

using System;
using System.Collections.Generic;
using System.Linq;

public class GoalHistory
{
    private List<Goal> _currentGoals = new List<Goal>();
    private List<Goal> _completedGoals = new List<Goal>();
    private List<Goal> _deletedGoals = new List<Goal>();
    private List<Goal> _pinnedGoals = new List<Goal>();

    public void AddGoal(Goal goal)
    {
        _currentGoals.Add(goal);
    }

    public void CompleteGoal(Goal goal)
    {
        if (_currentGoals.Remove(goal))
        {
            _completedGoals.Add(goal);
        }
    }

    public bool DeleteGoal(Goal goal)
    {
        if (_currentGoals.Contains(goal))
        {
            _currentGoals.Remove(goal);
        }
        else if (_completedGoals.Contains(goal))
        {
            _completedGoals.Remove(goal);
        }
        else
        {
            return false; // goal not found
        }

        _deletedGoals.Add(goal);
        return true;
    }

    public bool RestoreGoal(Goal goal)
    {
        if (_deletedGoals.Remove(goal))
        {
            _currentGoals.Add(goal);
            return true;
        }
        return false;
    }

    public List<Goal> GetCurrentGoals() => new List<Goal>(_currentGoals);
    public List<Goal> GetCompletedGoals() => new List<Goal>(_completedGoals);
    public List<Goal> GetDeletedGoals() => new List<Goal>(_deletedGoals);

    // -------- PINNING FEATURE --------

    public void PinGoal(Goal goal)
    {
        if (!_pinnedGoals.Contains(goal))
            _pinnedGoals.Add(goal);
    }

    public void UnpinGoal(Goal goal)
    {
        _pinnedGoals.Remove(goal);
    }

    public List<Goal> GetPinnedGoals() => new List<Goal>(_pinnedGoals);

    // -------- CLEANUP FEATURE --------

    public void ClearCompletedGoals()
    {
        _completedGoals.Clear();
    }
}
