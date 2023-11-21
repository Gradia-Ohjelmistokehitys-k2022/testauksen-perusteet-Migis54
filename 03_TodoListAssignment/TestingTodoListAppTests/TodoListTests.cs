using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingTodoListApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingTodoListApp.Tests
{
    [TestClass()]
    public class TodoListTests
    {

        [TestMethod()]
        public void AddItemToList()
        {
            TodoList todoList = new TodoList();
            try
            {
                todoList.AddItemToList(new TodoTask("Wash your clothes"));
            }
            catch (ArgumentException ex)
            {
                StringAssert.Contains(ex.Message, "Task lacks name");
            }
            Assert.Fail();
        }

        [TestMethod()]
        public void RemoveItemFromList()
        {
            
        }

        [TestMethod()]
        public void CompleteItem_IfIdDoesntExist_ThrowException()
        {
            TodoList todoList = new TodoList();
            todoList.AddItemToList(new TodoTask("Do the dishes"));
            todoList.AddItemToList(new TodoTask("Wash your clothes"));
            try
            {
                todoList.CompleteItem(3);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                StringAssert.Contains(ex.Message, "idk");
                return;
            }
            try
            {
                todoList.CompleteItem(1);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                StringAssert.Contains(ex.Message, "too many items");
            }
            Assert.Fail("lol");

        }
    }
}