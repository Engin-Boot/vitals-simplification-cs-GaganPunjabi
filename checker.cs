using System;
using System.Diagnostics;

class Checker
{
    static bool vitalsAreOk(float bpm, float spo2, float respRate) {
        var flag1 = bpm_check(bpm);
        var flag2 = spo_check(spo2);
        var flag3 = resp_rate_check(respRate);
        if (flag1 == flag2 ==flag3 == true)
        {
            return true;
        }
        return false;
    }

    static bool bpm_check(float bpm)
    {
        return !(bpm < 70 || bpm > 150);
    }

    static bool spo_check(float spo2)
    {
        return !(spo2 < 90);
    }

    static bool resp_rate_check(float respRate)
    {
        return !(respRate < 30 || respRate > 95);
    }

    static void ExpectTrue(bool expression) {
        if(!expression) {
            Console.WriteLine("Expected true, but got false");
            Environment.Exit(1);
        }
    }
    static void ExpectFalse(bool expression) {
        if(expression) {
            Console.WriteLine("Expected false, but got true");
            Environment.Exit(1);
        }
    }
    static int Main() {
        ExpectTrue(vitalsAreOk(100, 95, 60));
        ExpectFalse(vitalsAreOk(40, 91, 92));
        Console.WriteLine("All ok");
        return 0;
    }
}
