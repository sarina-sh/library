namespace LibraryManagement
{
    public class Rack
    {
        public int number ;
        public string locationIdentifier ;

        public Rack(int number, string locationIdentifier)
        {
            this.number = number;
            this.locationIdentifier = locationIdentifier;
        }

        protected Rack()
        {
            throw new NotImplementedException();
        }
    }
}