
namespace SAGE
{
    public class GUI
    {
        private List<UIElement> elements = new List<UIElement>();

        public GUI()
        {
            // Add UI elements to the GUI
            elements.Add(new SpriteSelectionPanel());
            elements.Add(new SceneEditorPanel());
            elements.Add(new VisualScriptingPanel());
        }

        public void Render()
        {
            foreach (var element in elements)
            {
                element.Draw();
            }
        }

        public void HandleInput(InputEvent inputEvent)
        {
            foreach (var element in elements)
            {
                element.HandleInput(inputEvent);
            }
        }
    }
}
