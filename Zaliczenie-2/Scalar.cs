using System;

namespace Zaliczenie2
{
	public class Scalar
	{
		float a;

		public Scalar ()
		{
			this.a = 0.0f;
		}

		public Scalar (float f)
		{
			this.a = f;
		}

		public float Get() 
		{
			return this.a;
		}

		public void Set(float f)
		{
			this.a = f;
		}

		public override string ToString() {
			return this.a.ToString ();
		}

		public static void Sum(ref Scalar a, ref Scalar b, out Scalar x) {
			x = new Scalar ();
			x.Set (a.Get () + b.Get ());
		}

		public static void Multiplication(ref Scalar a, ref Scalar b, out Scalar x) {
			x = new Scalar ();
			x.Set (a.Get () * b.Get ());
		}

		public static void Divide(ref Scalar a, ref Scalar b, out Scalar x) {
			x = new Scalar ();
			x.Set (a.Get () / b.Get ());
		}
			
	}
}

