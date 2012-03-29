﻿namespace SignalR.Hubs
{
    public static class MethodExtensions
    {
        public static bool Matches(this MethodDescriptor action, params object[] parameters)
        {
            if ((action.Parameters.Count > 0 && parameters == null) 
                || action.Parameters.Count != parameters.Length)
            {
                return false;
            }

            return true;
        }
    }
}
