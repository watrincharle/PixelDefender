

using Raylib_cs;

public static class SceneManager
{
    public static string STATE = "NullScene";
    // STATE : 
    // "NullScene" = Null
    // "Menu" = Menu (Scène initialisé au lancement du jeu) ________ envoie vers "Game"
    // "Pause" = Pause, activable uniquement en scène "Game" _______ envoie vers "Game" ou "Menu"
    // "Game" = Jeu ________________________________________________ envoie vers "Pause" ou "GameOver" ou "Win"
    // "Win" = Partie gagné ________________________________________ envoie vers "Menu"
    // "GameOver" = Partie perdu ___________________________________ envoie vers "Menu"

    public static void Load()
    {
        STATE = "Menu";
    }

    public static void Update()
    {
        if (Raylib.IsKeyPressed(KeyboardKey.P) && STATE == "Game")
        {
            STATE = "Pause";
        }
        else if (Raylib.IsKeyPressed(KeyboardKey.P) && STATE == "Pause")
        {
            STATE = "Game";
        }
    }
}
