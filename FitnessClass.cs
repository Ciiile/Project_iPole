namespace Project_iPole_01
{
    class FitnessClass
    {
        public string Title { get; set; }
        public int NumberOfParticipants { get; set; }
        public int Waitlist { get; set; }
        public string Time { get; set; }
        public string Date { get; set; }
        public int Room { get; set; }

        public FitnessClass (string title, int numberOfParticipants, int waitlist, string time, string date, int room)
        {
            Title = title;
            NumberOfParticipants = numberOfParticipants;
            Waitlist = waitlist;
            Time = time;
            Date = date;
            Room = room;
        }

        private bool Attending()
        {
            return true;
        }
    }
}
