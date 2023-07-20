namespace SAGE
{
    public class GameEngine
    {
        private GUI gui;
        private SceneEditor sceneEditor;
        private ScriptingSystem scriptingSystem;

        public GameEngine()
        {
            // Create GUI, Scene Editor, and Scripting System
            gui = new GUI();
            sceneEditor = new SceneEditor();
            scriptingSystem = new ScriptingSystem();
        }

        public void Run()
        {
            // Game loop
            while (true)
            {
                // Handle input
                InputEvent inputEvent = ReadInput();
                gui.HandleInput(inputEvent);
                sceneEditor.HandleInput(inputEvent);

                // Update game logic
                scriptingSystem.Update();

                // Render
                RenderScene();
                RenderGUI();
            }
        }

        private InputEvent ReadInput()
        {
            // Read input from the user (e.g., keyboard events, mouse events)
            // Return the appropriate InputEvent
            return null;
        }

        private void RenderScene()
        {
            // Render the game scene
        }

        private void RenderGUI()
        {
            // Render the GUI
        }
    }
}
