using System;
using System.Data.SqlClient;
using AAJControl;

namespace SampleSystem.Classes
{
    public class dbcontrol : DBControl
    {
        public dbcontrol() : base(DatabaseType.MSSQL, "SERVER=(LOCAL)\\MAYOGROUP;DATABASE=DBSAMPLE;USER=SA;PWD=1234")
        {
            
        }
    }
}