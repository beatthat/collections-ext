using BeatThat.GetComponentsExt;
using BeatThat.CollectionsExt;
using System.Collections.Generic;


namespace BeatThat.CollectionsExt
{
    public static class Ext
	{
		/// <summary>
		/// Enable <c>ICollection.AddRange<T></c> which is normally only available on <c>IList<T></c>
		/// </summary>
		/// <param name="toC">To c.</param>
		/// <param name="fromC">From c.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
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

		public static bool AddIfMissing<T>(this ICollection<T> c, T elem)
		{
			if (c.Contains (elem)) {
				return false;
			}
			c.Add (elem);
			return true;
		}
	}
}



