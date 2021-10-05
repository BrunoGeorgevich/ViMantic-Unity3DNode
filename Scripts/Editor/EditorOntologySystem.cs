using UnityEngine;
using UnityEditor;

namespace ViMantic
{
    [CustomEditor(typeof(OntologySystem))]
    public class EditorOntologySystem : Editor
    {
        public override void OnInspectorGUI()
        {

            GUILayout.Label("Preference Settings:");
            if (GUILayout.Button("Save"))
            {
                PlayerPrefs.SetString("ontologyprefix", ((OntologySystem)target).prefix);
                PlayerPrefs.SetString("ontologyURI", ((OntologySystem)target).masterURI);
                PlayerPrefs.Save();
            }
            if (GUILayout.Button("Load"))
            {
                ((OntologySystem)target).prefix = PlayerPrefs.GetString("ontologyprefix");
                ((OntologySystem)target).masterURI = PlayerPrefs.GetString("ontologyURI");
            }

            base.OnInspectorGUI();
        }
    }
}