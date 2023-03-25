namespace PruebasNet.Clases
{
    public static class TransformatorDate
    {
        public static DateTime TransformarFecha(DateTime dateCreation, DateTime dateTime)
        {
            TimeSpan timeSpan = new(dateTime.Hour, dateTime.Minute, dateTime.Second);
            return dateCreation.Add(timeSpan);
        }
    }
}


