using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace KM.WLData.Entry
{
    public static class Bill
    {
        private static Model.Bill ToBill(SqlDataReader rdr)
        {
            Model.Bill bill = new Model.Bill();

            bill.Userid = rdr["userid"].ToString();
            bill.P_Start = Convert.ToInt32(rdr["p_start"]);
            bill.P_Count = Convert.ToInt32(rdr["p_count"]);
            bill.P_Index = Convert.ToInt32(rdr["p_index"]);
            bill.P_State = (Model.BillState)Convert.ToChar(rdr["p_state"]);
            bill.CDT = Convert.ToDateTime(rdr["CDT"]);

            return bill;
        }

        public static bool Stepping(SqlCommand cmd, Model.Bill bill, int n = 1)
        {
            bill.P_Index += n;
            return Bill.Update(cmd, bill);
        }

        //public static bool Exists(SqlCommand cmd, string userid, int p_start, int p_count)
        //{
        //        cmd.CommandText = "SELECT COUNT(*) AS Count FROM BILL WHERE [userid] = @userid and [p_start] = @p_start";
        //        cmd.Parameters.Clear();
        //        cmd.Parameters.Add("@userid", SqlDbType.VarChar).Value = userid;
        //        cmd.Parameters.Add("@p_start", SqlDbType.Int).Value = p_start;

        //        return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
        //}

        public static bool Exists(SqlCommand cmd, string userid, Model.BillState p_state)
        {
            cmd.CommandText = "SELECT COUNT(*) AS Count FROM BILL WHERE [userid] = @userid and [p_state] = @p_state";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@userid", SqlDbType.VarChar).Value = userid;
            cmd.Parameters.Add("@p_state", SqlDbType.Char).Value = Convert.ToChar(p_state);

            return ((Convert.ToInt32(cmd.ExecuteScalar()) > 0) ? true : false);
        }

        public static bool Insert(SqlCommand cmd, Model.Bill bill)
        {
            cmd.CommandText = "INSERT INTO BILL ([userid], [p_start], [p_count], [p_index], [p_state]) VALUES (@userid, @p_start, @p_count, @p_index, @p_state)";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@userid", SqlDbType.VarChar).Value = bill.Userid;
            cmd.Parameters.Add("@p_start", SqlDbType.Int).Value = bill.P_Start;
            cmd.Parameters.Add("@p_count", SqlDbType.Int).Value = bill.P_Count;
            cmd.Parameters.Add("@p_index", SqlDbType.Int).Value = bill.P_Index;
            cmd.Parameters.Add("@p_state", SqlDbType.Char).Value = Convert.ToChar(bill.P_State);

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        public static bool Delete(SqlCommand cmd, string userid, int p_start)
        {
            cmd.CommandText = "DELETE FROM BILL WHERE [userid] = @userid AND [p_start] = @p_start";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@userid", SqlDbType.VarChar).Value = userid;
            cmd.Parameters.Add("@p_start", SqlDbType.Int).Value = p_start;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        public static bool Update(SqlCommand cmd, Model.Bill bill)
        {
            cmd.CommandText = "UPDATE BILL SET [p_index] = @p_index, [p_state] = @p_state WHERE [userid] = @userid AND [p_start] = @p_start";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@userid", SqlDbType.VarChar).Value = bill.Userid;
            cmd.Parameters.Add("@p_start", SqlDbType.Int).Value = bill.P_Start;
            cmd.Parameters.Add("@p_index", SqlDbType.Int).Value = bill.P_Index;
            cmd.Parameters.Add("@p_state", SqlDbType.Char).Value = Convert.ToChar(bill.P_State);

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        public static Model.Bill Read(SqlCommand cmd, string userid, Model.BillState p_state)
        {
            cmd.CommandText = "SELECT * FROM BILL WHERE [userid] = @userid AND [p_state] = @p_state";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@userid", SqlDbType.VarChar).Value = userid;
            cmd.Parameters.Add("@p_state", SqlDbType.Char).Value = Convert.ToChar(p_state);

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                if (rdr.Read()) return ToBill(rdr);
            }
            return null;
        }

        public static List<Model.Bill> Reads(SqlCommand cmd)
        {
            List<Model.Bill> list = new List<Model.Bill>();

            //cmd.CommandText = "SELECT * FROM BILL WHERE [p_state] <> 'E' ORDER BY CDT";
            cmd.CommandText = "SELECT * FROM BILL ORDER BY CDT";
            cmd.Parameters.Clear();

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    list.Add(ToBill(rdr));
                }
            }
            return list;
        }

        public static List<Model.Bill> Reads(SqlCommand cmd, string userid)
        {
            List<Model.Bill> list = new List<Model.Bill>();

            cmd.CommandText = "SELECT * FROM BILL WHERE [userid] = @userid ORDER BY CDT";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@userid", SqlDbType.VarChar).Value = userid;

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    list.Add(ToBill(rdr));
                }
            }
            return list;
        }

        public static bool ClearHistory(SqlCommand cmd)
        {
            cmd.CommandText = "DELETE FROM BILL WHERE [p_state] = 'E'";

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        public static bool ClearHistory(SqlCommand cmd, string userid)
        {
            cmd.CommandText = "DELETE FROM BILL WHERE [p_state] = 'E' AND [userid] = @userid";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@userid", SqlDbType.VarChar).Value = userid;

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }

        public static bool SetState(SqlCommand cmd, string userid, int p_start, Model.BillState p_state)
        {
            cmd.CommandText = "UPDATE [BILL] SET [p_state] = @p_state WHERE [userid] = @userid AND [p_start] = @p_start";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@userid", SqlDbType.VarChar).Value = userid;
            cmd.Parameters.Add("@p_start", SqlDbType.Int).Value = p_start;
            cmd.Parameters.Add("@p_state", SqlDbType.Char).Value = Convert.ToChar(p_state);

            return ((cmd.ExecuteNonQuery() > 0) ? true : false);
        }
    }
}
