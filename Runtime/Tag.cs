namespace JasonSkillman.ScriptableTags {
	using System;
	using UnityEditor;
	using UnityEngine;

	[CreateAssetMenu(fileName = "New Tag", menuName = "Scriptable Tags/Tag", order = 0)]
	public class Tag : ScriptableObject, IEquatable<Tag> {

		[SerializeField, HideInInspector]
		private ulong part1, part2;

		public ulong Part1 => part1;
		public ulong Part2 => part2;

		public string GuidString => $"{part1}{part2}";

		public bool Equals(Tag other) => part1 == other!.part1 && part2 == other.part2;

		public static bool operator ==(Tag tag1, Tag tag2) => tag1!.Equals(tag2);
		public static bool operator !=(Tag tag1, Tag tag2) => !(tag1 == tag2);

#if UNITY_EDITOR
		private void OnValidate() {
			TryCreateNewGuid();
		}

		/// <summary>
		/// Check if this object needs a new Guid and generates one.
		/// </summary>
		public void TryCreateNewGuid() {
			if(part1 != 0) return;
			
			CreateNewGuid();
		}
		
		public void CreateNewGuid() {
			part1 = RandomULongRange(ulong.MinValue, ulong.MaxValue);
			part2 = RandomULongRange(ulong.MinValue, ulong.MaxValue);
			
			//Save asset.
			EditorUtility.SetDirty(this);
			AssetDatabase.SaveAssetIfDirty(this);

			Debug.Log($"New Guid created {GuidString}", this);
		}

		/// <summary>
		/// Returns a random ulong within a given range.
		/// </summary>
		private static ulong RandomULongRange(ulong min, ulong max) {
			byte[] buf = new byte[8];
			System.Random random = new();
			random.NextBytes(buf);
			ulong ulongRand = BitConverter.ToUInt64(buf, 0);

			return (ulongRand % (max - min)) + min;
		}
#endif
	}
}
