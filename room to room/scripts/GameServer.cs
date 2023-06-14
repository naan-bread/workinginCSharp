using Godot;
using System;

public partial class GameServer : Node
{
    static public Node player;
    static public Node world;
    static public Vector2 playerSpawn = new Vector2(264,56);

    public void RoomChange(string RoomPath, Vector2 PlayerStart) {
        GetTree().ChangeSceneToFile(RoomPath);
        playerSpawn = PlayerStart;
    }
}
