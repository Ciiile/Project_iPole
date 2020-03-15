namespace Project_iPole_01
{
    class FitnessClassOverview : FitnessClass
    {
        public string Instructor { get; set; }
        public string Description { get; set; }

        public FitnessClassOverview (string title, int numberOfParticipants, int waitlist, string time, string date, int room, string instructor, string description) : base(title, numberOfParticipants, waitlist, time, date, room)
        {
            Instructor = instructor;
            Description = description;
        }


        public bool Enrol()
        {
            return true;
        }

        public bool EnrollToWaitlist()
        {
            return true;
        }
    }
}
