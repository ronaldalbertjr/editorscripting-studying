using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEditor;
using UnityEditorInternal;

namespace Assets.Editor
{
    class CreateElementWindow : EditorWindow
    {
        string name;
        GameObject prefab;
        bool boxCollider;


        [MenuItem("Ronald/Criar Elemento na cena")]
        static void OpenWindow()
        {
            CreateElementWindow window = (CreateElementWindow)GetWindow(typeof(CreateElementWindow));
            window.minSize = new Vector2(600, 300);
            window.Show();
        }

        void OnGUI()
        {
            DrawSettings();
        }
        void DrawSettings()
        {

            EditorGUILayout.BeginHorizontal();
            GUILayout.Label("Name:");
            name = EditorGUILayout.TextField(name);
            EditorGUILayout.EndHorizontal();
            
            if(name == null)
            {
                EditorGUILayout.HelpBox("Voce precisa definir um nome para seu GameObject", MessageType.Warning);
            }
            else if (GUILayout.Button("Create!!", GUILayout.Height(40)))
            {
                GameObject go = new GameObject(name);
            }
        }
    }
}
