using System;
using Gtk;
using Zaliczenie2;

public partial class MainWindow: Gtk.Window
{
	Scalar scalarA, scalarB, scalarX;
	Vector vectorA, vectorB, vectorX;
	Matrix MatrixA, MatrixB, MatrixX;

	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
		scalarA = new Scalar ();
		scalarB = new Scalar ();

		vectorA = new Vector ();
		vectorB = new Vector ();

		MatrixA = new Matrix ();
		MatrixB = new Matrix ();
	
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
		

	protected void changedScalarA (object sender, EventArgs e)
	{
		this.scalarA.Set((float)Convert.ToDouble (this.entryScalar1.Text));
	}

	protected void changedScalarB (object sender, EventArgs e)
	{
		this.scalarB.Set ((float)Convert.ToDouble (this.entryScalar2.Text));
	}

	protected void changedVectorA_1 (object sender, EventArgs e)
	{
		this.vectorA.Set ((float)Convert.ToDouble(this.entryVector1_1.Text), 1);
	}

	protected void changedVectorA_2 (object sender, EventArgs e)
	{
		this.vectorA.Set ((float)Convert.ToDouble(this.entryVector1_2.Text), 2);
	}

	protected void changedVectorA_3 (object sender, EventArgs e)
	{
		this.vectorA.Set ((float)Convert.ToDouble(this.entryVector1_3.Text), 3);
	}

	protected void changedVectorB_1 (object sender, EventArgs e)
	{
		this.vectorB.Set ((float)Convert.ToDouble(this.entryVector2_1.Text), 1);
	}

	protected void changedVectorB_2 (object sender, EventArgs e)
	{
		this.vectorB.Set ((float)Convert.ToDouble(this.entryVector2_2.Text), 2);
	}

	protected void changedVectorB_3 (object sender, EventArgs e)
	{
		this.vectorB.Set ((float)Convert.ToDouble(this.entryVector2_3.Text), 3);
	}

	void doScalarSum ()
	{
		Scalar.Sum (ref this.scalarA, ref this.scalarB, out this.scalarX);
		this.textviewScalar.Buffer.Text += "Wynik sumowania wartości skalarnych " 
			+ this.scalarA.ToString () + " i " 
			+ this.scalarB.ToString () + " to " 
			+ this.scalarX.ToString () + "\n";
	}

	void doScalarMultiplication ()
	{
		Scalar.Multiplication (ref this.scalarA, ref this.scalarB, out this.scalarX);
		this.textviewScalar.Buffer.Text += "Iloczyn wartości skalarnych " 
			+ this.scalarA.ToString () + " i " 
			+ this.scalarB.ToString () + " to " 
			+ this.scalarX.ToString () + "\n";
	}

	void doScalarDivide ()
	{
		Scalar.Divide (ref this.scalarA, ref this.scalarB, out this.scalarX);
		this.textviewScalar.Buffer.Text += "Iloraz wartości skalarnych " 
			+ this.scalarA.ToString () + " i " 
			+ this.scalarB.ToString () + " to " 
			+ this.scalarX.ToString () + "\n";
	}

	void doVectorSum ()
	{
		Vector.Sum (ref this.vectorA, ref this.vectorB, out this.vectorX);
		this.textviewVector.Buffer.Text += "Suma wektorów " 
			+ this.vectorA.ToString () + " i " 
			+ this.vectorB.ToString () + " to " 
			+ this.vectorX.ToString () + "\n";
	}

	void doVectorDiff ()
	{
		Vector.Diff (ref this.vectorA, ref this.vectorB, out this.vectorX);
		this.textviewVector.Buffer.Text += "Różnica wektorów " 
			+ this.vectorA.ToString () + " i " 
			+ this.vectorB.ToString () + " to " 
			+ this.vectorX.ToString () + "\n";
	}

	void doDotProduct ()
	{
		Vector.DotProduct (ref this.vectorA, ref this.vectorB, out this.scalarX);
		this.textviewVector.Buffer.Text += "Iloczyn skalarny " 
			+ this.vectorA.ToString () + " i " 
			+ this.vectorB.ToString () + " to " 
			+ this.scalarX.ToString () + "\n";
	}

	void doVectorProduct ()
	{
		Vector.CrossProduct (ref this.vectorA, ref this.vectorB, out this.vectorX);
		this.textviewVector.Buffer.Text += "Iloczyn wektorowy " 
			+ this.vectorA.ToString () + " i " 
			+ this.vectorB.ToString () + " to " 
			+ this.vectorX.ToString () + "\n";
	}

	void doVectorLenght ()
	{
		this.textviewVector.Buffer.Text += "Długośc wektora 1:  " 
			+ Vector.Lenght (ref vectorA).ToString () + "\n";
	}

	protected void setOperationScalar (object sender, EventArgs e)
	{
		if (comboboxScalar.Active == 0) {
			doScalarSum ();
		} else if (comboboxScalar.Active == 1) {
			doScalarMultiplication ();
		} else if (comboboxScalar.Active == 2) {
			doScalarDivide ();
		}
	}

	protected void setOperationVector (object sender, EventArgs e)
	{
		if (comboboxVector.Active == 0) {
			doVectorSum ();
		} else if (comboboxVector.Active == 1) {
			doVectorDiff ();
		} else if (comboboxVector.Active == 2) {
			doDotProduct ();
		} else if (comboboxVector.Active == 3) {
			doVectorProduct ();
		} else if (comboboxVector.Active == 4) {
			doVectorLenght ();
		}
	}

	protected void setOperationMatrix (object sender, EventArgs e)
	{
		/////////////////
		/// do uzupełnienia
	}
}
