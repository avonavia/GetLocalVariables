using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

namespace GetMyLocalVariables
{
    public static class LocalVariables
    {
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static IEnumerable<string> GetLocalVariables<T>()
        {
            StackTrace trace = new StackTrace();
            StackFrame frame = trace.GetFrame(1);
            MethodBase method = frame.GetMethod();
            MethodBody methodBody = method.GetMethodBody();
            if (methodBody != null)
            {
                foreach (LocalVariableInfo local in methodBody.LocalVariables)
                {
                    var ttype = typeof(T);
                    var localtype = local.LocalType;
                    if (ttype == localtype)
                    {
                        yield return local.ToString();  
                    }
                }
            }
        }
    }
}
