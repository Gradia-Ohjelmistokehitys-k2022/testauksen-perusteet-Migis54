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
        public void AddItemList_IfTodoListHasTooManyItems_ThrowArgumentOutOfRangeException()
        {
            TodoList todoList = new TodoList();
            try
            {
                todoList.AddItemToList(new TodoTask("joo1"));
                todoList.AddItemToList(new TodoTask("joo2"));
                todoList.AddItemToList(new TodoTask("joo3"));
                todoList.AddItemToList(new TodoTask("joo4"));
                todoList .AddItemToList(new TodoTask("e"));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                StringAssert.Contains(ex.Message, "too many items");
                return;
            }
            Assert.Fail();
        }

        [TestMethod()]
        public void AddItemToList_IfTaskLacksName_ThrowArgumentException()
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
            Assert.Fail();

        }
        [TestMethod()]
        public void AddItemToList_IfTaskIsNull_ThrowArgurmentNullException()
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
                StringAssert.Contains(ex.Message, "item is null");
                return;
            }
            Assert.Fail();
        }
        [TestMethod()]
        public void RemoveItemFromList_IfItemDoesntExist_ThrowArgumentOutOfRangeExceptionException()
        {
            TodoList todoList = new TodoList();
            TodoTask todoTask = new TodoTask("astiat");
            todoList.AddItemToList(todoTask);
            try
            {
                
                todoList.RemoveItemFromList(todoTask);
               
            }
            catch(ArgumentOutOfRangeException ex)
            {
                StringAssert.Contains(ex.Message, "item doesn't exist");
                return;
            }
            Assert.Fail();
        }
        [TestMethod()]
        public void RemoveItemFromList_IfTaskIsNull_ThrowArgumentNullException()
        {
            TodoList todoList = new TodoList();
            TodoTask todoTask = new TodoTask("astiat");
            
            todoList.AddItemToList(todoTask);
            try
            {
                todoTask = null;
                todoList.RemoveItemFromList(todoTask);

            }
            catch (ArgumentNullException ex)
            {
                StringAssert.Contains(ex.Message, "item is null");
                return;
            }
            Assert.Fail();
        }
        [TestMethod()]
        public void RemoveItemFromList_IfDoesntRemoveItem_ThrowArgumentOutOfRangeException()
        {
            TodoList todoList = new TodoList();
            TodoTask todoTask = new TodoTask("astiat");
            todoList.AddItemToList(todoTask);
            try
            {
                todoList.RemoveItemFromList(todoTask);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                StringAssert.Contains(ex.Message, "didnt remove item");
                return;
            }
            Assert.Fail();
        }
        [TestMethod()]
        public void CompleteItem_IfIdDoesntExist_ThrowArgumentOutOfRangeException()
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
        [TestMethod()]
        public void CompleteItem_IftodoItemtEmpty_ThrowArgumentException()
        {
            TodoList todoList = new TodoList();
            try
            {
                todoList.CompleteItem(1);
            }
            catch (ArgumentException ex)
            {
                StringAssert.Contains(ex.Message, "TaskList is empty");
                return;
            }
            Assert.Fail();
        }

        [TestMethod()]
        public void CompleteItem_IfTaskCompletedAlready_ThrowArgumentException()
        {
            TodoList todoList = new TodoList();
            todoList.AddItemToList(new TodoTask("Do the dishes"));
            todoList.CompleteItem(1);
            try
            {
                todoList.CompleteItem(1);
            }
            catch(ArgumentException ex)
            {
                StringAssert.Contains(ex.Message, "already completed");
                return;
            }
            Assert.Fail("lol");

        }
    }
}