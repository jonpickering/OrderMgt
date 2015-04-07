using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace OrderMgt
{
    public static class OrderGateway
    {
        public static DataSet Find(String orderNumber)
        {
            // Return the dataset associated with a single instance of am order

            DataSet ds = new DataSet();
            using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.ordersdb.ToString()))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(String.Format("SELECT * FROM orders WHERE id={0}", orderNumber), conn);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(ds);
                da.FillSchema(ds, SchemaType.Source);
                conn.Close();
            }
            return ds;
        }

    }
}
