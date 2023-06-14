using Godot;
using System;

public partial class zone_line : Area2D
{
    [Export(PropertyHint.File)] public String RoomPath;
    [Export] public Vector2 PlayerStart;
    private GameServer gameServer;

    public void OnArea2DAreaEntered(Area2D area) {
        
        if (!string.IsNullOrEmpty(RoomPath)) {
            gameServer = GetNode<GameServer>("/root/GameServer");
            gameServer.Call("RoomChange", RoomPath, PlayerStart);
        }
    }
}
