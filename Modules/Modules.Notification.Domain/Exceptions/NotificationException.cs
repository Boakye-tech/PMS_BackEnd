// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Notification.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Domain/Exceptions/NotificationException.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Notification.Domain.Exceptions
{
    public class NotificationException : Exception
    {
        public NotificationException(string message) : base(message)
        {
        }

        public NotificationException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }

    public class NotificationConfigurationException : NotificationException
    {
        public NotificationConfigurationException(string message) : base(message)
        {
        }

        public NotificationConfigurationException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }

    public class NotificationDeliveryException : NotificationException
    {
        public NotificationDeliveryException(string message) : base(message)
        {
        }

        public NotificationDeliveryException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }

    public class NotificationTemplateException : NotificationException
    {
        public NotificationTemplateException(string message) : base(message)
        {
        }

        public NotificationTemplateException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}