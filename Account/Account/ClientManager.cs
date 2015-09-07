using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Account
{
    class ClientManager
    {
        public int ClientID { get; set; }
        public string ClientName { get; set; }
        public int LocationID { get; set; }
        public string ClientEmail { get; set; }
        public string ClientPhoneNo { get; set; }
        public string ClientAddress { get; set; }

        public ClientManager() 
        {

        }

        public ClientManager(string ClientName,int LocationID,string ClientEmail,string ClientPhoneNo,string ClientAddress) 
        {
            this.ClientName = ClientName;
            this.LocationID = LocationID;
            this.ClientEmail = ClientEmail;
            this.ClientPhoneNo = ClientPhoneNo;
            this.ClientAddress = ClientAddress;
        }

        public void AddNewClient(ClientManager newClient) 
        {
            SqlParameter[] sp = new SqlParameter[5];
            sp[0] = new SqlParameter("@ClientName", newClient.ClientName);
            sp[1] = new SqlParameter("@LocationID", newClient.LocationID);
            sp[2] = new SqlParameter("@ClientEmail", newClient.ClientEmail);
            sp[3] = new SqlParameter("@ClientPhoneNo", newClient.ClientPhoneNo);
            sp[4] = new SqlParameter("@ClientAddress", newClient.ClientAddress);

            datalayer.Execute_NonQuery("sp_AddClient", CommandType.StoredProcedure, sp);
        }

        public void updateClient(ClientManager client) 
        {
            SqlParameter[] sp = new SqlParameter[6];
            sp[0] = new SqlParameter("@ClientID", client.ClientID);
            sp[1] = new SqlParameter("@ClientName", client.ClientName);
            sp[2] = new SqlParameter("@LocationID", client.LocationID);
            sp[3] = new SqlParameter("@ClientEmail", client.ClientEmail);
            sp[4] = new SqlParameter("@ClientPhoneNo", client.ClientPhoneNo);
            sp[5] = new SqlParameter("@ClientAddress", client.ClientAddress);

            datalayer.Execute_NonQuery("sp_UpdateClient", CommandType.StoredProcedure, sp);
        }

        public void DeleteClient(int ClientID) 
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@ClientID", ClientID);
            datalayer.Execute_NonQuery("sp_DeleteClient", CommandType.StoredProcedure, sp);
        }

        public DataSet getClientByLocationID(int LocationID) 
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@LocationID", LocationID);
            return  datalayer.get_data("sp_getClientByLocationID", CommandType.StoredProcedure, sp);
        }

        public DataSet getClientList()
        {
            return datalayer.get_data("sp_getClientList", CommandType.StoredProcedure, null);
        }
    }
}
