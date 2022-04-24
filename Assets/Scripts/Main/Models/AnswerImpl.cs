using UnityEngine.UIElements;

namespace Models
{
    public class AnswerImpl : Answer
    {
        private string _text;
        private AnswerType _answerType;
        private int _eventId;

        public AnswerImpl(string text, AnswerType answerType, int eventId)
        {
            _text = text;
            _answerType = answerType;
            _eventId = eventId;
        }


        public string GetText()
        {
            return _text;
        }

        public AnswerType GetAnswerType()
        {
            return _answerType;
        }

        public int GetEventId()
        {
            return _eventId;
        }
    }
}