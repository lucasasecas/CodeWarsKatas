using System;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;

public class SumFct
{
  public static BigInteger perimeter(BigInteger n) 
  {
    var result = GetFibonacci((int)n + 1).Aggregate((val, next) => 4 * next + val);
    return result;    
  }
  
  private static BigInteger[] GetFibonacci(int length)
  {
    var res = new List<BigInteger> { new BigInteger(0), new BigInteger(1) };
    
    if (length <= 2)
    {
      return res.ToArray();
    }
    
    for(var i = 2; i <= length; i++)
    {
      
      res.Add(BigInteger.Add(res.ElementAt(i-1), res.ElementAt(i - 2)));
    }
    
    return res.ToArray();
  }
}
