using Godot;
using System;

[GlobalClass]
public partial class SetColorFromPalette : BrushBehavior
{
    public override void Draw(BrushDefinition brushDefinition, CanvasItem canvasItem)
    {
        base.Draw(brushDefinition, canvasItem);
        brushDefinition.EvaluatedColor = brushDefinition.CursorColor;
    }
}
