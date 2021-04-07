using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using UniversityLib;
namespace UniversityTestUnits
{
    [TestClass]
    public class StudentTestUnit
    {
        [TestMethod]
        public void ConstructorTestMethod()
        {
            var ivan = CreateTestStudent();
            Assert.AreEqual("Ivan", ivan.Name);
            Assert.AreEqual("Ivanov", ivan.Surname);
            Assert.AreEqual(12345678, ivan.CardID);
            Assert.AreEqual("УГИ-123456", ivan.Group);
            Assert.AreEqual("Гуманитарный институт", ivan.Institute);
            Assert.AreEqual(TypeOfEducation.Bachelor, ivan.EduType);
        }
        [TestMethod]
        public void ToStringTestMethod()
        {
            var ivan = CreateTestStudent();
            Assert.AreEqual("Ivan Ivanov", ivan.ToString());
        }
        [TestMethod]
        public void PrintInfoTestMethod()
        {
            
            var ivan = CreateTestStudent();
            var tanya = new Student("Tanya", "Kuznetsova", 135792468, "ИРИТ-3333", "Институт радиотехнологий", TypeOfEducation.Master);
            var consoleOut = new[] { "Ivan Ivanov", $"Номер зачетной книжки: 12345678. Группа: УГИ-123456. Институт: Гуманитарный институт. Направление обучения: бакалавриат." ,"Tanya Kuznetsova", $"Номер зачетной книжки: 135792468. Группа: ИРИТ-3333. Институт: Институт радиотехнологий. Направление обучения: магистратура." };

         
            TextWriter oldOut = Console.Out;
            StringWriter output = new StringWriter();
            Console.SetOut(output); 
            ivan.PrintInfo();
            tanya.PrintInfo();
            Console.SetOut(oldOut); 
            var outputArray = output.ToString().Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries); 

            
            Assert.AreEqual(4, outputArray.Length);
            for (var i = 0; i < consoleOut.Length; i++)
                Assert.AreEqual(consoleOut[i], outputArray[i]);
        }
        private Student CreateTestStudent()
        {
            return new Student("Ivan", "Ivanov", 12345678, "УГИ-123456", "Гуманитарный институт", TypeOfEducation.Bachelor);
        }
    }
}
