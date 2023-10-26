using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draw3DShapes : MonoBehaviour
{
    private Material material;

    void Start()
    {
        material = new Material(Shader.Find("Hidden/Internal-Colored"));
    }

    void OnPostRender()
    {
        material.SetPass(0);

        // Draw a Pyramid
        DrawPyramid();

        // Draw a Cylinder
        DrawCylinder();

        // Draw a Plane
        DrawPlane();

        // Draw a Sphere
        DrawSphere();
    }

    void DrawPyramid()
    {
        GL.Begin(GL.TRIANGLES);

        // Define vertices for the pyramid
        // ...

        GL.End();
    }

    void DrawCylinder()
    {
        GL.Begin(GL.TRIANGLES);

        // Define vertices for the cylinder
        // ...

        GL.End();
    }

    void DrawPlane()
    {
        GL.Begin(GL.QUADS);

        // Define vertices for the plane
        // ...

        GL.End();
    }

    void DrawSphere()
    {
        GL.Begin(GL.TRIANGLES);

        // Define vertices for the sphere
        // ...

        GL.End();
    }
}

