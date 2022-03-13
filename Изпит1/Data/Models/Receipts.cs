using System;


	
	public	class Receipts
    {
		public int Id { get; set; }
		public string Integrity { get; set; }
		public string Author { get; set; }
		public double Datee { get; set; }
		public string Name { get; set; }
    public int Stock { get; internal set; }
    public decimal Price { get; internal set; }

    public Receipts(int id, string integrity, string author, int datee, string name)
        {
			this.Id = id;
			this.Integrity = integrity;
			this.Author = author;
			this.Datee = datee;
			this.Name = name;
        }

    public Receipts()
    {
    }
}

