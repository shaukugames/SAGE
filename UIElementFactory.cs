namespace SAGE
{
    public class UIElementFactory
    {
        public UIElement CreateButton(Vector2 position, string label, Action onClick)
        {
            // Create a new button UI element with the given position, label, and click action
            return new ButtonUIElement(position, label, onClick);
        }

        public UIElement CreateLabel(Vector2 position, string text)
        {
            // Create a new label UI element with the given position and text
            return new LabelUIElement(position, text);
        }

        // Add methods to create other UI elements such as images, text boxes, etc.
    }

    // Custom UI Elements
    public class ButtonUIElement : UIElement
    {
        private Vector2 position;
        private string label;
        private Action onClick;

        public ButtonUIElement(Vector2 position, string label, Action onClick)
        {
            this.position = position;
            this.label = label;
            this.onClick = onClick;
        }

        public override void Draw()
        {
            // Draw the button on the screen
        }

        public override void HandleInput(InputEvent inputEvent)
        {
            if (inputEvent is MouseClickEvent mouseClickEvent)
            {
                if (IsClicked(mouseClickEvent.Position))
                {
                    onClick?.Invoke();
                }
            }
        }

        private bool IsClicked(Vector2 clickPosition)
        {
            // Check if the button is clicked based on the clickPosition
            return false;
        }
    }

    public class LabelUIElement : UIElement
    {
        private Vector2 position;
        private string text;

        public LabelUIElement(Vector2 position, string text)
        {
            this.position = position;
            this.text = text;
        }

        public override void Draw()
        {
            // Draw the label on the screen
        }

        public override void HandleInput(InputEvent inputEvent)
        {
            // Labels don't handle input
        }
    }
}
