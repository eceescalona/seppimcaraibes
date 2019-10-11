namespace SeppimCaraibesApp.Domain.Controller
{
    using System;
    using System.ComponentModel;
    using System.Reflection;

    internal class C_Log
    {
        private const string NULL_PERSON = "System";
        private readonly Model.Log _mLog;


        public C_Log()
        {
            _mLog = new Model.Log();
        }


        public string GetEnumDescription(Enum value)
        {
            FieldInfo fielInfo = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] descriptionAttributes = (DescriptionAttribute[])fielInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (descriptionAttributes != null && descriptionAttributes.Length > 0)
            {
                return descriptionAttributes[0].Description;
            }
            else
            {
                return string.Empty;
            }
        }

        public T GetValueFromDescription<T>(string description)
        {
            var type = typeof(T);

            if (!type.IsEnum) throw new InvalidOperationException();
            foreach (var field in type.GetFields())
            {
                var attribute = Attribute.GetCustomAttribute(field,
                    typeof(DescriptionAttribute)) as DescriptionAttribute;
                if (attribute != null)
                {
                    if (attribute.Description == description)
                        return (T)field.GetValue(null);
                }
                else
                {
                    if (field.Name == description)
                        return (T)field.GetValue(null);
                }
            }
            throw new ArgumentException("Not found.", "description");
        }


        public void Write(string description, ETypeOfMessage logType)
        {
            string personName = string.Empty;

            if (UserLog.Instance != null)
            {
                personName = string.IsNullOrWhiteSpace(UserLog.Instance.FullName) ?
                    NULL_PERSON : UserLog.Instance.FullName;
            }

            _mLog.WriteLogIntoFile(personName, description, logType);
        }
    }
}
