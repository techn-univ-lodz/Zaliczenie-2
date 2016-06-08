using System;
using Zaliczenie2;

namespace Zaliczenie2
{
	public class Vector
	{
		float[] a;

		public Vector ()
		{
			a = new float [3];
			for(int i=0; i<3; i++)
				this.a[i] = 0;
		}

		public Vector (float f1, float f2, float f3) 
		{
			this.a[0] = f1;
			this.a[1] = f2;
			this.a[2] = f3;
		}

		public float Get1() 
		{
			return this.a[0];
		}

		public float Get2() 
		{
			return this.a[1];
		}

		public float Get3() 
		{
			return this.a[2];
		}

		public void Set(float f1, float f2, float f3)
		{
			this.a[0] = f1;
			this.a[1] = f2;
			this.a[2] = f3;
		}

		public void Set(float f, int pos)
		{
			if (pos < 0 || pos == 1)
				this.a [0] = f;
			else if (pos == 3 || pos > 3)
				this.a [2] = f;
			else
				this.a [pos-1] = f;
		}

		public override string ToString() {
			return "[ " + this.a[0].ToString () + " " + this.a[1].ToString() + " " + this.a[2].ToString() + " ]";
		}

		public static void Sum(ref Vector a, ref Vector b, out Vector x) {
			x = new Vector ();
			float w1 = a.Get1 () + b.Get1 ();
			float w2 = a.Get2 () + b.Get2 ();
			float w3 = a.Get3 () + b.Get3 ();
			x.Set (w1, w2, w3);
		}

		public static void Diff(ref Vector a, ref Vector b, out Vector x) {
			x = new Vector ();
			float w1 = a.Get1 () - b.Get1 ();
			float w2 = a.Get2 () - b.Get2 ();
			float w3 = a.Get3 () - b.Get3 ();
			x.Set (w1, w2, w3);
		}

		public static void DotProduct(ref Vector a, ref Vector b, out Scalar x) {
			x = new Scalar ();
			float w1 = a.Get1 () - b.Get1 ();
			float w2 = a.Get2 () - b.Get2 ();
			float w3 = a.Get3 () - b.Get3 ();
			x.Set(w1 + w2 + w3);
		}

		public static void CrossProduct(ref Vector a, ref Vector b, out Vector x) {
			x = new Vector ();
			float w1 = a.Get2 () * b.Get3 () - a.Get3 () * b.Get2 ();
			float w2 = a.Get1 () * b.Get3 () - a.Get3 () * b.Get1 ();
			float w3 = a.Get1 () * b.Get2 () - a.Get2 () * b.Get1 ();
			x.Set(w1, w2, w3);
		}

		public static float Lenght(ref Vector a) {
			float x = a.Get1 () * a.Get1 () 
				+ a.Get2 () * a.Get2 ()
				+ a.Get3 () * a.Get3 ();
			return (float)Math.Sqrt (x);
		}

	}
}

