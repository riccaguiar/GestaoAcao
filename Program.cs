using Raylib_cs;
using System.Numerics;



Raylib.InitWindow(800, 480, "Hello World");

Vector2 ballPosition = new Vector2(100, 200);

Raylib.SetTargetFPS(60);

while (!Raylib.WindowShouldClose())
{
    if (Raylib.IsKeyDown(KeyboardKey.Right)) ballPosition.X += 2.0f;
    if (Raylib.IsKeyDown(KeyboardKey.Left)) ballPosition.X -= 2.0f;
    if (Raylib.IsKeyDown(KeyboardKey.Up)) ballPosition.Y -= 2.0f;
    if (Raylib.IsKeyDown(KeyboardKey.Down)) ballPosition.Y += 2.0f;


    Raylib.BeginDrawing();

    

    Raylib.DrawFPS(50, 60);

    Raylib.ClearBackground(Color.White);

    Raylib.DrawText("Hello, world!", 12, 12, 20, Color.Black);

    Raylib.DrawCircleV(ballPosition, 50, Color.Red);

    Raylib.EndDrawing();
}

Raylib.CloseWindow();
    
