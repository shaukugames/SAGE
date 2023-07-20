
using System.Collections.Generic;

namespace SAGE
{
    public abstract class ScriptNode
    {
        public List<ScriptNode> ConnectedNodes { get; } = new List<ScriptNode>();

        public void ConnectTo(ScriptNode node)
        {
            ConnectedNodes.Add(node);
        }

        public abstract void Execute(float currentTime);
    }
}
