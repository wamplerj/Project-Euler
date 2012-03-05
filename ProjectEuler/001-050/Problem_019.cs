using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
	public class Problem_019
	{

		public int NumberOfDaysOfWeek(DateTime startDate, DateTime endDate, DayOfWeek dayOfWeek)
		{

			DateTime currentDay = startDate;
			int dayOfWeekCount = 0;

			while(currentDay < endDate)
			{
				if (currentDay.DayOfWeek == dayOfWeek && currentDay.Day == 1)
					dayOfWeekCount++;

				currentDay = currentDay.AddDays(1);

			}

			return dayOfWeekCount;

		}


	}
}
