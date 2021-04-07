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
            Assert.AreEqual("���-123456", ivan.Group);
            Assert.AreEqual("������������ ��������", ivan.Institute);
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
            var tanya = new Student("Tanya", "Kuznetsova", 135792468, "����-3333", "�������� ���������������", TypeOfEducation.Master);
            var consoleOut = new[] { "Ivan Ivanov", $"����� �������� ������: 12345678. ������: ���-123456. ��������: ������������ ��������. ����������� ��������: �����������." ,"Tanya Kuznetsova", $"����� �������� ������: 135792468. ������: ����-3333. ��������: �������� ���������������. ����������� ��������: ������������." };

         
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
            return new Student("Ivan", "Ivanov", 12345678, "���-123456", "������������ ��������", TypeOfEducation.Bachelor);
        }
    }
}
