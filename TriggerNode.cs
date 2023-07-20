namespace SAGE
{
    public class TriggerNode : ScriptNode
    {
        private bool isTriggered = false;

        public override void Execute(float currentTime)
        {
            if (!isTriggered)
            {
                // Trigger the associated actions
                foreach (var connectedNode in ConnectedNodes)
                {
                    connectedNode.Execute(currentTime);
                }

                isTriggered = true;
            }
        }
    }
}
