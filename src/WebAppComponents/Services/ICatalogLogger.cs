   // File: src/WebAppComponents/Services/LoggingService.cs
   using System;
   
   namespace eShop.WebAppComponents.Services
   {
       public interface ICatalogLogger
       {
           void LogInfo(string message);
           void LogError(string message, Exception ex);
       }
   
       public class CatalogLogger : ICatalogLogger
       {
           public void LogInfo(string message)
           {
               // Implement your logging logic here
               Console.WriteLine($"INFO: {message}");
           }
   
           public void LogError(string message, Exception ex)
           {
               // Implement your logging logic here
               Console.WriteLine($"ERROR: {message} - Exception: {ex.Message}");
           }
       }
   }
