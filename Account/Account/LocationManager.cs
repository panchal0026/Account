using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Account
{
    class LocationManager
    {
        public int LocationID { get; set; }
        public string LocationName { get; set; }
        public string LocationAddress { get; set; }

        public LocationManager() 
        {

        }

        public LocationManager(string LocationName, string LocationAddress) 
        {
            this.LocationName = LocationName;
            this.LocationAddress = LocationAddress;
        }

        public LocationManager(int LocationID, string LocationName, string LocationAddress)
        {
            this.LocationName = LocationName;
            this.LocationAddress = LocationAddress;
            this.LocationID = LocationID;
        }

        public bool AddLocation(LocationManager newLocation) 
        {
            SqlParameter[] sp = new SqlParameter[4];
            sp[0] = new SqlParameter("@LocationName",newLocation.LocationName);
            sp[1] = new SqlParameter("@LocationAddress",newLocation.LocationAddress);
            sp[2] = new SqlParameter("@CreatedDate", DateTime.Now);
            sp[3] = new SqlParameter("@IsDeleted", false);
            return datalayer.Execute_NonQuery("sp_AddNewLocation", CommandType.StoredProcedure, sp);
        }

        public void UpdateLocation(LocationManager location) 
        {
            SqlParameter[] sp = new SqlParameter[3];
            sp[0] = new SqlParameter("@LocationID", location.LocationID);
            sp[1] = new SqlParameter("@LocationName", location.LocationName);
            sp[2] = new SqlParameter("@LocationAddress", location.LocationAddress);
            datalayer.Execute_NonQuery("sp_UpdateLocation", CommandType.StoredProcedure, sp);
        }

        public void DeleteLocation(int LocationID) 
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@LocationID", LocationID);
            datalayer.Execute_NonQuery("sp_DeleteLocation", CommandType.StoredProcedure, sp);
        }

        public DataSet ListLocations() 
        {
            return datalayer.get_data("sp_ListLocations",CommandType.StoredProcedure,null);
        }

        public DataSet getLocationbyLocationID(int LocationID) 
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@LocationID", LocationID);
            return datalayer.get_data("sp_getLocationbyLocationID", CommandType.StoredProcedure, sp);
        }
    }
}
