# VRAssesmentProject

1. Clone or download the project from git.
2. Add VR Scene from Scenes folder to build scene.
3. One the project is setup, open the Player setting and do the following changes.
   . Switch to Android platform
   . Player - Set the graphics API to OpenGLES3
   . Minimum API level 23
   . Scripting backend IL2CPP
   . Target architectures - ARM64
   . Active input handling - Both
4. For Quality changes we can do SPR settings in Graphics option in build settings - URP Balanced, URP-HighFidelity, URP-Performant.
5. The same URP option should be used in Quality option in build settings.
6. We can select it directly also by clicking on Levels in Quality settings.
7. In XR plugin management the Oculus option should be clicked to make it work in Quest devices.
8. One all the required changes are done we can build the application.
9. One build we can install the app to quest by many ways - One way is by using SideQuest.
10. One the app is installed follow below steps to experince the app.
    . Open the app from unknown resources.
    . To move around the room use Left Thumbstck from controller
    . To rotate use Right thumbstick from controller - We can change the option from project for continues and snap turn.
    . Right trigger to Teleport from controller.
    . Left and Right Grip buttons from controller.
