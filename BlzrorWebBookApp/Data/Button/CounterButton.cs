

using Microsoft.AspNetCore.Components;
using System.Runtime.CompilerServices;

namespace BlzrorWebBookApp.Data.Button
{
	public class Counter : ICountable
	{
		int _count = 0;
		public int Increase { get; init; }
        public Counter(int increase)
        {
            Increase = increase;
        }
        public int Count
		{
			get => _count;
			set => _count = value;
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Increment() => _count += Increase;



	}
}
