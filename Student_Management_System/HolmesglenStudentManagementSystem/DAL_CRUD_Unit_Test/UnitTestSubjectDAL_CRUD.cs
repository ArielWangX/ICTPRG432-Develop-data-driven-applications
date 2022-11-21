using HolmesglenStudentManagementSystem.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DAL_CRUD_Unit_Test
{
    [TestClass]
    public class UnitTestSubjectDAL_CRUD
    {
        [TestMethod]
        public void TestCase_Create()
        {
        }

        [TestMethod]
        public void TestCase_Read()
        {
            // Arrange
            var expectGetOneSubject = new Subject();
            var subjectID = "Su0003";
            double expect = ;
            // Act
            
            // Assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void TestCase_ReadAll()
        {
        }

        [TestMethod]
        public void TestCase_Update()
        {
        }

        [TestMethod]
        public void TestCase_Delete()
        {
        }
    }
}
