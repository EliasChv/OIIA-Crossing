using Godot;
using System;

public partial class Cat : Node3D
{
    private Node3D CatNode;
    public override void _Ready()
    {
        CatNode = GetNode<Node3D>("cats");
    }

    public override void _Process( double delta )
    {
        CatNode.RotateY( - ( float ) Math.PI * 2 * ( float ) delta );
    }

}
