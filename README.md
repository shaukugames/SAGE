''***************Shauku Accessible Game Engine******************* 
***************************(SAGE)******************************''

(text-colour:red)[''The Goal of the engine, was to make game creation as easily available as possible, while building on the game like building lego, while, at the same time, being pwerful enough to work as alternative engine to all the well known engines on the planet.'']

The following is generic marketing talk to sell the concept to you.

Get ready to unleash your creativity and bring your gaming ideas to life. Packed with powerful features and designed to be user-friendly, this game engine empowers you to create captivating gaming experiences with ease. Let's explore the exciting features that make the Shauku Accessible Game Engine stand out:

''Intuitive Game Creation:'' With a user-friendly interface and simple yet powerful tools, our game engine makes it a breeze to create your own games. No prior programming experience is required, allowing anyone to dive into game development and express their unique ideas.

''Interactive Object Placement:'' The engine allows you to effortlessly place and position game objects using your mouse. Simply click and drag objects around the screen to create captivating scenes and dynamic gameplay elements.

''Versatile Object Library:'' Expand your game's possibilities with our versatile object library. Choose from a range of pre-built objects, including boxes and circles, to populate your game world. Customize their appearance, behavior, and interactions to match your vision.

''Real-Time Updates:'' Witness your creations come to life in real-time. The Shauku Accessible Game Engine offers a smooth and responsive rendering system, allowing you to see immediate updates as you make changes to your game objects.

''Flexible Object Manipulation:'' Easily select, move, and interact with game objects using simple mouse controls. Precisely position objects, define their properties, and experiment with various designs, all with the utmost convenience.

''Stunning Graphics:'' Immerse players in visually stunning environments. With the engine's powerful rendering capabilities, you can create captivating graphics, vibrant colors, and eye-catching animations that will leave players awestruck.

''User Interface Customization:'' Enhance your game's interface with customizable UI elements. From displaying scores to conveying important information, you have the freedom to design and tailor the user interface to suit your game's unique requirements.

''Seamless Performance:'' Enjoy smooth gameplay experiences with the engine's optimized performance. The Shauku Accessible Game Engine ensures high frame rates, delivering a seamless gaming experience that captivates players and keeps them engaged.

''Developer-Friendly Environment:'' Aspiring developers will appreciate the engine's developer-friendly environment. From easy integration of custom scripts to extensive documentation and support, our engine provides the tools and resources you need to succeed.

''Community and Collaboration:'' Join a vibrant community of game creators and enthusiasts. Share your creations, seek feedback, and collaborate with fellow developers to enhance your skills and create even more remarkable games.

Unleash your creativity and embark on an exciting game development journey with the Shauku Accessible Game Engine Whether you're a hobbyist, student, or aspiring game developer, this engine empowers you to turn your ideas into captivating gaming experiences that will leave players craving for more. Get started today and let your imagination run wild!

Below is the detailing of each .cs file as a class working within the main game engine, each clas explaining what it's suppossed to do, for easy modificcation and adaptability, as the though of making the engine modular became more apparentg as time goes by.

The //Main// codebase contains the entry point of the program and is responsible for creating the GameEngine instance and running the game

The //GameEngine// class is responsible for managing the game loop, handling input, updating game logic through the //ScriptingSystem//, and rendering the game scene and GUI. 

The //GUI// class manages various UI elements, including the sprite selection panel, scene editor panel, and visual scripting panel. It is responsible for rendering these elements and handling their input.

The //SceneEditor// class handles the scene editing functionality, including adding and removing game objects and handling input for selecting and dragging objects in the scene.

The //ScriptingSystem// class manages the visual scripting logic, including executing script nodes and handling the flow of object-action-trigger.

The //UIElement// class is an abstract class representing a generic UI element. It provides methods for drawing the element and handling input.

//SpriteSelectionPanel//,// SceneEditorPanel//, and //VisualScriptingPanel //Classes:
These classes are implementations of the //UIElement// abstract class and define the specific behavior for the sprite selection panel, scene editor panel, and visual scripting panel.

The //GameObject// class represents a generic game object. It contains properties such as Position and Name, and it provides a method to check if the object is clicked.

The //UIElementFactory// class is responsible for creating different types of UI elements in the game. It provides methods like CreateButton and CreateLabel to create specific UI elements with the desired properties.

The //ButtonUIElement// and //LabelUIElement// classes are custom implementations of the //UIElement// abstract class. They define the behavior for buttons and labels, including drawing them on the screen and handling input (e.g., button clicks).

  The//GameExporter// class is responsible for exporting the game and editing its metadata. The ExportGame method takes the game name and the desired file path and exports the game with all necessary data and metadata to that location. The EditMetadata method allows you to modify the metadata of an already exported game, such as changing the game name, description, and author information.

