using System;
using Gtk;
using Zaliczenie2;

public partial class MainWindow: Gtk.Window
{
	Scalar a, b, x;
	Vector c, d, y;
	//Matrix

	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
		a = new Scalar ();
		b = new Scalar ();

		c = new Vector ();
		d = new Vector ();

		//testowanie
		//Vector testA = new Vector();
		//Console.WriteLine ("Wektor 0,0,0: " + testA.ToString());
		//testA.Set (1, 2, 3);
		//Console.WriteLine ("Wektor 1,2,3: " + testA.ToString());
		//Console.WriteLine ("Długość: " + Vector.Lenght(ref testA).ToString());


	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void setOperationOnScalar (object sender, EventArgs e)
	{
		if (comboboxScalar.Active == 0) {
			Scalar.Sum (ref this.a, ref this.b, out this.x);
			this.textviewScalar.Buffer.Text += "Wynik sumowania wartości skalarnych " + this.a.ToString () + " i " + this.b.ToString () + " to " + this.x.ToString () + "\n";
		} else if (comboboxScalar.Active == 1) {
			Scalar.Multiplication (ref this.a, ref this.b, out this.x);
			this.textviewScalar.Buffer.Text += "Iloczyn wartości skalarnych " + this.a.ToString () + " i " + this.b.ToString () + " to " + this.x.ToString () + "\n";
		} else if (comboboxScalar.Active == 2) {
			Scalar.Divide (ref this.a, ref this.b, out this.x);
			this.textviewScalar.Buffer.Text += "Iloraz wartości skalarnych " + this.a.ToString () + " i " + this.b.ToString () + " to " + this.x.ToString () + "\n";
		}
	}

	protected void changedA (object sender, EventArgs e)
	{
		this.a.Set((float)Convert.ToDouble (this.entryScalar1.Text));
	}

	protected void changedB (object sender, EventArgs e)
	{
		this.b.Set ((float)Convert.ToDouble (this.entryScalar2.Text));
	}

	protected void changedA_1 (object sender, EventArgs e)
	{
		this.c.Set ((float)Convert.ToDouble(this.entryVector1_1.Text), 1);
	}

	protected void changedA_2 (object sender, EventArgs e)
	{
		this.c.Set ((float)Convert.ToDouble(this.entryVector1_2.Text), 2);
	}

	protected void changedA_3 (object sender, EventArgs e)
	{
		this.c.Set ((float)Convert.ToDouble(this.entryVector1_3.Text), 3);
	}

	protected void changedB_1 (object sender, EventArgs e)
	{
		this.d.Set ((float)Convert.ToDouble(this.entryVector2_1.Text), 1);
	}

	protected void changedB_2 (object sender, EventArgs e)
	{
		this.d.Set ((float)Convert.ToDouble(this.entryVector2_2.Text), 2);
	}

	protected void changedB_3 (object sender, EventArgs e)
	{
		this.d.Set ((float)Convert.ToDouble(this.entryVector2_3.Text), 3);
	}

	void sum ()
	{
		Vector.Sum (ref this.c, ref this.d, out this.y);
		this.textviewVector.Buffer.Text += "Suma wektorów " + this.c.ToString () + " i " + this.d.ToString () + " to " + this.y.ToString () + "\n";
	}

	void diff ()
	{
		Vector.Diff (ref this.c, ref this.d, out this.y);
		this.textviewVector.Buffer.Text += "Różnica wektorów " + this.c.ToString () + " i " + this.d.ToString () + " to " + this.y.ToString () + "\n";
	}

	void dot_product ()
	{
		Vector.DotProduct (ref this.c, ref this.d, out this.x);
		this.textviewVector.Buffer.Text += "Iloczyn skalarny " + this.c.ToString () + " i " + this.d.ToString () + " to " + this.x.ToString () + "\n";
	}

	void cross_product ()
	{
		Vector.CrossProduct (ref this.c, ref this.d, out this.y);
		this.textviewVector.Buffer.Text += "Iloczyn wektorowy " + this.c.ToString () + " i " + this.d.ToString () + " to " + this.y.ToString () + "\n";
	}

	void lenght ()
	{
		this.textviewVector.Buffer.Text += "Długośc wektora 1:  " + Vector.Lenght (ref c).ToString () + "\n";
	}

	protected void setOperationOnVector (object sender, EventArgs e)
	{
		if (comboboxVector.Active == 0) {
			sum ();
		} else if (comboboxVector.Active == 1) {
			diff ();
		} else if (comboboxVector.Active == 2) {
			dot_product ();
		} else if (comboboxVector.Active == 3) {
			cross_product ();
		} else if (comboboxVector.Active == 4) {
			lenght ();
		}
	}
}
