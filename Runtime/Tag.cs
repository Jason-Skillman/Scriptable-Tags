namespace JasonSkillman.ScriptableTags {
	using UnityEngine;

	[CreateAssetMenu(fileName = "New Tag", menuName = "Scriptable Tags/Tag", order = 0)]
	public class Tag : ScriptableObject {
		[SerializeField]
		private string tag;

		public string Value { get => tag; set => tag = value; }

		public static implicit operator string(Tag t) => t.tag;
	}
}
