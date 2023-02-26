namespace JasonSkillman.ScriptableTags {
	using System.Collections.Generic;
	using UnityEngine;

	public static class TagUtils {
		
		/// <summary>Check if any of the tags on <paramref name="gameObject"/> match <paramref name="tag"/>.</summary>
		public static bool ContainsTag(this GameObject gameObject, Tag tag) {
			if(!gameObject.TryGetComponent(out TagComponent tagComponent))
				return false;

			List<Tag> tagList = tagComponent.Tags();
			for(int i = 0; i < tagList.Count; i++) {
				string currTag = tagList[i];

				if(currTag == tag)
					return true;
			}

			return false;
		}
	}
}
