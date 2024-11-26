using _9lesson.Models;

namespace _9lesson.Services;

public class EventServices
{
    private List<Event> events;

    public EventServices()
    {
        events = new List<Event>();
    }
    public Event AddEvent(Event newEvent)
    {
        newEvent.Id = Guid.NewGuid();
        events.Add(newEvent);
        return newEvent;
    }
    public Event GetById(Guid id)
    {
        foreach (var event_ in events)
        {
            if (event_.Id == id)
            {
                return event_;
            }
        }
        return null;
    }
    public bool UpgradeEvent(Event newEvent)
    {
        var eventFromDb = GetById(newEvent.Id);
        if (eventFromDb is null)
        {
            return false;
        }
        var index = events.IndexOf(eventFromDb);
        events[index] = newEvent;
        return true;
    }
    public bool DeleteEvent(Guid id)
    {
        var eventFromDb = GetById(id);
        if (eventFromDb is null)
        {
            return false;
        }
        events.Remove(eventFromDb);
        return true;
    }
    public List<Event> GetAllEvents()
    {
        return events;
    }
    public List<Event> GetEventsByLocation(string location)
    {
        var byLocation = new List<Event>();
        foreach (var event_ in events)
        {
            if (event_.Location == location)
            {
                byLocation.Add(event_);
            }
        }

        return byLocation;
    }
    public Event GetPopularEvent()
    {
        var mostPopularEvent = new Event();
        foreach (var eventItem in events)
        {
            if (eventItem.Attendees.Count > mostPopularEvent.Attendees.Count)
            {
                mostPopularEvent = eventItem;
            }
        }

        return mostPopularEvent;
    }
    public Event GetMaxTaggedEvent()
    {
        var mostNewTaggedEvent = new Event();
        foreach (var eventItem in events)
        {
            if (eventItem.Attendees.Count > mostNewTaggedEvent.Attendees.Count)
            {
                mostNewTaggedEvent = eventItem;
            }
        }

        return mostNewTaggedEvent;
    }
    public bool AddPersonToEvent(Guid Id, string person)
    {
        var eventFromDB = GetById(Id);
        if (eventFromDB is null)
        {
            return false;
        }
        eventFromDB.Attendees.Add(person);

        return true;
    }

}
