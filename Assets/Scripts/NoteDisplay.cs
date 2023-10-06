using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;

//[ExecuteInEditMode]
[ExecuteAlways]

[CustomEditor(typeof(NoteDisplay))]
public class NoteDisplayEditor : Editor
{
    private void OnSceneGUI()
    {
        NoteDisplay noteDisplay = (NoteDisplay)target;

        // Create a GUIStyle to customize the label appearance
        GUIStyle style = new GUIStyle();
        style.normal.textColor = Color.black;
        style.fontSize = 16; // Set the font size to your desired value

        // Display the note with the custom GUIStyle
        Handles.Label(noteDisplay.transform.position, noteDisplay.note, style);
    }
}
#endif

public class NoteDisplay : MonoBehaviour
{
    [TextArea]
    public string note = "This is a note for the object.";

}

