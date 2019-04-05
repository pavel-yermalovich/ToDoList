namespace ToDoList.Core.Commands
{
    public class CommandParser
    {
        public ICommand ParseCommand(string[] args)
        {
            return new NotFoundCommand();
        }
    }
}
