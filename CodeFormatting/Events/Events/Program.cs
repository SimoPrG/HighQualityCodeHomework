using System;
using System.Text;

public class Program
{
    private static readonly StringBuilder Output = new StringBuilder();

    private static class Messages
    {
        public static void EventAdded()
        {
            Output.Append("Event added\n");
        }

        public static void EventDeleted(int x)
        {
            if (x == 0)
            {
                NoEventsFound();
            }
            else
            {
                Output.AppendFormat("{0} events deleted\n", x);
            }
        }

        public static void NoEventsFound()
        {
            Output.Append("No events found\n");
        }

        public static void PrintEvent(Events eventToPrint)
        {
            if (eventToPrint != null)
            {
                Output.Append(eventToPrint + "\n");
            }
        }
    }

    internal class EventHolder
    {
        private MultiDictionary<string, Events> byTitle = new MultiDictionary<string, Events>(true);
        private OrderedBag<Events> byDate = new OrderedBag<Events>();

        public void AddEvent(DateTime date, string title, string location)
        {
            Events newEvent = new Events(date, title, location);
            byTitle.Add(title.ToLower(), newEvent);
            byDate.Add(newEvent); Messages.EventAdded();
        }

        public void DeleteEvents(string titleToDelete)
        {
            string title = titleToDelete.ToLower();
            int removed = 0;
            foreach (var eventToRemove in byTitle[title])
            {
                removed++;
                byDate.Remove(eventToRemove);
            }

            byTitle.Remove(title);
            Messages.EventDeleted(removed);
        }

        public void ListEvents(DateTime date, int count)
        {
            OrderedBag<Events>.View
                eventsToShow = byDate.RangeFrom(new Events(
                    date, "", ""),
                    true);
            int showed = 0;
            foreach (var eventToShow in eventsToShow)
            {
                if (showed == count)
                {
                    break;
                }

                Messages.PrintEvent(eventToShow);

                showed++;
            }

            if (showed == 0)
            {
                Messages.NoEventsFound();
            }
        }
    }
    
    private static EventHolder events = new EventHolder();

    public static void Main(string[] args)
    {
        while (ExecuteNextCommand())
        {
        }

        Console.WriteLine(Output);
    }

    private static bool ExecuteNextCommand()
    {
        string command = Console.ReadLine();
        if (command[0] == 'A')
        {
            AddEvent(command); return true;
        }

        if (command[0] == 'D')
        {
            DeleteEvents(command); return true;
        }

        if (command[0] == 'L')
        {
            ListEvents(command); return true;
        }

        if (command[0] == 'E')
        {
            return false;
        }

        return false;
    }

    private static void ListEvents(string command)
    {
        int pipeIndex = command.IndexOf('|');
        DateTime date = GetDate(command,"ListEvents");
        string countString = command.Substring(pipeIndex + 1);
        int count = int.Parse(countString);
        events.ListEvents(date,count);
    }

    private static void DeleteEvents(string command)
    {
        string title = command.Substring("DeleteEvents".Length + 1);

        events.DeleteEvents(title);
    }

    private static void AddEvent(string command)
    {
        DateTime date; string title; string location;
        GetParameters(command, "AddEvent",
            out date, out title, out location);

        events.AddEvent
            (date, title, location);
    }

    private static void GetParameters(string commandForExecution, string commandType, out DateTime dateAndTime, out string eventTitle, out string eventLocation)
    {
        dateAndTime = GetDate(commandForExecution, commandType);
        int firstPipeIndex = commandForExecution.IndexOf('|');
        int lastPipeIndex = commandForExecution.LastIndexOf('|');

        if (firstPipeIndex == lastPipeIndex)
        {
            eventTitle = commandForExecution.Substring(firstPipeIndex + 1).Trim();
            eventLocation = "";
        }
        else
        {
            eventTitle = commandForExecution.Substring(firstPipeIndex + 1, lastPipeIndex - firstPipeIndex - 1).Trim();
            eventLocation = commandForExecution.Substring(lastPipeIndex + 1).Trim();
        }
    }

    private static DateTime GetDate(string command, string commandType)
    {
        DateTime date = DateTime.Parse(command.Substring(commandType.Length + 1, 20));
        return date;
    }
}