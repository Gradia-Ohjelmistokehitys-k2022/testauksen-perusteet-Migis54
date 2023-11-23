using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingTodoListApp
{
    public class TodoList
    {

        private readonly List<TodoTask> _todoItems;
        private int _taskCounter = 1;
        public IEnumerable<TodoTask> All => _TodoItems; //https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.all?view=net-6.0
        public List<TodoTask> _TodoItems { get => _todoItems;}
       

        public TodoList()
        {
            _todoItems = new List<TodoTask>();
            string defaultTask = $"Task number {_taskCounter}";
            TodoTask item = new(defaultTask);
        }

        public void AddItemToList(TodoTask item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item is null");
            }
            if (item.TaskDescription == string.Empty)
            {
                throw new ArgumentException("Task lacks name");
            }
            if (_todoItems.Count > 3)
            {
                throw new ArgumentOutOfRangeException("too many items");
            }
            
            _todoItems.Add(item with { Id = _taskCounter++ });
            

        }

        public void RemoveItemFromList(TodoTask item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item is null");
            }
            if (!_todoItems.Contains(item))
            {
                throw new ArgumentOutOfRangeException("item doesn't exist");
            }
            _todoItems.Remove(item with { Id = _taskCounter--});
            
            if (!_todoItems.Contains(item))
            {
                throw new ArgumentOutOfRangeException("didnt remove item");
            }

        }

        public void CompleteItem(int id)
        {
            if (_todoItems.Count == 0)
            {
                throw new ArgumentException("TaskList is empty");
            }
            if (!_todoItems.Any(x => x.Id == id))
            {
                throw new ArgumentOutOfRangeException("idk");
            }
            var item = _todoItems.First(x => x.Id == id);
            if (_todoItems.First(x => x.Id == id).IsCompleted)
            {
                throw new ArgumentException("already completed");
            }
            item.IsCompleted = true;
            // remove the item
            
            RemoveItemFromList(item);
        }
    }
}
