namespace CarPolicy.Infrastructure
{
    using Messages;

    public static class Throw
    {
        public static void When<T>(bool condition, string message) where T : Exception, new()
        {
            if (condition)
            {
                var ex = (T)Activator.CreateInstance(typeof(T), message);
                throw ex;
            }
        }

        public static void When<T>(bool condition, int messageCode, string message) where T : ModelBaseException
        {
            if (condition)
            {
                var applicationMessage = new ApplicationMessage(messageCode, message);
                object[] parameters = new object[] { applicationMessage };
                var ex = (T)Activator.CreateInstance(typeof(T), parameters);
                throw ex;
            }
        }
    }
}
