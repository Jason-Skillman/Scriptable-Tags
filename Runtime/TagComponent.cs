namespace JasonSkillman.ScriptableTags {
	using System.Collections.Generic;
	using UnityEngine;

	public class TagComponent : MonoBehaviour {
		[SerializeField]
		private List<Tag> tags;

		public List<Tag> Tags() => tags;
	}
}
