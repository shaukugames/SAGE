namespace SAGE
{
    public class GameObject
    {
        public Vector2 Position { get; set; }
        public string Name { get; set; }

        public bool IsClicked(Vector2 clickPosition)
        {
            // Check if the object is clicked based on the clickPosition
            return false;
        }
    }
}
