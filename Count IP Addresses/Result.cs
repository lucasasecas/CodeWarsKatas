using System;
using System.Linq;

public class CountIPAddresses
{
   public static long IpsBetween(string start, string end)
   {
       var ip1 = start.Split('.').Select(x => int.Parse(x)).ToArray();
       var ip2 = end.Split('.').Select(x => int.Parse(x)).ToArray();
     
       return (ip2[0] - ip1[0]) * (long)Math.Pow(256, 3) +
              (ip2[1] - ip1[1]) * (long)Math.Pow(256, 2) +
              (ip2[2] - ip1[2]) * (long)Math.Pow(256, 1) +
              ip2[3] - ip1[3];
   }
}
