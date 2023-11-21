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
        public void AddItemList_IfTodoListHasTooManyItems_ThrowException()
        {
            TodoList todoList = new TodoList(); 
            try
            {
                todoList.AddItemToList(new TodoTask("joo"));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                StringAssert.Contains(ex.Message, "too many items");
                return;
            }
        }

        [TestMethod()]
        public void AddItemToList()
        {
            TodoList todoList = new TodoList();
            try
            {
                todoList.AddItemToList(new TodoTask(""));
            }
            catch (ArgumentException ex)
            {
                StringAssert.Contains(ex.Message, "Task lacks name");
                return;
            }
            
            
        }
        [TestMethod()]
        public void AddItemToList_IfTaskIsNull_ThrowArgurment()
        {
            TodoList todoList = new TodoList();
            try
            {
                TodoTask todoTask = new TodoTask("astiat");
                todoTask = null;
                todoList.AddItemToList(todoTask);
            }
            catch (ArgumentNullException ex)
            {
                StringAssert.Contains(ex.Message, "item is null"));
                Assert.Fail();
            }
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
            
            Assert.Fail("lol");

        }
    }
}