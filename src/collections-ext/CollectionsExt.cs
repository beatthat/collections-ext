using System.Collections.Generic;


namespace BeatThat
{
	public static class CollectionExtensions
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
	}
}
