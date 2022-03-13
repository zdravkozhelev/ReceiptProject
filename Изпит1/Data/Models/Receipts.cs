using System;


	
	public	class Receipts
    {
    
    

    
		public int Id { get; set; }
    public string Name { get; set; }
    public string Products { get; set; }
    public string Description { get; set; }
    public string Author { get; internal set; }


    public Receipts( string name, string products, string description, string author)
        {
		
		    this.Name = name;
			this.Products = products;
            this.Description = description;
            this.Author = author;
        }

    public Receipts()
    {
    }
}

