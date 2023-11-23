using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TestingTodoListApp
{
    public record TodoTask(string TaskDescription) // ota selvää recordin toiminnasta
    {
        public int Id { get; set;} //setteri gang voittaa
        public bool IsCompleted { get; set;}
        public override string ToString()
        {
            return $"Id: {Id} + Task: {TaskDescription} + Did you do it?: {IsCompleted}";
        }
    }

}





