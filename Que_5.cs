
using System;

class Notification_Assignment
{
    
    delegate void NotificationChannel_IIT_Chaumuhan();

    static void SendEmail()
    {
        Console.WriteLine("GMAIL PAR SACHENDRA SIR KA NAYA ASSIGNMENT AA GAYA...Yay (BTW sir mail ko whatsapp se jyada chalate hain");
    }

    static void SendSMS()
    {
        Console.WriteLine("SARA DATA KHATAM HONE KA SMS ...(Ek toh yahan hostel mein wifi bhi kaam nahin karta");
    }

    static void SendWhatsApp()
    {
        Console.WriteLine("Sir aapne whatsapp group main kaun se 5 questions daale hain ?...alag se...I'm still searching them");
    }

    public static void Main()
    {
       
        NotificationChannel_IIT_Chaumuhan alertSystem = SendEmail;

        alertSystem += SendSMS;
        alertSystem += SendWhatsApp;

        Console.WriteLine("Notification Services:");
        
        
        alertSystem();
    }
}

