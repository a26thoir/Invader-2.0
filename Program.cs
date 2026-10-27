global using SFML.Graphics;
global using SFML.System;
global using SFML.Window;

namespace Invaders_2._0;

class Program
{
    
    // Fields

    public static uint screenW;
    public static uint screenH;
    
    static void Main(string[] args)
    {
        
        // Render Window
        
        VideoMode desktopMode = VideoMode.DesktopMode;

        using (RenderWindow window = new(desktopMode, "SFML FullScreen", Styles.Fullscreen)) // FullScreen

        {
            screenW = desktopMode.Width;
            screenH = desktopMode.Height;
            
            window.Closed += (o, e) => window.Close(); // Pressing "X" top right closes screen
            
            // Instancing Classes

            Clock clock = new();
            Scene scene = new();
            
            // TODO Implement Scenes
            
            // Main Loop

            while (window.IsOpen)
            {
                float deltaTime = clock.Restart().AsSeconds();
                window.DispatchEvents();
                
                if (Keyboard.IsKeyPressed(Keyboard.Key.Escape)) Environment.Exit(23); // Close window (Window.Close()) (Environment.Exit(23))

                scene.UpdateAll(scene, deltaTime);

                scene.RenderAll(window);
                
                window.Clear(new Color(0, 50, 50));
                
                
            }

        }

    }
}