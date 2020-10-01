using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
	class Point
    {
        int y, x;
        char sym;
        

        public void SetX(int x)
        {
            if (x >= 0)
                this.x = x;
            else
                throw new Exception("Значение x не может быть отрицательным");
        }
        public void SetY(int y)
        {
            if (y >= 0)
                this.y = y;
            else
                throw new Exception("Значение y не может быть отрицательным");
        }
        public void SetSym(char symbol)
        {
            sym = symbol;
        }
        public void Draw(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
        
       
}


	
	class Program
	{
		
		 static void Main(string[] args)
		{
			try
			{
				Point p = new Point ();
				int x,y;
				char sym;
				x=int.Parse(Console.ReadLine());
				y=int.Parse(Console.ReadLine());
				p.SetX(x);
				p.SetY(y);
				Console.Clear();
				do
				{
				
				p.SetX(x);
				
				p.SetY(y);
				if ((x==5)&&(y!=2))
					sym = ' ';
						else
							if ((x==1)&&(y==2))
								sym = ' ';
							else
								if ((x<4)&&(y==2))
									sym = '#';
							else sym = '-';
				
				p.SetSym(sym);
				p.Draw(x,y);
				if (x<5)
					x++;
				else 
				{
					x=1;
					y++;
				}
				} while ((x*y)<15);
				Console.ReadKey();
			}
			catch (Exception e)


			{
				Console.WriteLine(e.Message);
				Console.ReadKey();
			}
		}
	}
}