using System;

namespace SAGE
{
    public class ActionNode : ScriptNode
    {
        public Action Action { get; }

        public ActionNode(Action action)
        {
            Action = action;
        }

        public override void Execute(float currentTime)
        {
            // Execute the action
            Action.Invoke();
        }
    }
}
