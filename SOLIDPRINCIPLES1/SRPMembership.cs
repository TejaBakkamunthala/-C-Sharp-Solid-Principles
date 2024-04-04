using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.SqlServer.Server;

namespace SOLIDPRINCIPLES1
{
    public class SRPMembership
    {
        public void add()
        {
            try
            {

            }
            catch (Exception e)
            {
                FileLogger.LogError(e.Message);
            }


        }

        public class FileLogger
        {
            public static void LogError(string error)
            {
                File.WriteAllText(@"F:\Stream1\error.txt", error);
            }





        }
    }

}