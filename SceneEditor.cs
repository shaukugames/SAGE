namespace SAGE
{
    public class SceneEditor
    {
        private List<GameObject> gameObjects = new List<GameObject>();
        private GameObject selectedObject;
        private Vector2 dragOffset;

        public void AddGameObject(GameObject gameObject)
        {
            gameObjects.Add(gameObject);
        }

        public void RemoveGameObject(GameObject gameObject)
        {
            gameObjects.Remove(gameObject);
        }

        public void HandleInput(InputEvent inputEvent)
        {
            if (inputEvent is MouseClickEvent mouseClickEvent)
            {
                foreach (var gameObject in gameObjects)
                {
                    if (gameObject.IsClicked(mouseClickEvent.Position))
                    {
                        selectedObject = gameObject;
                        dragOffset = mouseClickEvent.Position - gameObject.Position;
                        break;
                    }
                }
            }
            else if (inputEvent is MouseMoveEvent mouseMoveEvent && selectedObject != null)
            {
                selectedObject.Position = mouseMoveEvent.Position - dragOffset;
            }
        }
    }
}
