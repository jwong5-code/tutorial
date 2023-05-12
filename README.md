# TutorialReport

Hello, in this ReadMe, you are going to look at my files and how to use them.

My game is revolved around Game Design.

## Prerequisites

- You would need to download the Game Engine app **Unity**. In the tutorial, I used the 2021.3.11f1 version. 

- You would also need an application that you are able to type in C# with and save files to connect them with Unity.
  - Examples: Visual Studio Code

## Scripts

### NewBehaviourScript.cs
This script is meant to test void Start() and void Update() in terms of debug and posting out a message in the console. If we were to debug text in the console, at the start function it would only call it once and that was right after the play button. The Update() is called once per frame. To activate this, create a GameObject in Unity and drag and drop this script in the inspector of the GameObject.

### PlayerController.cs
This script is mainly attached to whatever 3D object (with a rigidbody) you want to move. The start function gets the rigidbody component right away to know what 3D objects have controls.

The update function calls another void to see if any keys are input. That is the ProcessInputs() which assigns Input keys to specific directions (vertical if up or down keys and horizontal for left or right).

There is also a FixedUpdate() which is called whenever a rigidbody is being applied. It is calling the Move() function where the rigidbody assigned is accelerating as a force is being applied.

### TimeLimit.cs
This can be attached preferrably in the object the player controls or the Canvas. The point is to make the created game in the tutorial more challenging. 
Several additional components and variables must be established in the game to see what will be affected during gameplay. This script will produce a time limit where the player must complete a certain level, otherwise when time reaches zero, it is Game Over. There is also a pause menu that can be triggered by key inputs. When the game starts, it is normal the play. However, at time reaches zero the script for moving the ball and leveling up at the finish point are disabled, so you cannot advance. Also, the GameOver panel screen appears.

### LevelUp.cs
A 3D gameobject must be created in which the player can collide with to activate the function. The script must be collided with the stationary object. Upon collision, a new scene is loaded depending on the next scene in line from the build settings. 



