using System;
using System.Net;
using System.Net.Sockets;

class ComputerInfo
{
    static void Main()
    {
        // Display current time
        DateTime currentTime = DateTime.Now;
        Console.WriteLine("Current Time: " + currentTime);

        // Display computer name
        string computerName = Environment.MachineName;
        Console.WriteLine("Computer Name: " + computerName);

        // Display computer IP address
        string ipAddress = GetIPAddress();
        Console.WriteLine("IP Address: " + ipAddress);
    }
    public static string GetIPAddress()
    {
        var hostName = Dns.GetHostEntry(Dns.GetHostName());  // Retrive the Name of HOST
        foreach (var ip in hostName.AddressList)
        {
            if (ip.AddressFamily == AddressFamily.InterNetwork)
            {
                return ip.ToString();
            }
        }
        throw new Exception("No network adapters with an IPv4 address in the system!");
    }
}