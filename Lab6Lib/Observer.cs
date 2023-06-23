namespace Lab6Lib
{
    public interface ISubscriber
    {
        void update(
            string eventname
            );
    }

    public class Publisher
    {
        public List<ISubscriber> subscribers;
        public string eventname;

        public Publisher(string eventname)
        {
            this.eventname = eventname;
            subscribers = new List<ISubscriber>();
        }

        public void subscribe(ISubscriber subscriber)
        {
            subscribers.Add(subscriber);
        }

        public bool unsubscribe(ISubscriber subscriber)
        {
            subscribers.Remove(subscriber);
            return true;
        }

        public int nonify()
        {
            int counter = 0;
            foreach (ISubscriber subscriber in subscribers)
            {
                subscriber.update(eventname);
                counter++;
            }
            return counter;
        }

    }
}