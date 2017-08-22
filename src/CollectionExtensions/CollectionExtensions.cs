using System.Collections.Generic;


namespace BeatThat
{
	public static class CollectionExtensions
	{
		public static void AddRange<T>(this ICollection<T> toC, ICollection<T> fromC)
		{
			var asList = toC as List<T>;
			if(asList != null) {
				asList.AddRange(fromC);
				return;
			}

			foreach(var o in fromC) {
				toC.Add(o);
			}
		}
	}
}