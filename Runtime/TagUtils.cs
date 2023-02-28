namespace JasonSkillman.ScriptableTags {
	using System.Collections.Generic;
	using UnityEngine;

	public static class TagUtils {
		
		/// <summary>Check if any of the tags on <paramref name="gameObject"/> match <paramref name="tag"/>.</summary>
		public static bool ContainsTag(this GameObject gameObject, Tag tag) {
			if(!gameObject.TryGetComponent(out TagComponent tagComponent))
				return false;

			List<Tag> goTagList = tagComponent.Tags;
			for(int i = 0; i < goTagList.Count; i++) {
				string goTag = goTagList[i];

				if(goTag == tag)
					return true;
			}

			return false;
		}
		
		/// <summary>Check if any of the tags on <paramref name="gameObject"/> match any in <paramref name="tags"/>.</summary>
        public static bool ContainsTag(this GameObject gameObject, Tag[] tags) {
        	if(!gameObject.TryGetComponent(out TagComponent tagComponent))
        		return false;

        	List<Tag> goTagList = tagComponent.Tags;
        	for(int i = 0; i < goTagList.Count; i++) {
        		string goTag = goTagList[i];

                for(int j = 0; j < tags.Length; j++) {
	                string tag = tags[j];
	                
	                if(goTag == tag)
		                return true;
                }
        	}

        	return false;
        }
	}
}
