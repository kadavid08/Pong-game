PONG - SIMPLE C# WINDOWS FORMS GAME

HOW TO OPEN AND PLAY
1. Extract the whole ZIP file first.
2. Open Pong.sln in Visual Studio on Windows.
3. Press F5, then click START in the game window.
4. Hold W to move up and S to move down.
5. First to 5 points wins. RESTART begins a new game at any time.

The project uses Windows Forms App (.NET Framework 4.7.2).
Visual Studio needs the .NET desktop development workload and the
.NET Framework 4.7.2 targeting pack. If Visual Studio asks you to
retarget the project, .NET Framework 4.8 is also suitable.
No extra packages or image files are needed.

WHICH FILE DOES WHAT?
Pong/Form1.cs          - All game logic. Start reading here.
Pong/Form1.Designer.cs - The controls, colours, sizes and event connections.
Pong/Program.cs        - Opens the game window.
Pong/Pong.csproj       - Project settings for Visual Studio.
Rewritten_prompt.txt  - The prompt rewritten to match this game.

THE MAIN METHODS
startButton_Click: resets the score and positions, then starts the Timer.
gameTimer_Tick: moves the paddles and ball and checks collisions and points.
KeepInside: stops a paddle from leaving the playing area.
ResetBall: places the ball in the middle.
FinishPoint: updates the score and stops the game at 5 points.
Form1_KeyDown / KeyUp: remember whether W or S is held down.
Form1_Deactivate: clears held keys when you switch to another window.

EASY VALUES TO CHANGE IN Form1.cs
8 in player movement: player paddle speed.
3 in computer movement: computer paddle speed.
ballX = 6: horizontal ball speed (set initially and on Restart).
ballY = 4: vertical ball speed (set initially and on Restart).
5 in FinishPoint: points needed to win.

MOVEMENT
The Timer runs about every 16 milliseconds. Positions are measured in pixels.
Left gets bigger towards the right; Top gets bigger towards the bottom.
Changing the sign of ballX or ballY reverses that direction.
The AI moves more slowly than the ball so it can miss.
Restart resets both scores, both paddles, the ball and its direction.

CHECKING
The source, event connections and project structure were checked here.
This environment has no Windows Forms runtime or C# compiler, so the
project has not been compiled or played here. Run it in Visual Studio
on Windows for the final check.
