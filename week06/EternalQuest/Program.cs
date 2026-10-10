using System;

// Exceeds requirements: When a goal is completed (a simple goal is done, or
// a checklist goal reaches its target and earns its bonus), the program
// shows a celebration banner of stars. Eternal goals never complete, so
// they never trigger it.
class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}