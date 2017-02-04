using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(GameCamera))]
public class GameCameraEditor : Editor
{
    GameCamera m_Target;

    public override void OnInspectorGUI()
    {
        m_Target = (GameCamera)target;

        DrawDefaultInspector();
        DrawCameraHeightPreviewSlider();
    }

    void DrawCameraHeightPreviewSlider()
    {
        GUILayout.Space(10);

        Vector3 cameraPosition = m_Target.transform.position;
        cameraPosition.y = EditorGUILayout.Slider("Camera Height:", cameraPosition.y, m_Target.minimunHeight, m_Target.maximunHeight);

        if(cameraPosition.y != m_Target.transform.position.y)
        {
            Undo.RecordObject(m_Target, "Change Camera Height");
            m_Target.transform.position = cameraPosition;
        }
    }
}
