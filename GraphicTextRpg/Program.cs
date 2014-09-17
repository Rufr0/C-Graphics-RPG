using System;

namespace GraphicTextRpg
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Array Map;
			Array col;
			Array row;

			int x=0;
			int y=0;
			while (true) 
			{
				add(row, "_");
				x += 1;
				if (x>=50)
				{
					x=0;
					y+=1;
					Array.add(col, row);
					if (y>=50)
					{
						Map=col;
						break;
					}
				}
			}
				
		}
	}
}
