using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RecepiesTest
{
    public class Test01
    {
        [TestCase]
        //Проверка на метода Add без Moq и добавя в базата и не се използва
        public void AddShouldProduct() 
        {
            var reciept = new Receipts("Спагети", "Спагети, глава лук, олио, доматено пюре, кайма, риган, сол, захар, черен пипер", "Запържваме лука докато умекне. След това слагаме каймата да получи лек цвят и после слагаме доматеното пюре с всички подправки. През това време завираме вода за спагетите, в която слагаме по една супена лъжица сон на 3 литра вода.","Здравко Желев");
            var context = new ReceiptContext();
            var controller = new ReceiptController(context);
            //controller.Add(reciept);

        }
        //Проверка за съвпадение по име.
        [TestCase]
        public void GetAllReceipts_orders_by_name()
        {
            var data = new List<Receipts>
            {
                new Receipts ("ааа", "ааа", "ааа","ааа"),
                new Receipts ("ббб","ббб","ббб","ббб" ),
                new Receipts ("ввв","ввв","ввв","ввв" ),
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Receipts>>();
            mockSet.As<IQueryable<Receipts>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Receipts>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Receipts>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Receipts>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<ReceiptContext>();
            mockContext.Setup(mockContext => mockContext.Receipts).Returns(mockSet.Object);

            var service = new ReceiptController(mockContext.Object);
            var receipts = service.Get(0);

            //Assert.AreEqual(3, blogs.Count);
            Assert.AreEqual("ааа", "ааа", "ааа", "ааа", receipts);
            //Assert.AreEqual("ббб", "ббб", "ббб", "ббб", receipts[1]);
            //Assert.AreEqual("ввв", "ввв", "ввв", "ввв",receipts[2]);
        }
        //Проверка за брой продукти в базата
        public void GetReceipts_counts()
        {
            var data = new List<Receipts>
            {
                new Receipts ("ааа", "ааа", "ааа","ааа"),
                new Receipts ("ббб","ббб","ббб","ббб" ),
                new Receipts ("ввв","ввв","ввв","ввв" ),
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Receipts>>();
            mockSet.As<IQueryable<Receipts>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Receipts>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Receipts>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Receipts>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<ReceiptContext>();
            mockContext.Setup(mockContext => mockContext.Receipts).Returns(mockSet.Object);

            var service = new ReceiptController(mockContext.Object);
            var receipts = service.GetAll();

            //Assert.AreEqual(3, blogs.Count);
            Assert.AreEqual("ааа", "ааа", "ааа", "ааа", receipts.Count);
            Assert.AreEqual("ббб", "ббб", "ббб", "ббб", receipts.Count);
            Assert.AreEqual("ввв", "ввв", "ввв", "ввв", receipts.Count);
        }

    }
}
