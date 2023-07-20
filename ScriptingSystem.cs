namespace SAGE
{
    public class ScriptingSystem
    {
        private List<ScriptNode> scriptNodes = new List<ScriptNode>();
        private float currentTime = 0f;

        public void Update(float deltaTime)
        {
            currentTime += deltaTime;

            // Execute visual scripting logic
            foreach (var node in scriptNodes)
            {
                node.Execute(currentTime);
            }
        }

        public void AddScriptNode(ScriptNode node)
        {
            scriptNodes.Add(node);
        }

        public void RemoveScriptNode(ScriptNode node)
        {
            scriptNodes.Remove(node);
        }
    }
}
