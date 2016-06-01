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
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void setOperationOnScalar (object sender, EventArgs e)
	{
		if (comboboxScalar.ActiveText == "Suma") {
			Scalar.Sum (ref this.a, ref this.b, out this.x);
			this.textviewScalar.Buffer.Text += "Wynik sumowania wartości skalarnych " + this.a.ToString () + " i " + this.b.ToString () + " to " + this.x.ToString () + "\n";
		} else if (comboboxScalar.ActiveText == "Iloczyn") {

		    this.textviewScalar.Buffer.Text += "Iloczyn to ...\n";

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

	protected void setOperationOnVector (object sender, EventArgs e)
	{
		if (comboboxVector.ActiveText == "Suma") {
			Vector.Sum (ref this.c, ref this.d, out this.y);
			this.textviewVector .Buffer.Text += "Suma wektorów " + this.c.ToString () + " i " + this.d.ToString () + " to " + this.y.ToString () + "\n";
		} else if (comboboxScalar.ActiveText == "Iloczyn") {

			this.textviewScalar.Buffer.Text += "Iloczyn to ...\n";

		}
	}
}
