using System;

namespace Zaliczenie2
{
	public class Vector
	{
		float a,b,c;

		public Vector ()
		{
			this.a = 0;
			this.b = 0;
			this.c = 0;
		}

		public Vector (float f1, float f2, float f3) 
		{
			this.a = f1;
			this.b = f2;
			this.c = f3;
		}

		public float Get1() 
		{
			return this.a;
		}

		public float Get2() 
		{
			return this.b;
		}

		public float Get3() 
		{
			return this.c;
		}

		public void Set(float f1, float f2, float f3)
		{
			this.a = f1;
			this.b = f2;
			this.c = f3;
		}

		public override string ToString() {
			return "[ " + this.a.ToString () + " " + this.b.ToString() + " " + this.c.ToString() + " ]";
		}

		public static void Sum(ref Vector a, ref Vector b, out Vector x) {
			x = new Vector ();
			x.Set (a.Get1 () + b.Get1 (), a.Get2 () + b.Get2 (), a.Get3 () + b.Get3 ());
		}
	}
}

