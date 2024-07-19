using assignment_C__4_OOP.Interfaces;
using System;

namespace assignment_C__4_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //1 b) To define a blueprint for a class
            //2 a) private
            //3 b) No
            //4 b) Yes, interfaces can inherit from multiple interfaces
            //5 d) implements
            //6 a) Yes
            //7 b) No, all members are implicitly public
            //8 b) To provide a clear separation between interface and class members
            //9 b) No, interfaces cannot have constructors
            //10 c) By separating interface names with commas

            #endregion

            #region Q1 Part02
            
            Circle circle = new Circle();
            circle.Raduis = 5;
            circle.Area= Math.PI* circle.Raduis*circle.Raduis;
            Console.WriteLine(circle.Area);
            Rectangle rectangle = new Rectangle();
            rectangle.Height = 3;
            rectangle.Width = 8;
            rectangle.Area= rectangle.Width*rectangle.Height;
            Console.WriteLine(rectangle.Area);

            #endregion

            #region Q2 part02 
            BasicAuthenticationService basicAuthenticationService = new BasicAuthenticationService();
            basicAuthenticationService.User = "admin";
            basicAuthenticationService.Pass = "password";
             Console.WriteLine(basicAuthenticationService.AuthenticateUser("admin","password")); 
            Console.WriteLine(basicAuthenticationService.AuthorizeUser("User", "Administrator"));

            #endregion

            #region Q3
            EmailNotificationService emailNotificationService = new EmailNotificationService();
            SmsNotificationService smsNotificationService = new SmsNotificationService();
            PushNotificationService pushNotificationService = new PushNotificationService();
            string recipient = "mo7medelgabry@gmail.com";
            string message = "Hello from notficition ";
            emailNotificationService.SendNotification(recipient, message);
            smsNotificationService.SendNotification(recipient, message);
            pushNotificationService.SendNotification(recipient, message);



            #endregion   



        }
    }
}
