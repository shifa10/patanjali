using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Data.OleDb;
using System.Windows.Forms;

namespace my_project
{
    class logclass
    {
        OleDbConnection cn;
        OleDbCommand cmd;
        OleDbDataAdapter da;
        DataSet ds;
        string apppath = Path.GetDirectoryName(Application.ExecutablePath);


        public bool insert_up_delete(string qry)
        {

            cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + apppath + @"\patanjali1.accdb");
            cn.Open();
            cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = qry;

            int ans = cmd.ExecuteNonQuery();
            if (ans > 0)
                return true;
            else
                return false;

        }

       
        public DataSet select_data(string qry)
        {
            cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + apppath + @"\patanjali1.accdb");
            cn.Open();
            cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = qry;

            da = new OleDbDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            cn.Close();

            return ds;


        }

    }

}