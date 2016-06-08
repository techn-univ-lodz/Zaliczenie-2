using System;
using Zaliczenie2;

namespace Zaliczenie2
{
	public class Vector
	{
		float[] a;

		//dlugosc wektora
		//przy rozbudowie klasy mozna
		//przekazawyc np. w konstruktorze
		private const int L = 3;

		public Vector ()
		{
			a = new float [L];
			for (int i = 0; i < L; i++)
				this.a [i] = 0;
		}

		public Vector (float f1, float f2, float f3)
		{
			this.a [0] = f1;
			this.a [1] = f2;
			this.a [2] = f3;
		}

		//uwaga - numeracja składowych od 1!!
		public float Get (int pos)
		{
			float r;

			if (pos < 0 || pos == 1)
				r = this.a [0];
			else if (pos == L || pos > L)
				r = this.a [2];
			else
				r = this.a [pos - 1];
				
			return r;
		}

		public void Set (float f1, float f2, float f3)
		{
			this.a [0] = f1;
			this.a [1] = f2;
			this.a [2] = f3;
		}

		//uwaga - numeracja składowych od 1!!
		public void Set (float f, int pos)
		{
			if (pos < 0 || pos == 1)
				this.a [0] = f;
			else if (pos == L || pos > L)
				this.a [2] = f;
			else
				this.a [pos - 1] = f;
		}

		public override string ToString ()
		{
			string r = "[";
			for (int i = 0; i < L; i++)
				r += " " + this.a [i].ToString () + ", ";
			return r + "]";
		}

		public static void Sum (ref Vector a, ref Vector b, out Vector x)
		{
			float w1 = a.Get (1) + b.Get (1);
			float w2 = a.Get (2) + b.Get (2);
			float w3 = a.Get (3) + b.Get (3);

			x = new Vector ();
			x.Set (w1, w2, w3);
		}

		public static void Diff (ref Vector a, ref Vector b, out Vector x)
		{
			float w1 = a.Get (1) - b.Get (1);
			float w2 = a.Get (2) - b.Get (2);
			float w3 = a.Get (3) - b.Get (3);

			x = new Vector ();
			x.Set (w1, w2, w3);
		}

		public static void DotProduct (ref Vector a, ref Vector b, out Scalar x)
		{
			float w1 = a.Get (1) - b.Get (1);
			float w2 = a.Get (2) - b.Get (2);
			float w3 = a.Get (3) - b.Get (3);

			x = new Scalar ();
			x.Set (w1 + w2 + w3);
		}

		public static void CrossProduct (ref Vector a, ref Vector b, out Vector x)
		{
			float w1 = a.Get (2) * b.Get (3) - a.Get (3) * b.Get (2);
			float w2 = a.Get (1) * b.Get (3) - a.Get (3) * b.Get (1);
			float w3 = a.Get (1) * b.Get (2) - a.Get (2) * b.Get (1);

			x = new Vector ();
			x.Set (w1, w2, w3);
		}

		public static float Lenght (ref Vector a)
		{
			float x = a.Get (1) * a.Get (1)
			          + a.Get (2) * a.Get (2)
			          + a.Get (3) * a.Get (3);

			return (float)Math.Sqrt (x);
		}

	}
}

