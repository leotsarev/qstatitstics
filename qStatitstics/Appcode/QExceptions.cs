namespace QStatitstics.Appcode;

[Serializable]
public class NotEnoughPlayersException : Exception
{
    public NotEnoughPlayersException(string teamName)
        :
            base("������������ ������� � ������� �" + teamName + "�")
    {
    }
}

[Serializable]
public class EventMalformedException : Exception
{
    public EventMalformedException(string msg)
        : base(msg)
    {
    }
}

[Serializable]
public class ReadOnlyMatchException : Exception
{
    public ReadOnlyMatchException()
        :
            base("���������� ������ ���������!")
    {
    }
}