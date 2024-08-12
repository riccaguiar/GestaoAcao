using Raylib_cs;
using System.Numerics;

//configurar segunda parte das animacoes
Raylib.InitWindow(800, 480, "Hello World");

Vector2 playerPosition = new Vector2(100, 200);


//coordenadas do sprite
Rectangle sourceDown = new Rectangle(0, 0, 100, 150); // paradp

Rectangle sourceDown2 = new Rectangle(100, 0, 100, 150);

Rectangle sourceDown3 = new Rectangle(300, 0, 100, 150);

Rectangle sourceUp = new Rectangle(0, 150, 100, 150);

Rectangle sourceUp2 = new Rectangle(100, 150, 100, 150);

Rectangle sourceUp3 = new Rectangle(300, 150, 100, 150);

Rectangle sourceLeft = new Rectangle(0, 300, 100, 150);

Rectangle sourceLeft2 = new Rectangle(100, 300, 100, 150);

Rectangle sourceLeft3 = new Rectangle(300, 300, 100, 150);

Rectangle sourceRight = new Rectangle(0, 450, 100, 150);

Rectangle sourceRight2 = new Rectangle(100, 450, 100, 150);

Rectangle sourceRight3 = new Rectangle(300, 450, 100, 150);

Raylib.SetTargetFPS(60);

Texture2D personage = Raylib.LoadTexture("spritepersonage.png"); // jogar a imagem no: C:\Users\teu user\source\repos\GestaoAcao\GestaoAcao\bin\Debug\net8.0

Rectangle oneDirection = sourceDown; //ignorar nome :p

bool isRunning = false;

float frameTime = 0.0f;

const float frameSpeed = 0.1f; // Velocidade de troca de frames (em segundos)

while (!Raylib.WindowShouldClose())
{
    bool isMoving = false;

    // parte q reconhece as entradas do teclado para mover o personagem
    if (Raylib.IsKeyDown(KeyboardKey.Right))
    {
        playerPosition.X += 2.0f;
        oneDirection = sourceRight2;
        isMoving = true;
        isRunning = true;
    }

    if (Raylib.IsKeyDown(KeyboardKey.Left))
    {
        playerPosition.X -= 2.0f;
        oneDirection = sourceLeft2;
        isMoving = true;
        isRunning = true;
    }
    if (Raylib.IsKeyDown(KeyboardKey.Up))
    {
        playerPosition.Y -= 2.0f;
        oneDirection = sourceUp2;
        isMoving = true;
        isRunning = true;
    }
    if (Raylib.IsKeyDown(KeyboardKey.Down))
    {
        playerPosition.Y += 2.0f;
        oneDirection = sourceDown2;
        isMoving = true; 
        isRunning = true;
    }

    // Se o personagem está se movendo, atualiza o frame da animação
    if (isRunning)
    {
        frameTime += Raylib.GetFrameTime();
        if (frameTime >= frameSpeed)
        {
            frameTime = 0.0f;
            if (oneDirection.Equals(sourceRight))
            {
                oneDirection = sourceRight2;
            }
            else if (oneDirection.Equals(sourceRight2))
            {
                oneDirection = sourceRight3;
            }
            else if (oneDirection.Equals(sourceLeft))
            {
                oneDirection = sourceLeft2;
            }
            else if (oneDirection.Equals(sourceLeft2))
            {
                oneDirection = sourceLeft3;
            }
            else if (oneDirection.Equals(sourceUp))
            {
                oneDirection = sourceUp2;
            }
            else if (oneDirection.Equals(sourceUp2))
            {
                oneDirection = sourceUp3;
            }
            else if (oneDirection.Equals(sourceDown))
            {
                oneDirection = sourceDown2;
            }
            else if (oneDirection.Equals(sourceDown2))
            {
                oneDirection = sourceDown3;
            }
        }
    }

    // Se não estiver se movendo, retorna para o sprite parado
    if (!isMoving)
    {
        if (oneDirection.Equals(sourceRight2) || oneDirection.Equals(sourceRight3))
        {
            oneDirection = sourceRight;
        }
        else if (oneDirection.Equals(sourceLeft2) || oneDirection.Equals(sourceLeft3))
        {
            oneDirection = sourceLeft;
        }
        else if (oneDirection.Equals(sourceUp2) || oneDirection.Equals(sourceUp3))
        {
            oneDirection = sourceUp;
        }
        else if (oneDirection.Equals(sourceDown2) || oneDirection.Equals(sourceDown3))
        {
            oneDirection = sourceDown;
        }
        isRunning = false;
    }

    Raylib.BeginDrawing();

    Raylib.DrawFPS(50, 60);

    Raylib.ClearBackground(Color.White);


    //Raylib.DrawCircleV(ballPosition, 50, Color.Red);
    //Raylib.DrawTextureV(personage, ballPosition, Color.White); // semprebranco de preferencia
    Rectangle dest = new Rectangle(playerPosition.X, playerPosition.Y, 100, 150);


    Raylib.DrawTexturePro(personage, oneDirection, dest, new(0, 0), 0, Color.White);

    Raylib.EndDrawing();
}

Raylib.CloseWindow();