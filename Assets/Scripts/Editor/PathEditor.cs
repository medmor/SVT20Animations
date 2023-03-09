using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(PathMove))]
public class PathEditor : Editor
{
    private void OnSceneGUI()
    {
        PathMove path = (PathMove)target;
        if (path == null || path.Points.Length == 0 || !path.EditPath)
            return;
        Handles.color = Color.black;
        for (int i = 1; i < path.Points.Length + 1; i++)
        {
            var prev = path.Points[i - 1];
            var curr = path.Points[i % path.Points.Length];
            Handles.DrawDottedLine(prev, curr, 4f);
        }
        for (var i = 0; i < path.Points.Length; i++)
        {
            path.Points[i] = Handles.PositionHandle(path.Points[i], Quaternion.identity);
        }
    }
}

