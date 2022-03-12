using System;

public class Class1
{
	public Class1()
	{
		class Receipts
    {
		public int Id { get; set; }
		public string Integrity { get; set; }
		public string Author { get; set; }
		public double Datee { get; set; }
		public string Name { get; set; }

		
		public Receipts(int id, string integrity, decimal author, int datee, string name)
        {
			this.Id = id;
			this.Integrity = integrity;
			this.Author = author;
			this.Datee = datee;
			this.Name = name;
        }
    }
	}
}
