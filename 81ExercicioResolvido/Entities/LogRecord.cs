namespace _81ExercicioResolvido.Entities
{
    internal class LogRecord
    {
        public string UserName { get; private set; }
        public DateTime MomentOfAccess { get; private set; }

        public LogRecord(string userName, DateTime momentOfAccess)
        {
            UserName = userName;
            MomentOfAccess = momentOfAccess;
        }

        public override int GetHashCode()
        {
            return UserName.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj is not LogRecord)
            {
                throw new ArgumentException("The data type is incorrect");
            }

            LogRecord other = obj as LogRecord;

            return UserName.Equals(other.UserName);
        }

        public override string ToString()
        {
            return $"{UserName}, {MomentOfAccess}";
        }
    }
}
