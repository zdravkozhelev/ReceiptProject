using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;


namespace RecepiesTest
{
    public class Test01
    {
        [TestCase]
        public void AddShouldProduct() 
        {
            var reciespt = new Receipts("Спагети", "Спагети, глава лук, олио, доматено пюре, кайма, риган, сол, захар, черен пипер", "Запържваме лука докато умекне. След това слагаме каймата да получи лек цвят и после слагаме доматеното пюре с всички подправки. През това време завираме вода за спагетите, в която слагаме по една супена лъжица сон на 3 литра вода.","Здравко Желев");

            
        }
    }
}
