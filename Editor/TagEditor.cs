namespace JasonSkillman.ScriptableTags.Editor {
	using UnityEditor;
	using UnityEngine;

	[CustomEditor(typeof(Tag))]
	public class TagEditor : Editor
	{
		public override void OnInspectorGUI()
		{
			DrawDefaultInspector();

			Tag tag = (Tag)target;

			EditorGUILayout.LabelField("GUID", tag.GuidString);
        
			if(GUILayout.Button("Generate new GUID")) {
				tag.CreateNewGuid();
			}
		}
	}
}
