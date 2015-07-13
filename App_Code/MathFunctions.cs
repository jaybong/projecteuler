using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MathFunctions
/// </summary>
public class MathFunctions
{




	public MathFunctions()
	{

	}

    bool DebugMode = true;

    public bool IsPrime(int val)
    {

        if (val == 1) return false;
        if (val == 2) return true;

        if (val % 2 == 0) return false;

        for (int i = 3; i < val; i += 2)
        {
            if (val % i == 0) return false;
        }

        return true;
    }


}