using System;
using System.Collections.Generic;
using System.Linq;

class ReceiptController
{
    private ReceiptContext receiptContext;

    Receipts receipts = new Receipts();
    public List<Receipts> GetAll()
    {
        using (receiptContext = new ReceiptContext())
        {
            return receiptContext.Receipts.ToList();
        }
    }

    public Receipts Get(int id)
    {
        using (receiptContext = new ReceiptContext())
        {
            return receiptContext.Receipts.Find(id);
        }
    }
    public void Add(Receipts receipt)
    {
        using (receiptContext = new ReceiptContext())
        {
            receiptContext.Receipts.Add(receipt);
            receiptContext.SaveChanges();
        }
    }

    public void Update(Receipts receipt)
    {
        using (receiptContext = new ReceiptContext())
        {
            var item = receiptContext.Receipts.Find(receipt.Id);
            if (item != null)
            {
                receiptContext.Entry(item).CurrentValues.SetValues(receipt);
                receiptContext.SaveChanges();
            }
        }
    }

    public void Delete(int id)
    {
        using (receiptContext = new ReceiptContext())
        {
            var receipt = receiptContext.Receipts.Find(id);
            if (receipt != null)
            {
                receiptContext.Receipts.Remove(receipt);
                receiptContext.SaveChanges();
            }
        }
    }
}

